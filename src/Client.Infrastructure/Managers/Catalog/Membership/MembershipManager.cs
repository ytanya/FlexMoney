using FlexMoney.Application.Features.Memberships.Commands.AddEdit;
using FlexMoney.Application.Features.Memberships.Queries.GetAll;
using FlexMoney.Client.Infrastructure.Extensions;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Membership
{
    public class MembershipManager : IMembershipManager
    {
        private readonly HttpClient _httpClient;

        public MembershipManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.MembershipsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.MembershipsEndpoints.Export
                : Routes.MembershipsEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<IResult<List<GetAllMembershipsResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.MembershipsEndpoints.GetAll);
            return await response.ToResult<List<GetAllMembershipsResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditMembershipCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.MembershipsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}
