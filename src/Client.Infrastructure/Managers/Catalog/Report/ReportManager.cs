using FlexMoney.Application.Features.Reports.Queries.GetAll;
using FlexMoney.Application.Features.Reports.Queries.GetById;
using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Client.Infrastructure.Extensions;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Report
{
    public class ReportManager : IReportManager
    {
        private readonly HttpClient _httpClient;

        public ReportManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<List<GetAllMembersReportResponse>>> GetAllMembersReportAsync()
        {
            var response = await _httpClient.GetAsync(Routes.ReportsEndpoints.GetAll);
            return await response.ToResult<List<GetAllMembersReportResponse>>();
        }

        public async Task<IResult<List<GetByIdReportResponse>>> GetReportByMemberIdAsync(GetByIdReportQuery request)
        {
            var response = await _httpClient.GetAsync(Routes.ReportsEndpoints.GetById(request.MemberId));
            return await response.ToResult<List<GetByIdReportResponse>>();
        }

        public async Task<IResult<List<GetByOwnerIdReportResponse>>> GetReportByOwnerIdAsync(GetByOwnerIdReportQuery request)
        {
            var response = await _httpClient.GetAsync(Routes.ReportsEndpoints.GetByOwnerId(request.OwnerId));
            return await response.ToResult<List<GetByOwnerIdReportResponse>>();
        }
    }
}
