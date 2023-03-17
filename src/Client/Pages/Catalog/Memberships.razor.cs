using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using FlexMoney.Application.Features.Memberships.Commands.AddEdit;
using FlexMoney.Application.Features.Memberships.Queries.GetAll;
using FlexMoney.Client.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Membership;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class Memberships
    {
        [Inject] private IMembershipManager MembershipManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private List<GetAllMembershipsResponse> _membershipList = new();
        private GetAllMembershipsResponse _membership = new();
        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canCreateMemberships;
        private bool _canEditMemberships;
        private bool _canDeleteMemberships;
        //private bool _canExportMemberships;
        private bool _canSearchMemberships;
        private bool _loaded;
        private List<string> data;
        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            _canCreateMemberships = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Memberships.Create)).Succeeded;
            _canEditMemberships = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Memberships.Edit)).Succeeded;
            _canDeleteMemberships = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Memberships.Delete)).Succeeded;
            //_canExportBrands = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Brands.Export)).Succeeded;
            _canSearchMemberships = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Memberships.Search)).Succeeded;

            await GetMembershipsAsync();
            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task GetMembershipsAsync()
        {
            var response = await MembershipManager.GetAllAsync();
            if (response.Succeeded)
            {
                _membershipList = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private async Task Delete(int id)
        {
            string deleteContent = _localizer["Delete Content"];
            var parameters = new DialogParameters
            {
                {nameof(Shared.Dialogs.DeleteConfirmation.ContentText), string.Format(deleteContent, id)}
            };
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<Shared.Dialogs.DeleteConfirmation>(_localizer["Delete"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                var response = await MembershipManager.DeleteAsync(id);
                if (response.Succeeded)
                {
                    await Reset();
                    await HubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
                    _snackBar.Add(response.Messages[0], Severity.Success);
                }
                else
                {
                    await Reset();
                    foreach (var message in response.Messages)
                    {
                        _snackBar.Add(message, Severity.Error);
                    }
                }
            }
        }
        private async Task InvokeModal(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _membership = _membershipList.FirstOrDefault(c => c.Id == id);
                if (_membership != null)
                {
                    parameters.Add(nameof(AddEditMembershipModal.AddEditMembershipModel), new AddEditMembershipCommand
                    {
                        Id = _membership.Id,
                        Name = _membership.Name,
                        AccountNumber = _membership.AccountNumber,
                        Note = _membership.Note
                    });
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddEditMembershipModal>(id == 0 ? _localizer["Create"] : _localizer["Edit"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                await Reset();
            }
        }

        private async Task Reset()
        {
            _membership = new GetAllMembershipsResponse();
            await GetMembershipsAsync();
        }

        private bool Search(GetAllMembershipsResponse membership)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (membership.Name?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
    }
}
