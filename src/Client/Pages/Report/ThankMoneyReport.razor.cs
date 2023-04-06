using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FlexMoney.Application.Features.Members.Queries.GetAll;
using FlexMoney.Application.Features.Reports.Queries.GetById;
using FlexMoney.Client.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Member;
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
    public partial class ThankMoneyReport
    {
        [Inject] private IReportManager ReportManager { get; set; }
        [Inject] private IMemberManager MemberManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private List<GetByOwnerIdReportResponse> _singleMemberReportList = new();
        private GetByOwnerIdReportResponse _singleMemberReport = new();
        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canExportThankMoney;
        private bool _canSearchMembers;
        private bool _loaded;
        private List<string> data;
        private List<GetAllMembersResponse> _allMember = new();
        private GetAllMembersResponse _selectedMember = new();
        private GetByOwnerIdReportQuery _query = new();
        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            //_canCreateMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Create)).Succeeded;
            //_canEditMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Edit)).Succeeded;
            //_canDeleteMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Delete)).Succeeded;
            _canExportThankMoney = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Reports.Export)).Succeeded;
            _canSearchMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Search)).Succeeded;

            await GetMembersAsync();

            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task GetMembersAsync()
        {
            var response = await MemberManager.GetAllAsync();
            if (response.Succeeded)
            {
                _allMember = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }
        private async Task GetReportByOwnerIdAsync(GetByOwnerIdReportQuery query)
        {
            var response = await ReportManager.GetReportByOwnerIdAsync(query);
            if (response.Succeeded)
            {
                _singleMemberReportList = response.Data.ToList();
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

        private bool Search(GetByOwnerIdReportResponse owner)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (owner.LineName?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
        private async Task HandleMemberChange(GetAllMembersResponse selectedMember)
        {
            _query.OwnerId = selectedMember.Id;
            await GetReportByOwnerIdAsync(_query);
        }
        private async Task ExportToExcel()
        {
            var response = await ReportManager.ExportThankMoneyToExcelAsync(_query.OwnerId);
            if (response.Succeeded)
            {
                await _jsRuntime.InvokeVoidAsync("Download", new
                {
                    ByteArray = response.Data,
                    FileName = $"ThankMoneyReport_{DateTime.Now:ddMMyyyyHHmmss}.xlsx",
                    MimeType = ApplicationConstants.MimeTypes.OpenXml
                });
                _snackBar.Add(string.IsNullOrWhiteSpace(_searchString)
                    ? _localizer["Thank Money Report exported"]
                    : _localizer["Filtered Thank Money Report exported"], Severity.Success);
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
