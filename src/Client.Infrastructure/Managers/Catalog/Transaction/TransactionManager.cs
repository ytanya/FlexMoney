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

        public async Task<IResult<List<GetAllTransactionsResponse>>> GetAllAsync(bool latestOnly)
        {
            var response = await _httpClient.GetAsync(Routes.TransactionsEndpoints.GetAll(latestOnly));
            return await response.ToResult<List<GetAllTransactionsResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditTransactionCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.TransactionsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
        public async Task<IResult<List<GetTransactionByLineIdResponse>>> GetByLineIdAsync(GetTransactionByLineIdQuery request)
        {
            var response = await _httpClient.GetAsync(Routes.TransactionsEndpoints.GetByLineId(request.LineId));
            return await response.ToResult<List<GetTransactionByLineIdResponse>>();
        }

        public async Task<IResult<GetTransactionInfoByLineIdResponse>> GetTransactionInfoByLineIdAsync(GetTransactionInfoByLineIdQuery request)
        {
            var response = await _httpClient.GetAsync(Routes.TransactionsEndpoints.GetTransactionInfoByLineId(request.LineId));
            return await response.ToResult<GetTransactionInfoByLineIdResponse>();
        }

        public async Task<IResult<List<GetReadyCallerByLineIdResponse>>> GetReadyCallerByLineIdAsync(GetReadyCallerByLineIdQuery request)
        {
            var response = await _httpClient.GetAsync(Routes.TransactionsEndpoints.GetReadyCallerByLineId(request.LineId));
            return await response.ToResult<List<GetReadyCallerByLineIdResponse>>();
        }

        public async Task<IResult<int>> SaveTransactionInfoAsync(AddEditTransactionCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.TransactionsEndpoints.SaveTransactionInfo, request);
            return await response.ToResult<int>();
        }
    }
}
