using FlexMoney.Application.Features.Types.Commands.AddEdit;
using FlexMoney.Application.Features.Types.Queries.GettAll;
using FlexMoney.Client.Infrastructure.Extensions;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Type
{
    public class TypeManager : ITypeManager
    {

        private readonly HttpClient _httpClient;

        public TypeManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.TypesEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<List<GetAllTypesResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.TypesEndpoints.GetAll);
            return await response.ToResult<List<GetAllTypesResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditTypeCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.TypesEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}
