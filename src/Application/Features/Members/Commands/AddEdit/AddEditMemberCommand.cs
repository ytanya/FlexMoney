using AutoMapper;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Wrapper;
using MediatR;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Members.Commands.AddEdit
{
    public partial class AddEditMemberCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Note { get; set; }
    }
    internal class AddEditMemberCommandHandler : IRequestHandler<AddEditMemberCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditMemberCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMemberRepository _memberRepository;

        public AddEditMemberCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IMemberRepository memberRepository, IStringLocalizer<AddEditMemberCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
            _memberRepository = memberRepository;
        }

        public async Task<Result<int>> Handle(AddEditMemberCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var isNameUnique = await _memberRepository.IsNameUnique(command.Name);
                if (!isNameUnique)
                {
                    var member = _mapper.Map<Member>(command);
                    await _unitOfWork.Repository<Member>().AddAsync(member);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembersCacheKey);
                    return await Result<int>.SuccessAsync(member.Id, _localizer["Member Saved"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Member Name Is Existed!"]);
                }
            }
            else
            {
                var member = await _unitOfWork.Repository<Member>().GetByIdAsync(command.Id);
                if (member != null)
                {
                    member.Name = command.Name ?? member.Name;
                    member.AccountNumber = command.AccountNumber ?? member.AccountNumber;
                    member.Note = command.Note ?? member.Note;
                    await _unitOfWork.Repository<Member>().UpdateAsync(member);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembersCacheKey);
                    return await Result<int>.SuccessAsync(member.Id, _localizer["Member Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Member Not Found!"]);
                }
            }

        }
    }
}
