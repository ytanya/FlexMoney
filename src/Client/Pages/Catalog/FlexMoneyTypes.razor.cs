using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using FlexMoney.Client.Extensions;
using FlexMoney.Application.Features.FlexMoneyTypes.Queries.GettAll;
using MudBlazor.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.FlexMoneyType;
using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Shared.Constants.Application;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class FlexMoneyTypes
    {
        [Inject] private IFlexMoneyTypesManager FlexMoneyTypesManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private List<GetAllFlexMoneyResponse> _flexmoneylist = new();
        private GetAllFlexMoneyResponse _flexmoney = new();
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
            _canCreateMemberships = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Types.Create)).Succeeded;
            _canEditMemberships = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Types.Edit)).Succeeded;
            _canDeleteMemberships = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Types.Delete)).Succeeded;
            //_canExportBrands = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Brands.Export)).Succeeded;
            _canSearchMemberships = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Types.Search)).Succeeded;

            await GetFlexMoneyTypeAsync();
            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task GetFlexMoneyTypeAsync()
        {
            var response = await FlexMoneyTypesManager.GetAllAsync();
            if (response.Succeeded)
            {
                _flexmoneylist = response.Data.ToList();
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
                var response = await FlexMoneyTypesManager.DeleteAsync(id);
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
                _flexmoney = _flexmoneylist.FirstOrDefault(c => c.Id == id);
                if (_flexmoney != null)
                {
                    parameters.Add(nameof(AddFlexMoneyTypesModal.AddFlexMonryTypeModel), new AddEditMemberCommand
                    {
                        Id = _flexmoney.Id,
                        Name = _flexmoney.Name,
                        Note = _flexmoney.Note
                    });
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddFlexMoneyTypesModal>(id == 0 ? _localizer["Create"] : _localizer["Edit"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                await Reset();
            }
        }

        private async Task Reset()
        {
            _flexmoney = new GetAllFlexMoneyResponse();
            await GetFlexMoneyTypeAsync();
        }

        private bool Search(GetAllFlexMoneyResponse flexmoneytype)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (flexmoneytype.Name?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
    }
}
