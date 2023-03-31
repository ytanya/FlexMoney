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
using MudBlazor.Extensions;
using FlexMoney.Application.Features.Types.Commands.AddEdit;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Application.Features.Types.Queries.GetAll;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Type;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using AutoMapper;
using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Client.Shared.Dialogs;
using FlexMoney.Application.Features.MemberLines.Commands.AddEdit;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Brand;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class Types
    {
        [Inject] private ITypeManager TypeManager { get; set; }
        [Inject] private IMoneyLineManager MoneyLineManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private List<GetAllTypesResponse> _typelist = new();
        private GetAllTypesResponse _type = new();
        private GetAllMoneyLinesResponse _getAllMoneyLinesResponse { get; set; }
        private List<GetAllMoneyLinesResponse> _getAllMoneyLinesResponseList { get; set; }
        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canCreateTypes;
        private bool _canEditTypes;
        private bool _canDeleteTypes;
        //private bool _canExportMembers;
        private bool _canSearchTypes;
        private bool _loaded;
        private List<string> data;
        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            _canCreateTypes = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Types.Create)).Succeeded;
            _canEditTypes = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Types.Edit)).Succeeded;
            _canDeleteTypes = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Types.Delete)).Succeeded;
            //_canExportBrands = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Brands.Export)).Succeeded;
            _canSearchTypes = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Types.Search)).Succeeded;

            await GetTypesAsync();
            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task GetTypesAsync()
        {
            var response = await TypeManager.GetAllAsync();
            if (response.Succeeded)
            {
                _typelist = response.Data.ToList();
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
            if (await SearchTypeIdInMoneyLines(id) == true)
            {
                string deleteContent = _localizer["This Type in use"];
                var parameters = new DialogParameters
                {
                    {nameof(Shared.Dialogs.IsDeletedConfirmation.ContentText), string.Format(deleteContent, id)}
                };
                var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
                var dialog = _dialogService.Show<Shared.Dialogs.CanNotDeleteComfirmation>(_localizer["Can Not Delete"], parameters, options);
                var result = await dialog.Result;
            }
            else
            {
                string deleteContent = _localizer["Delete Type"];
                var parameters = new DialogParameters
                {
                    { nameof(Shared.Dialogs.DeleteConfirmation.ContentText), string.Format(deleteContent, id)}
                };
                var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
                var dialog = _dialogService.Show<DeleteConfirmation>(_localizer["Delete"], parameters, options);
                var result = await dialog.Result;
                if (!result.Cancelled)
                {
                    var response = await TypeManager.DeleteAsync(id);
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
        }
        private async Task InvokeModal(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _type = _typelist.FirstOrDefault(c => c.Id == id);
                if (_type != null)
                {
                    parameters.Add(nameof(AddEditTypeModal.AddEditTypeModel), new AddEditTypeCommand
                    {
                        Id = _type.Id,
                        Name = _type.Name,
                        Note = _type.Note
                    });
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddEditTypeModal>(id == 0 ? _localizer["Create"] : _localizer["Edit"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                await Reset();
            }
        }

        private async Task Reset()
        {
            _type = new GetAllTypesResponse();
            await GetTypesAsync();
        }

        private bool Search(GetAllTypesResponse type)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (type.Name?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }

        private async Task GetMoneyLinesAsync()
        {
            var response = await MoneyLineManager.GetAllAsync();
            if (response.Succeeded)
            {
                _getAllMoneyLinesResponseList = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private async Task<bool> SearchTypeIdInMoneyLines(int typeId)
        {
            await GetMoneyLinesAsync();
            _getAllMoneyLinesResponse = _getAllMoneyLinesResponseList.FirstOrDefault(e => e.TypeId == typeId);
            if (_getAllMoneyLinesResponse == null)
            {
                return false;
            }
            return true;
        }
    }
}
