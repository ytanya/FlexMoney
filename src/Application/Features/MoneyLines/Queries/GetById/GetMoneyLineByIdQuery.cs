using AutoMapper;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.MoneyLines.Queries.GetById
{
    public class GetMoneyLineByIdQuery : IRequest<Result<GetMoneyLineByIdResponse>>
    {
        public int Id { get; set; }
    }
    internal class GetMoneyLineByIdQueryHandler : IRequestHandler<GetMoneyLineByIdQuery, Result<GetMoneyLineByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetMoneyLineByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetMoneyLineByIdResponse>> Handle(GetMoneyLineByIdQuery query, CancellationToken cancellationToken)
        {
            var moneyLine = await _unitOfWork.Repository<MoneyLine>().GetByIdAsync(query.Id);
            var mappedDocument = _mapper.Map<GetMoneyLineByIdResponse>(moneyLine);
            return await Result<GetMoneyLineByIdResponse>.SuccessAsync(mappedDocument);
        }
    }
}
