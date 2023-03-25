using FlexMoney.Application.Features.MemberLines.Commands.AddEdit;
using FlexMoney.Application.Features.MemberLines.Queries.GetAll;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using FlexMoney.Client.Infrastructure.Extensions;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.MemberLine
{
    public class MemberLineManager : IMemberLineManager
    {
        private readonly HttpClient _httpClient;

        public MemberLineManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.MemberLinesEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.MemberLinesEndpoints.Export
                : Routes.MemberLinesEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<IResult<List<GetAllMemberLinesResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.MemberLinesEndpoints.GetAll);
            return await response.ToResult<List<GetAllMemberLinesResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditMemberLineCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.MemberLinesEndpoints.Save, request);
            return await response.ToResult<int>();
        }
        public async Task<IResult<List<GetMemberLineByLineIdResponse>>> GetByLineIdAsync(GetMemberLineByLineIdQuery request)
        {
            var response = await _httpClient.GetAsync(Routes.MemberLinesEndpoints.GetByLineId(request.LineId));
            return await response.ToResult<List<GetMemberLineByLineIdResponse>>();
        }
    }
}
