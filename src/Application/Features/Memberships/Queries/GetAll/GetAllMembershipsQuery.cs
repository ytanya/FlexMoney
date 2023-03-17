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

namespace FlexMoney.Application.Features.Memberships.Queries.GetAll
{
    public class GetAllMembershipsQuery : IRequest<Result<List<GetAllMembershipsResponse>>>
    {
        public GetAllMembershipsQuery()
        {
        }
    }
    internal class GetAllMembershipsCachedQueryHandler : IRequestHandler<GetAllMembershipsQuery, Result<List<GetAllMembershipsResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllMembershipsCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllMembershipsResponse>>> Handle(GetAllMembershipsQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Membership>>> getAllMemberships = () => _unitOfWork.Repository<Membership>().GetAllAsync();
            var membershipList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllMembershipsCacheKey, getAllMemberships);
            var mappedMemberships = _mapper.Map<List<GetAllMembershipsResponse>>(membershipList);
            return await Result<List<GetAllMembershipsResponse>>.SuccessAsync(mappedMemberships);
        }
    }
}
