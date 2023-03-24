using FlexMoney.Application.Features.Members.Commands.Delete;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Domain.Entities.TypeFlexMoney;
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

namespace FlexMoney.Application.Features.FlexMoneyTypes.Commands.Delete
{
    public class DeleteFlexMoneyTypeCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        internal class DeleteFlexMoneyTypeCommandHandler : IRequestHandler<DeleteFlexMoneyTypeCommand, Result<int>>
        {
            private readonly IStringLocalizer<DeleteMemberCommandHandler> _localizer;
            private readonly IUnitOfWork<int> _unitOfWork;

            public DeleteFlexMoneyTypeCommandHandler(IUnitOfWork<int> unitOfWork, IStringLocalizer<DeleteMemberCommandHandler> localizer)
            {
                _unitOfWork = unitOfWork;
                _localizer = localizer;
            }

            public async Task<Result<int>> Handle(DeleteFlexMoneyTypeCommand command, CancellationToken cancellationToken)
            {
                var flexMoneyType = await _unitOfWork.Repository<FlexMoneyType>().GetByIdAsync(command.Id);
                if (flexMoneyType != null)
                {
                    await _unitOfWork.Repository<FlexMoneyType>().DeleteAsync(flexMoneyType);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembershipsCacheKey);
                    return await Result<int>.SuccessAsync(flexMoneyType.Id, _localizer["Flex Money Type Deleted"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Flex Money Type Not Found!"]);
                }
            }
        }
    }
}
