using FlexMoney.Application.Interfaces.Repositories;
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

namespace FlexMoney.Application.Features.Types.Commands.Delete
{
    public class DeleteTypeCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        internal class DeleteTypeCommandHandler : IRequestHandler<DeleteTypeCommand, Result<int>>
        {
            private readonly IStringLocalizer<DeleteTypeCommandHandler> _localizer;
            private readonly IUnitOfWork<int> _unitOfWork;
            private readonly IMoneyLineRepository _moneyLineRepository;

            public DeleteTypeCommandHandler(IUnitOfWork<int> unitOfWork, IMoneyLineRepository moneyLineRepository, IStringLocalizer<DeleteTypeCommandHandler> localizer)
            {
                _unitOfWork = unitOfWork;
                _localizer = localizer;
                _moneyLineRepository = moneyLineRepository;
            }

            public async Task<Result<int>> Handle(DeleteTypeCommand command, CancellationToken cancellationToken)
            {
                var isTypeUsed = await _moneyLineRepository.IsTypeUsed(command.Id);
                if (!isTypeUsed)
                {
                    var type = await _unitOfWork.Repository<Domain.Entities.Catalog.Type>().GetByIdAsync(command.Id);
                    if (type != null)
                    {
                        await _unitOfWork.Repository<Domain.Entities.Catalog.Type>().DeleteAsync(type);
                        await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllTypesCacheKey);
                        return await Result<int>.SuccessAsync(type.Id, _localizer["Type Deleted"]);
                    }
                    else
                    {
                        return await Result<int>.FailAsync(_localizer["Type Not Found!"]);
                    }
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Deletion Not Allowed. This Type Is In Use!"]);
                }
            }
        }
    }
}
