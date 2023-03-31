using AutoMapper;
using FlexMoney.Application.Features.Reports.Queries.GetAll;
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

namespace FlexMoney.Application.Features.Reports.Queries.GetById
{
    public class GetByIdReportQuery : IRequest<Result<List<GetByIdReportResponse>>>
    {
        public int MemberId { get; set; }
    }
    internal class GetTransactionByIdQueryHandler : IRequestHandler<GetByIdReportQuery, Result<List<GetByIdReportResponse>>>
    {
        private readonly IReportRepository _reportRepository;
        private readonly IMapper _mapper;

        public GetTransactionByIdQueryHandler(IReportRepository reportRepository, IMapper mapper)
        {
            _reportRepository = reportRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<GetByIdReportResponse>>> Handle(GetByIdReportQuery query, CancellationToken cancellationToken)
        {
            var report = await _reportRepository.GetByIdReportAsync(query.MemberId);
            var mappedReport = _mapper.Map<List<GetByIdReportResponse>>(report);
            return await Result<List<GetByIdReportResponse>>.SuccessAsync(mappedReport);
        }
    }
}
