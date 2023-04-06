using AutoMapper;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Wrapper;
using LazyCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Transactions.Queries.GetAll
{
    public class GetAllTransactionsQuery : IRequest<Result<List<GetAllTransactionsResponse>>>
    {
        public bool latestOnly { get; set; }
        public GetAllTransactionsQuery()
        {
            
        }
    }
    internal class GetAllTransactionsCachedQueryHandler : IRequestHandler<GetAllTransactionsQuery, Result<List<GetAllTransactionsResponse>>>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllTransactionsCachedQueryHandler(IUnitOfWork<int> unitOfWork, ITransactionRepository transactionRepository, IMapper mapper, IAppCache cache)
        {
            _transactionRepository = transactionRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllTransactionsResponse>>> Handle(GetAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Transaction>>> getAllTransactions = async () =>
            {
                return await _transactionRepository.GetAllAsync(request.latestOnly);
            };
            var transactionList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllTransactionsCacheKey, getAllTransactions);
            var mappedTransactions = new List<GetAllTransactionsResponse>();
            foreach (var transaction in transactionList)
            {
                var type = await _unitOfWork.Repository<Domain.Entities.Catalog.Type>().GetByIdAsync(transaction.TypeId);
                var caller = await _unitOfWork.Repository<Member>().GetByIdAsync(transaction.CallerId);
                var moneyLine = await _unitOfWork.Repository<MoneyLine>().GetByIdAsync(transaction.LineId);

                var mappedTransactionItem = _mapper.Map<GetAllTransactionsResponse>(transaction);
                mappedTransactionItem.TypeName = type.Name;
                mappedTransactionItem.Caller = caller.Name;
                mappedTransactionItem.LineName = moneyLine.Name;
                mappedTransactions.Add(mappedTransactionItem);
            }

            return await Result<List<GetAllTransactionsResponse>>.SuccessAsync(mappedTransactions);
        }
    }
}
