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
    public class GetReadyCallerByLineIdQuery : IRequest<Result<List<GetReadyCallerByLineIdResponse>>>
    {
        public int LineId { get; set; }
    }
    internal class GetReadyCallerByLineIdQueryHandler : IRequestHandler<GetReadyCallerByLineIdQuery, Result<List<GetReadyCallerByLineIdResponse>>>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetReadyCallerByLineIdQueryHandler(IUnitOfWork<int> unitOfWork, ITransactionRepository transactionRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<GetReadyCallerByLineIdResponse>>> Handle(GetReadyCallerByLineIdQuery query, CancellationToken cancellationToken)
        {
            var transaction = await _transactionRepository.GetReadyCallerByLineIdAsync(query.LineId);
            var mappedTransaction = _mapper.Map<List<GetReadyCallerByLineIdResponse>>(transaction);
            return await Result<List<GetReadyCallerByLineIdResponse>>.SuccessAsync(mappedTransaction);
        }
    }
}
