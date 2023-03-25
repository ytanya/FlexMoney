using AutoMapper;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
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

namespace FlexMoney.Application.Features.Transactions.Queries.GetById
{
    public class GetTransactionByLineIdQuery : IRequest<Result<List<GetTransactionByLineIdResponse>>>
    {
        public int LineId { get; set; }
    }
    internal class GetTransactionByLineIdQueryHandler : IRequestHandler<GetTransactionByLineIdQuery, Result<List<GetTransactionByLineIdResponse>>>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetTransactionByLineIdQueryHandler(IUnitOfWork<int> unitOfWork, ITransactionRepository transactionRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<GetTransactionByLineIdResponse>>> Handle(GetTransactionByLineIdQuery query, CancellationToken cancellationToken)
        {
            var transaction = await _transactionRepository.GetByLineIdAsync(query.LineId);
            var mappedTransaction = _mapper.Map<List<GetTransactionByLineIdResponse>>(transaction);
            return await Result<List<GetTransactionByLineIdResponse>>.SuccessAsync(mappedTransaction);
        }
    }
}
