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

namespace FlexMoney.Application.Features.MemberLines.Commands.Delete
{
    public class DeleteMemberLineCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }
    internal class DeleteMemberLineCommandHandler : IRequestHandler<DeleteMemberLineCommand, Result<int>>
    {
        private readonly IStringLocalizer<DeleteMemberLineCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public DeleteMemberLineCommandHandler(IUnitOfWork<int> unitOfWork, IStringLocalizer<DeleteMemberLineCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(DeleteMemberLineCommand command, CancellationToken cancellationToken)
        {
            var memberLine = await _unitOfWork.Repository<MemberLine>().GetByIdAsync(command.Id);
            if (memberLine != null)
            {
                await _unitOfWork.Repository<MemberLine>().DeleteAsync(memberLine);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMemberLinesCacheKey);
                return await Result<int>.SuccessAsync(memberLine.Id, _localizer["Member Line Deleted"]);
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Member Line Not Found!"]);
            }
        }
    }
}
