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

namespace FlexMoney.Application.Features.Transactions.Commands.Delete
{
    public class DeleteTransactionCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }
    internal class DeleteTransactionCommandHandler : IRequestHandler<DeleteTransactionCommand, Result<int>>
    {
        private readonly IStringLocalizer<DeleteTransactionCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly ITransactionRepository _transactionRepository;

        public DeleteTransactionCommandHandler(IUnitOfWork<int> unitOfWork, ITransactionRepository transactionRepository, IStringLocalizer<DeleteTransactionCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _transactionRepository = transactionRepository;
        }

        public async Task<Result<int>> Handle(DeleteTransactionCommand command, CancellationToken cancellationToken)
        {
            var transaction = await _unitOfWork.Repository<Transaction>().GetByIdAsync(command.Id);
            if (transaction != null)
            {
                await _transactionRepository.DeleteTransactionAsync(command);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllTransactionsFalseCacheKey);
                return await Result<int>.SuccessAsync(transaction.Id, _localizer["Transaction Deleted"]);
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Transaction Not Found!"]);
            }
        }
    }
}
