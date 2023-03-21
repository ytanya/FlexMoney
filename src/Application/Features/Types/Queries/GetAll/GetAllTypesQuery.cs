using AutoMapper;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Wrapper;
using LazyCache;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Types.Queries.GettAll
{
    public class GetAllTypesQuery : IRequest<Result<List<GetAllTypesResponse>>>
    {
        public GetAllTypesQuery()
        {

        }
    }
    internal class GetAllTypesCachedQueryHandler : IRequestHandler<GetAllTypesQuery, Result<List<GetAllTypesResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllTypesCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllTypesResponse>>> Handle(GetAllTypesQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Domain.Entities.Catalog.Type>>> getAllTypes = () => _unitOfWork.Repository<Domain.Entities.Catalog.Type>().GetAllAsync();
            var typeList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllTypesCacheKey, getAllTypes);
            var mappedType = _mapper.Map<List<GetAllTypesResponse>>(typeList);
            return await Result<List<GetAllTypesResponse>>.SuccessAsync(mappedType);
        }
    }
}
