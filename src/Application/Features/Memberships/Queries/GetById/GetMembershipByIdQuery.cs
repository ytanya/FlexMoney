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

namespace FlexMoney.Application.Features.Memberships.Queries.GetById
{
    public class GetMembershipByIdQuery : IRequest<Result<GetMembershipByIdResponse>>
    {
        public int Id { get; set; }
    }
    internal class GetMembershipByIdQueryHandler : IRequestHandler<GetMembershipByIdQuery, Result<GetMembershipByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetMembershipByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetMembershipByIdResponse>> Handle(GetMembershipByIdQuery query, CancellationToken cancellationToken)
        {
            var membership = await _unitOfWork.Repository<Membership>().GetByIdAsync(query.Id);
            var mappedDocument = _mapper.Map<GetMembershipByIdResponse>(membership);
            return await Result<GetMembershipByIdResponse>.SuccessAsync(mappedDocument);
        }
    }
}
