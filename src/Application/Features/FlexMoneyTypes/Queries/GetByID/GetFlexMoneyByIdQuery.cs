using AutoMapper;
using FlexMoney.Application.Features.Members.Queries.GetById;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Domain.Entities.TypeFlexMoney;
using FlexMoney.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.FlexMoneyTypes.Queries.GetByID
{
    public class GetFlexMoneyByIdQuery : IRequest<Result<GetFlexMoneyTypeByIdResponse>>
    {
        public int Id { get; set; }
    }
    
    internal class GetFlexMoneyByIdQueryHandler : IRequestHandler<GetFlexMoneyByIdQuery, Result<GetFlexMoneyTypeByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetFlexMoneyByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<GetFlexMoneyTypeByIdResponse>> Handle(GetFlexMoneyByIdQuery query, CancellationToken cancellationToken)
        {
            var flexMoneyType = await _unitOfWork.Repository<FlexMoneyType>().GetByIdAsync(query.Id);
            var mappedDocument = _mapper.Map<GetFlexMoneyTypeByIdResponse>(flexMoneyType);
            return await Result<GetFlexMoneyTypeByIdResponse>.SuccessAsync(mappedDocument);
        }
    }
}

