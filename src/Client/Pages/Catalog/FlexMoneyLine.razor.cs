
using FlexMoney.Client.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Collections.Generic;
using System.Security.Claims;
using System;
using System.Threading.Tasks;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Application.Features.Brands.Commands.AddEdit;
using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Brand;
using Microsoft.JSInterop;
using FlexMoney.Application.Features.FlexMoneyTypes.Commands.AddFlexMoneyType;

namespace FlexMoney.Client.Pages.Catalog
{

    public partial class FlexMoneyLine
    {
        [Inject] private IMoneyLineManager MoneyLineManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private List<GetAllMoneyLinesResponse> _moneyLineList = new();
        private GetAllMoneyLinesResponse _moneyLine = new();
        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canCreateMoneyLines;
        private bool _canEditMoneyLines;
        private bool _canDeleteMoneyLines;
        private bool _canExportMoneyLines;
        private bool _canSearchMoneyLines;
        private bool _loaded;

        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            _canCreateMoneyLines = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.MoneyLines.Create)).Succeeded;
            _canEditMoneyLines = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.MoneyLines.Edit)).Succeeded;
            _canDeleteMoneyLines = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.MoneyLines.Delete)).Succeeded;
            _canExportMoneyLines = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.MoneyLines.Export)).Succeeded;
            _canSearchMoneyLines = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.MoneyLines.Search)).Succeeded;

            await GetMoneyLinesAsync();
            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task GetMoneyLinesAsync()
        {
            var response = await MoneyLineManager.GetAllAsync();
            if (response.Succeeded)
            {
                _moneyLineList = response.Data.ToList();
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
                var response = await MoneyLineManager.DeleteAsync(id);
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

        private async Task ExportToExcel()
        {
            var response = await MoneyLineManager.ExportToExcelAsync(_searchString);
            if (response.Succeeded)
            {
                await _jsRuntime.InvokeVoidAsync("Download", new
                {
                    ByteArray = response.Data,
                    FileName = $"{nameof(Brands).ToLower()}_{DateTime.Now:ddMMyyyyHHmmss}.xlsx",
                    MimeType = ApplicationConstants.MimeTypes.OpenXml
                });
                _snackBar.Add(string.IsNullOrWhiteSpace(_searchString)
                    ? _localizer["Brands exported"]
                    : _localizer["Filtered Brands exported"], Severity.Success);
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
            _moneyLine = new GetAllMoneyLinesResponse();
            await GetMoneyLinesAsync();
        }

        private bool Search(GetAllMoneyLinesResponse moneyline)
        {
            return true;
        }



        private async Task InvokeModal(int id = 0)
        {

            var parameters = new DialogParameters();
            if (id != 0)
            {
                _moneyLine = _moneyLineList.FirstOrDefault(c => c.Id == id);
                if (_moneyLine != null)
                {
                    parameters.Add(nameof(AddFlexMoneyLinesModel.AddMoneyLineModel), new AddEditMoneyLineCommand
                    {
                        Id = _moneyLine.Id,
                        Name = _moneyLine.Name,

                    });
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Large, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddFlexMoneyLinesModel>(id == 0 ? _localizer["Create"] : _localizer["Edit"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                await Reset();
            }

        }
    }


}
