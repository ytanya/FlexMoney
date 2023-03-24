using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Application.Features.Members.Queries.GetAll;
using FlexMoney.Client.Infrastructure.Extensions;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Member
{
    public class MemberManager : IMemberManager
    {
        private readonly HttpClient _httpClient;

        public MemberManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.MembersEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.MembersEndpoints.Export
                : Routes.MembersEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<IResult<List<GetAllMembersResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.MembersEndpoints.GetAll);
            return await response.ToResult<List<GetAllMembersResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditMemberCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.MembersEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}
