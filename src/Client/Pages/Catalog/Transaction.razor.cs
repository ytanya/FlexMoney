using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using FlexMoney.Application.Features.MoneyLines.Queries.GetById;
using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
using FlexMoney.Client.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Transaction;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class Transactions
    {
        [Inject] private ITransactionManager TransactionManager { get; set; }
        [Inject] private IMoneyLineManager MoneyLineManager { get; set; }

        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private List<GetAllTransactionsResponse> _transactionList = new();
        private GetAllTransactionsResponse _transaction = new();
        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canCreateTransactions;
        private bool _canEditTransactions;
        private bool _canDeleteTransactions;
        //private bool _canExportTransactions;
        private bool _canSearchTransactions;
        private bool _loaded;
        private List<string> data;
        private GetMoneyLineByIdQuery lineQuery = new();
        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            _canCreateTransactions = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Transactions.Create)).Succeeded;
            _canEditTransactions = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Transactions.Edit)).Succeeded;
            _canDeleteTransactions = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Transactions.Delete)).Succeeded;
            //_canExportBrands = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Brands.Export)).Succeeded;
            _canSearchTransactions = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Transactions.Search)).Succeeded;

            await GetTransactionsAsync();
            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
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
                var response = await TransactionManager.DeleteAsync(id);
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
                _transaction = _transactionList.FirstOrDefault(c => c.Id == id);
                lineQuery.Id = _transaction.LineId;
                var response = await MoneyLineManager.GetByIdAsync(lineQuery);
                if (_transaction != null)
                {
                    parameters.Add(nameof(AddEditTransactionModal.AddEditTransactionModel), new AddEditTransactionCommand
                    {
                        Id = _transaction.Id,
                        Earn = _transaction.Earn,
                        Call = _transaction.Call,
                        CallerId = _transaction.CallerId,
                        RealEarn = _transaction.RealEarn,
                        TypeId = _transaction.TypeId,
                        TypeName = _transaction.TypeName,
                        LineName = _transaction.LineName,
                        LineId = _transaction.LineId,
                        ThankMoney = _transaction.ThankMoney,
                        Section =_transaction.Section,
                        Quantity = response.Data.Quantity,
                        Money = response.Data.Money,
                        Caller = _transaction.Caller,
                        Position = _transaction.Position
                    });
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddEditTransactionModal>(id == 0 ? _localizer["Create"] : _localizer["Edit"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                await Reset();
            }
        }

        private async Task Reset()
        {
            _transaction = new GetAllTransactionsResponse();
            await GetTransactionsAsync();
        }

        private bool Search(GetAllTransactionsResponse Transaction)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (Transaction.LineName?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
    }
}
