using AutoMapper;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Transactions.Queries.GetById
{
    public class GetTransactionByIdQuery : IRequest<Result<GetTransactionByIdResponse>>
    {
        public int Id { get; set; }
    }
    internal class GetTransactionByIdQueryHandler : IRequestHandler<GetTransactionByIdQuery, Result<GetTransactionByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetTransactionByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetTransactionByIdResponse>> Handle(GetTransactionByIdQuery query, CancellationToken cancellationToken)
        {
            var transaction = await _unitOfWork.Repository<Transaction>().GetByIdAsync(query.Id);
            var mappedTransaction = _mapper.Map<GetTransactionByIdResponse>(transaction);
            return await Result<GetTransactionByIdResponse>.SuccessAsync(mappedTransaction);
        }
    }
}
