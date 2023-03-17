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

namespace FlexMoney.Application.Features.Memberships.Commands.AddEdit
{
    public partial class AddEditMembershipCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Note { get; set; }
    }
    internal class AddEditMembershipCommandHandler : IRequestHandler<AddEditMembershipCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditMembershipCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public AddEditMembershipCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditMembershipCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditMembershipCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var membership = _mapper.Map<Membership>(command);
                await _unitOfWork.Repository<Membership>().AddAsync(membership);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembershipsCacheKey);
                return await Result<int>.SuccessAsync(membership.Id, _localizer["Membership Saved"]);
            }
            else
            {
                var membership = await _unitOfWork.Repository<Membership>().GetByIdAsync(command.Id);
                if (membership != null)
                {
                    membership.Name = command.Name ?? membership.Name;
                    membership.AccountNumber = command.AccountNumber ?? membership.AccountNumber;
                    membership.Note = command.Note ?? membership.Note;
                    await _unitOfWork.Repository<Membership>().UpdateAsync(membership);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembershipsCacheKey);
                    return await Result<int>.SuccessAsync(membership.Id, _localizer["Membership Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Membership Not Found!"]);
                }
            }
        }
    }
}
