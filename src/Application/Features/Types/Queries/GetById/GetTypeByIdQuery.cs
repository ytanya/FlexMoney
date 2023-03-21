using AutoMapper;
using FlexMoney.Application.Features.Types.Queries.GetById;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Types.Queries.GetById
{
    public class GetTypeByIdQuery : IRequest<Result<GetTypeByIdResponse>>
    {
        public int Id { get; set; }
    }
    
    internal class GetFlexMoneyByIdQueryHandler : IRequestHandler<GetTypeByIdQuery, Result<GetTypeByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetFlexMoneyByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<GetTypeByIdResponse>> Handle(GetTypeByIdQuery query, CancellationToken cancellationToken)
        {
            var type = await _unitOfWork.Repository<Domain.Entities.Catalog.Type>().GetByIdAsync(query.Id);
            var mappedDocument = _mapper.Map<GetTypeByIdResponse>(type);
            return await Result<GetTypeByIdResponse>.SuccessAsync(mappedDocument);
        }
    }
}

