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

namespace FlexMoney.Application.Features.MemberLines.Queries.GetAll
{
    public class GetAllMemberLinesQuery : IRequest<Result<List<GetAllMemberLinesResponse>>>
    {
        public GetAllMemberLinesQuery()
        {
        }
    }
    internal class GetAllMemberLinesCachedQueryHandler : IRequestHandler<GetAllMemberLinesQuery, Result<List<GetAllMemberLinesResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllMemberLinesCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllMemberLinesResponse>>> Handle(GetAllMemberLinesQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<MemberLine>>> getAllMemberLines = () => _unitOfWork.Repository<MemberLine>().GetAllAsync();
            var memberLineList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllMemberLinesCacheKey, getAllMemberLines);
            var mappedMemberLines = _mapper.Map<List<GetAllMemberLinesResponse>>(memberLineList);
            return await Result<List<GetAllMemberLinesResponse>>.SuccessAsync(mappedMemberLines);
        }
    }
}
