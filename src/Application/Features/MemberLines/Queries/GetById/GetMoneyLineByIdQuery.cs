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

namespace FlexMoney.Application.Features.MemberLines.Queries.GetById
{
    public class GetMemberLineByIdQuery : IRequest<Result<GetMemberLineByIdResponse>>
    {
        public int Id { get; set; }
    }
    internal class GetMemberLineByIdQueryHandler : IRequestHandler<GetMemberLineByIdQuery, Result<GetMemberLineByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetMemberLineByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetMemberLineByIdResponse>> Handle(GetMemberLineByIdQuery query, CancellationToken cancellationToken)
        {
            var memberLine = await _unitOfWork.Repository<MemberLine>().GetByIdAsync(query.Id);
            var mappedDocument = _mapper.Map<GetMemberLineByIdResponse>(memberLine);
            return await Result<GetMemberLineByIdResponse>.SuccessAsync(mappedDocument);
        }
    }
}
