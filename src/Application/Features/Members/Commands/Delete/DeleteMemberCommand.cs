using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Wrapper;
using MediatR;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Members.Commands.Delete
{
    public class DeleteMemberCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }
    internal class DeleteMemberCommandHandler : IRequestHandler<DeleteMemberCommand, Result<int>>
    {
        private readonly IStringLocalizer<DeleteMemberCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMemberRepository _memberRepository;
        private readonly IMemberLineRepository _memberLineRepository;

        public DeleteMemberCommandHandler(IUnitOfWork<int> unitOfWork, IMemberRepository memberRepository, IMemberLineRepository memberLineRepository, IStringLocalizer<DeleteMemberCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _memberRepository = memberRepository;
            _memberLineRepository = memberLineRepository;
        }

        public async Task<Result<int>> Handle(DeleteMemberCommand command, CancellationToken cancellationToken)
        {
            var isMemberUsed = await _memberLineRepository.IsMemberUsed(command.Id);
            if (!isMemberUsed)
            {
                var member = await _unitOfWork.Repository<Member>().GetByIdAsync(command.Id);
                if (member != null)
                {
                    await _memberRepository.DeleteMemberAsync(command);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembersCacheKey);
                    return await Result<int>.SuccessAsync(member.Id, _localizer["Member Deleted"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Member Not Found!"]);
                }
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Deletion Not Allowed. This Member Is In Use!"]);
            }
        }
    }
}
