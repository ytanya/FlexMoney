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

namespace FlexMoney.Application.Features.Memberships.Commands.Delete
{
    public class DeleteMembershipCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }
    internal class DeleteMembershipCommandHandler : IRequestHandler<DeleteMembershipCommand, Result<int>>
    {
        private readonly IStringLocalizer<DeleteMembershipCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public DeleteMembershipCommandHandler(IUnitOfWork<int> unitOfWork,  IStringLocalizer<DeleteMembershipCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(DeleteMembershipCommand command, CancellationToken cancellationToken)
        {
            var membership = await _unitOfWork.Repository<Membership>().GetByIdAsync(command.Id);
            if (membership != null)
            {
                await _unitOfWork.Repository<Membership>().DeleteAsync(membership);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembershipsCacheKey);
                return await Result<int>.SuccessAsync(membership.Id, _localizer["Membership Deleted"]);
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Membership Not Found!"]);
            }
        }
    }
}
