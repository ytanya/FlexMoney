using FlexMoney.Application.Features.FlexMoneyTypes.Commands.AddFlexMoneyType;
using FlexMoney.Application.Features.FlexMoneyTypes.Queries.GettAll;
using FlexMoney.Client.Infrastructure.Extensions;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.FlexMoneyType
{
    public class FlexMoneyTypesManager : IFlexMoneyTypesManager
    {

        private readonly HttpClient _httpClient;

        public FlexMoneyTypesManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.FlexMoneyTypesEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<List<GetAllFlexMoneyResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.FlexMoneyTypesEndpoints.GetAll);
            return await response.ToResult<List<GetAllFlexMoneyResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddFlexMonryTypeCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.FlexMoneyTypesEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}
