using AutoMapper;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Wrapper;
using LazyCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.MemberLines.Queries.GetById
{
    public class GetMemberLineByLineIdQuery : IRequest<Result<List<GetMemberLineByLineIdResponse>>>
    {
        public int LineId { get; set; }
    }
    internal class GetMoneyLineByLineIdQueryHandler : IRequestHandler<GetMemberLineByLineIdQuery, Result<List<GetMemberLineByLineIdResponse>>>
    {
        private readonly IMemberLineRepository _memberLineRepository;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetMoneyLineByLineIdQueryHandler(IUnitOfWork<int> unitOfWork, IMemberLineRepository memberLineRepository, IMapper mapper)
        {
            _memberLineRepository = memberLineRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<List<GetMemberLineByLineIdResponse>>> Handle(GetMemberLineByLineIdQuery query, CancellationToken cancellationToken)
        {
            var memberLines = await _memberLineRepository.GetByLineIdAsync(query.LineId);
            var mappedMoneyLines = new List<GetMemberLineByLineIdResponse>();
            foreach (var memberLine in memberLines)
            {
                var member = await _unitOfWork.Repository<Member>().GetByIdAsync(memberLine.MemberId);
                var mappedMemberLineItem = _mapper.Map<GetMemberLineByLineIdResponse>(memberLine);
                mappedMemberLineItem.MemberName = member.Name; // set the member name property
                mappedMoneyLines.Add(mappedMemberLineItem);
            }           

            return await Result<List<GetMemberLineByLineIdResponse>>.SuccessAsync(mappedMoneyLines);
        }
    }
}
