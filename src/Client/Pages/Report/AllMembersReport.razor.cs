using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using FlexMoney.Application.Features.MemberLines.Queries.GetAll;
using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Application.Features.Members.Queries.GetAll;
using FlexMoney.Application.Features.Reports.Queries.GetAll;
using FlexMoney.Client.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Member;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Product;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Report;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.JSInterop;
using MudBlazor;

namespace FlexMoney.Client.Pages.Report
{
    public partial class AllMembersReport
    {
        [Inject] private IReportManager ReportManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private List<GetAllMembersReportResponse> _allMemberReportList = new();
        private GetAllMembersReportResponse _allMemberReport = new();
        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canExportAllMembersReport;
        private bool _canSearchMembers;
        private bool _loaded;
        private List<string> data;
        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            //_canCreateMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Create)).Succeeded;
            //_canEditMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Edit)).Succeeded;
            //_canDeleteMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Delete)).Succeeded;
            _canExportAllMembersReport = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Reports.Export)).Succeeded;
            //_canSearchMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Search)).Succeeded;

            await GetAllMembersReportAsync();
            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task GetAllMembersReportAsync()
        {
            var response = await ReportManager.GetAllMembersReportAsync();
            if (response.Succeeded)
            {
                _allMemberReportList = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }


        private async Task Reset()
        {
            //_member = new GetAllMembersResponse();
            //await GetMembersAsync();
        }

        private bool Search(GetAllMembersReportResponse member)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (member.MemberName?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
        private async Task ExportToExcel()
        {
            var response = await ReportManager.ExportAllToExcelAsync(_searchString);
            if (response.Succeeded)
            {
                await _jsRuntime.InvokeVoidAsync("Download", new
                {
                    ByteArray = response.Data,
                    FileName = $"AllMembersReport_{DateTime.Now:ddMMyyyyHHmmss}.xlsx",
                    MimeType = ApplicationConstants.MimeTypes.OpenXml
                });
                _snackBar.Add(string.IsNullOrWhiteSpace(_searchString)
                    ? _localizer["All Members Report exported"]
                    : _localizer["Filtered All Members Report exported"], Severity.Success);
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }
    }
}
