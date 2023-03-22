using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Client.Infrastructure.Extensions;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine
{
    public class MoneyLineManager : IMoneyLineManager
    {
        private readonly HttpClient _httpClient;

        public MoneyLineManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.MoneyLinesEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.MoneyLinesEndpoints.Export
                : Routes.MoneyLinesEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<IResult<List<GetAllMoneyLinesResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.MoneyLinesEndpoints.GetAll);
            return await response.ToResult<List<GetAllMoneyLinesResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditMoneyLineCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.MoneyLinesEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}
