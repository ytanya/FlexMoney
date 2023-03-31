using AutoMapper;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
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

namespace FlexMoney.Application.Features.Reports.Queries.GetAll
{
    public class GetAllMembersReportQuery : IRequest<Result<List<GetAllMembersReportResponse>>>
    {
        public GetAllMembersReportQuery()
        {
        }
    }
    internal class GetAllMembersReportCachedQueryHandler : IRequestHandler<GetAllMembersReportQuery, Result<List<GetAllMembersReportResponse>>>
    {
        private readonly IMapper _mapper;
        private readonly IReportRepository _reportRepository;
        public GetAllMembersReportCachedQueryHandler(IReportRepository reportRepository, IMapper mapper)
        {

            _mapper = mapper;
            _reportRepository = reportRepository;
        }

        public async Task<Result<List<GetAllMembersReportResponse>>> Handle(GetAllMembersReportQuery request, CancellationToken cancellationToken)
        {
            var report = await _reportRepository.GetAllMembersReportAsync();
            var mappedReport = _mapper.Map<List<GetAllMembersReportResponse>>(report);
            return await Result<List<GetAllMembersReportResponse>>.SuccessAsync(mappedReport);
        }
    }
}
