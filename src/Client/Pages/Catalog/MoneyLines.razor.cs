using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
using FlexMoney.Client.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MemberLine;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Transaction;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MudBlazor;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class MoneyLines
    {
        [Inject] private IMoneyLineManager MoneyLineManager { get; set; }
        [Inject] private IMemberLineManager MemberLineManager { get; set; }
        [Inject] private ITransactionManager TransactionManager { get; set; }

        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private GetAllTransactionsResponse _transaction = new();
        private List<GetAllTransactionsResponse> _transactionList = new();

        private List<GetAllMoneyLinesResponse> _moneyLineList = new();
        private GetAllMoneyLinesResponse _moneyLine = new();

        private GetMemberLineByIdResponse _memberLine = new();
        private List<GetMemberLineByIdResponse> _memberLineList = new();

        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canCreateMoneyLines;
        private bool _canEditMoneyLines;
        private bool _canDeleteMoneyLines;
        //private bool _canExportMoneyLines;
        private bool _canSearchMoneyLines;
        private bool _loaded;
        private List<string> data;
        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            _canCreateMoneyLines = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.MoneyLines.Create)).Succeeded;
            _canEditMoneyLines = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.MoneyLines.Edit)).Succeeded;
            _canDeleteMoneyLines = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.MoneyLines.Delete)).Succeeded;
            //_canExportBrands = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Brands.Export)).Succeeded;
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
            if (await SearchMoneyLineInTransaction(id) == true)
            {
                string deleteContent = _localizer["Can not Delete"];
                var parameters = new DialogParameters
                {
                    {nameof(Shared.Dialogs.CanNotDeleteComfirmation.ContentText), string.Format(deleteContent, id)}
                };
                var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
                var dialog = _dialogService.Show<Shared.Dialogs.CanNotDeleteComfirmation>(_localizer["Delete"], parameters, options);
                var result = await dialog.Result;
            }
            else
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
        }
        private async Task InvokeModal(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _moneyLine = _moneyLineList.FirstOrDefault(c => c.Id == id);
                if (_moneyLine != null)
                {
                    parameters.Add(nameof(AddEditMoneyLineModal.AddEditMoneyLineModel), new AddEditMoneyLineCommand
                    {
                        Id = _moneyLine.Id,
                        Name = _moneyLine.Name,
                        CreatedDate = DateTime.Now,
                        Money = _moneyLine.Money,
                        OwnerId = _moneyLine.Owner,
                        Quantity = _moneyLine.Quantity,
                        TypeId = _moneyLine.TypeId,
                    });
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddEditMoneyLineModal>(id == 0 ? _localizer["Create"] : _localizer["Edit"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                await Reset();
            }
        }

        private async Task Reset()
        {
            _moneyLine = new GetAllMoneyLinesResponse();
            await GetMoneyLinesAsync();
        }

        private bool Search(GetAllMoneyLinesResponse MoneyLine)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (MoneyLine.Name?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
        private async Task GetTransactionsAsync()
        {
            var response = await TransactionManager.GetAllAsync();
            if (response.Succeeded)
            {
                _transactionList = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }
        private async Task<bool> SearchMoneyLineInTransaction(int moneyLineId)
        {
            await GetTransactionsAsync();
            _transaction = _transactionList.FirstOrDefault(c => c.LineId == moneyLineId);
            if (_transaction == null)
            {
                return false;
            }
            return true;
        }
    }   

}