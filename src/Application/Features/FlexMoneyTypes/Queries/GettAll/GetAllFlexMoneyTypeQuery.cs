using AutoMapper;
using FlexMoney.Application.Features.Memberships.Queries.GetAll;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Domain.Entities.TypeFlexMoney;
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

namespace FlexMoney.Application.Features.FlexMoneyTypes.Queries.GettAll
{
    public class GetAllFlexMoneyTypeQuery : IRequest<Result<List<GetAllFlexMoneyResponse>>>
    {
        public GetAllFlexMoneyTypeQuery()
        {

        }
    }
    internal class GetAllFlexMoneyTypeCachedQueryHandler : IRequestHandler<GetAllFlexMoneyTypeQuery, Result<List<GetAllFlexMoneyResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllFlexMoneyTypeCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllFlexMoneyResponse>>> Handle(GetAllFlexMoneyTypeQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<FlexMoneyType>>> getAllFlexMoneyTypes = () => _unitOfWork.Repository<FlexMoneyType>().GetAllAsync();
            var flexMoneyTypeLise = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllFlexMoneyTypeCacheKey, getAllFlexMoneyTypes);
            var mappedFlexMoneyType = _mapper.Map<List<GetAllFlexMoneyResponse>>(flexMoneyTypeLise);
            return await Result<List<GetAllFlexMoneyResponse>>.SuccessAsync(mappedFlexMoneyType);
        }
    }
}
