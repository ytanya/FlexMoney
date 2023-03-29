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

namespace FlexMoney.Application.Features.MoneyLines.Queries.GetAll
{
    public class GetAllMoneyLinesQuery : IRequest<Result<List<GetAllMoneyLinesResponse>>>
    {
        public GetAllMoneyLinesQuery()
        {
        }
    }
    internal class GetAllMoneyLinesCachedQueryHandler : IRequestHandler<GetAllMoneyLinesQuery, Result<List<GetAllMoneyLinesResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllMoneyLinesCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllMoneyLinesResponse>>> Handle(GetAllMoneyLinesQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<MoneyLine>>> getAllMoneyLines = () => _unitOfWork.Repository<MoneyLine>().GetAllAsync();
            var moneyLineList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllMoneyLinesCacheKey, getAllMoneyLines);
            var mappedMoneyLines = new List<GetAllMoneyLinesResponse>();
            foreach (var moneyLine in moneyLineList)
            {
                var type = await _unitOfWork.Repository<Domain.Entities.Catalog.Type>().GetByIdAsync(moneyLine.TypeId);
                var owner = await _unitOfWork.Repository<Domain.Entities.Catalog.Member>().GetByIdAsync(moneyLine.OwnerId);
                var mappedMoneyLineItem = _mapper.Map<GetAllMoneyLinesResponse>(moneyLine);
                mappedMoneyLineItem.TypeName = type.Name; // set the type name property
                mappedMoneyLineItem.OwnerName = owner.Name; // set the member name property
                mappedMoneyLines.Add(mappedMoneyLineItem);
            }

            return await Result<List<GetAllMoneyLinesResponse>>.SuccessAsync(mappedMoneyLines);
        }
    }
}
