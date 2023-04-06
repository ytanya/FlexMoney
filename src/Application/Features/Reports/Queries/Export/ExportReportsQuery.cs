using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Application.Interfaces.Services;
using FlexMoney.Domain.Entities.Catalog;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FlexMoney.Application.Extensions;
using FlexMoney.Application.Specifications.Catalog;
using FlexMoney.Shared.Wrapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using FlexMoney.Application.Specifications.Report;
using FlexMoney.Application.Features.Reports.Queries.GetAll;
using FlexMoney.Application.Features.Reports.Queries.GetById;

namespace FlexMoney.Application.Features.Reports.Queries.Export
{
    public class ExportReportsQuery : IRequest<Result<string>>
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        //public string SearchString { get; set; }

        //public ExportReportsQuery(string searchString = "")
        //{
        //    SearchString = searchString;
        //}
    }

    internal class ExportReportsQueryHandler : IRequestHandler<ExportReportsQuery, Result<string>>
    {
        private readonly IExcelService _excelService;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IStringLocalizer<ExportReportsQueryHandler> _localizer;
        private readonly IReportRepository _reportRepository;
        public ExportReportsQueryHandler(IExcelService excelService
            , IUnitOfWork<int> unitOfWork
            , IStringLocalizer<ExportReportsQueryHandler> localizer, IReportRepository reportRepository)
        {
            _excelService = excelService;
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _reportRepository = reportRepository;
        }

        public async Task<Result<string>> Handle(ExportReportsQuery request, CancellationToken cancellationToken)
        {
            if (request.Prefix == "all")
            {
                var members = await _reportRepository.GetAllMembersReportAsync();
                var data = await _excelService.ExportAsync(members, mappers: new Dictionary<string, Func<GetAllMembersReportResponse, object>>
            {
                { _localizer["Name"], item => item.MemberName },
                { _localizer["Earn"], item => item.Earn },
                { _localizer["Pay"], item => item.Pay },
                { _localizer["ThankMoney"], item => item.ThankMoney },
                { _localizer["Alive"], item => item.Alive },
                { _localizer["Dead"], item => item.Dead }
            }, sheetName: _localizer["AllMembersReport"]);

                return await Result<string>.SuccessAsync(data: data);
            }
            else if(request.Prefix == "thankmoney")
            {
                var members = await _reportRepository.GetByOwnerIdReportAsync(request.Id);
                var data = await _excelService.ExportAsync(members, mappers: new Dictionary<string, Func<GetByOwnerIdReportResponse, object>>
            {
                { _localizer["Date"], item => item.CreatedDate },
                { _localizer["Name"], item => item.LineName },
                { _localizer["Quantity"], item => item.Quantity },
                { _localizer["CurrentSecion"], item => item.CurrentSection },
                { _localizer["ThankMoney"], item => item.ThankMoney }
            }, sheetName: _localizer["ThankMoneyReport"]);

                return await Result<string>.SuccessAsync(data: data);
            }
            else
            {
                var members = await _reportRepository.GetByIdReportAsync(request.Id);
                var data = await _excelService.ExportAsync(members, mappers: new Dictionary<string, Func<GetByIdReportResponse, object>>
            {
                { _localizer["Date"], item => item.CreatedDate },
                { _localizer["LineName"], item => item.LineName },
                { _localizer["CurrentSection"], item => item.CurrentSection },
                { _localizer["Earn"], item => item.Earn },
                { _localizer["Pay"], item => item.Pay }
            }, sheetName: _localizer["SingleMemberReport"]);

                return await Result<string>.SuccessAsync(data: data);
            }
        }
    }
}