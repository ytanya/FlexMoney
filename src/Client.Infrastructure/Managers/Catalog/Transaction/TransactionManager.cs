using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
using FlexMoney.Client.Infrastructure.Extensions;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Transaction
{
    public class TransactionManager : ITransactionManager
    {
        private readonly HttpClient _httpClient;

        public TransactionManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.TransactionsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.TransactionsEndpoints.Export
                : Routes.TransactionsEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<IResult<List<GetAllTransactionsResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.TransactionsEndpoints.GetAll);
            return await response.ToResult<List<GetAllTransactionsResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditTransactionCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.TransactionsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}
