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

namespace FlexMoney.Application.Features.MoneyLines.Commands.Delete
{
    public class DeleteMoneyLineCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }
    internal class DeleteMoneyLineCommandHandler : IRequestHandler<DeleteMoneyLineCommand, Result<int>>
    {
        private readonly IStringLocalizer<DeleteMoneyLineCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public DeleteMoneyLineCommandHandler(IUnitOfWork<int> unitOfWork, IStringLocalizer<DeleteMoneyLineCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(DeleteMoneyLineCommand command, CancellationToken cancellationToken)
        {
            var moneyLine = await _unitOfWork.Repository<MoneyLine>().GetByIdAsync(command.Id);
            if (moneyLine != null)
            {
                await _unitOfWork.Repository<MoneyLine>().DeleteAsync(moneyLine);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMoneyLinesCacheKey);
                return await Result<int>.SuccessAsync(moneyLine.Id, _localizer["Money Line Deleted"]);
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Money Line Not Found!"]);
            }
        }
    }
}
