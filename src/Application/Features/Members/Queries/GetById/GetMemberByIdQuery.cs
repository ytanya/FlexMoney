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

namespace FlexMoney.Application.Features.Members.Queries.GetById
{
    public class GetMemberByIdQuery : IRequest<Result<GetMemberByIdResponse>>
    {
        public int Id { get; set; }
    }
    internal class GetMemberByIdQueryHandler : IRequestHandler<GetMemberByIdQuery, Result<GetMemberByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetMemberByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetMemberByIdResponse>> Handle(GetMemberByIdQuery query, CancellationToken cancellationToken)
        {
            var member = await _unitOfWork.Repository<Member>().GetByIdAsync(query.Id);
            var mappedDocument = _mapper.Map<GetMemberByIdResponse>(member);
            return await Result<GetMemberByIdResponse>.SuccessAsync(mappedDocument);
        }
    }
}
