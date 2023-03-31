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
    public class GetByOwnerIdReportQuery : IRequest<Result<List<GetByOwnerIdReportResponse>>>
    {
        public int OwnerId { get; set; }
    }
    internal class GetTransactionByOwnerIdQueryHandler : IRequestHandler<GetByOwnerIdReportQuery, Result<List<GetByOwnerIdReportResponse>>>
    {
        private readonly IReportRepository _reportRepository;
        private readonly IMapper _mapper;

        public GetTransactionByOwnerIdQueryHandler(IReportRepository reportRepository, IMapper mapper)
        {
            _reportRepository = reportRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<GetByOwnerIdReportResponse>>> Handle(GetByOwnerIdReportQuery query, CancellationToken cancellationToken)
        {
            var report = await _reportRepository.GetByOwnerIdReportAsync(query.OwnerId);
            var mappedReport = _mapper.Map<List<GetByOwnerIdReportResponse>>(report);
            return await Result<List<GetByOwnerIdReportResponse>>.SuccessAsync(mappedReport);
        }
    }
}
