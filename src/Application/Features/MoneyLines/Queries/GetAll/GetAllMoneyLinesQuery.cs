﻿using AutoMapper;
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
            var mappedMoneyLines = _mapper.Map<List<GetAllMoneyLinesResponse>>(moneyLineList);
            return await Result<List<GetAllMoneyLinesResponse>>.SuccessAsync(mappedMoneyLines);
        }
    }
}
