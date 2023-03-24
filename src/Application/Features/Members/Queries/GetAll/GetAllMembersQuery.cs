using AutoMapper;
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

namespace FlexMoney.Application.Features.Members.Queries.GetAll
{
    public class GetAllMembersQuery : IRequest<Result<List<GetAllMembersResponse>>>
    {
        public GetAllMembersQuery()
        {
        }
    }
    internal class GetAllMembersCachedQueryHandler : IRequestHandler<GetAllMembersQuery, Result<List<GetAllMembersResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllMembersCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllMembersResponse>>> Handle(GetAllMembersQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Member>>> getAllMembers = () => _unitOfWork.Repository<Member>().GetAllAsync();
            var memberList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllMembersCacheKey, getAllMembers);
            var mappedMembers = _mapper.Map<List<GetAllMembersResponse>>(memberList);
            return await Result<List<GetAllMembersResponse>>.SuccessAsync(mappedMembers);
        }
    }
}
