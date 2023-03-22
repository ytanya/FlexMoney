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
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Transactions.Queries.GetAll
{
    public class GetAllTransactionsQuery : IRequest<Result<List<GetAllTransactionsResponse>>>
    {
        public GetAllTransactionsQuery()
        {
        }
    }
    internal class GetAllTransactionsCachedQueryHandler : IRequestHandler<GetAllTransactionsQuery, Result<List<GetAllTransactionsResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllTransactionsCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllTransactionsResponse>>> Handle(GetAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Transaction>>> getAllTransactions = () => _unitOfWork.Repository<Transaction>().GetAllAsync();
            var transactionList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllTransactionsCacheKey, getAllTransactions);
            var mappedTransactions = _mapper.Map<List<GetAllTransactionsResponse>>(transactionList);
            return await Result<List<GetAllTransactionsResponse>>.SuccessAsync(mappedTransactions);
        }
    }
}
