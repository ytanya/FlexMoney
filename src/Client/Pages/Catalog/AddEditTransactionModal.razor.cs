using FlexMoney.Client.Extensions;
using FlexMoney.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Transaction;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using System.Collections.Generic;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using System.Linq;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
using System.Diagnostics;
using System;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MemberLine;
using Microsoft.AspNetCore.Components.Web;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class AddEditTransactionModal
    {
        [Inject] private ITransactionManager TransactionManager { get; set; }
        [Inject] private IMoneyLineManager MoneyLineManager { get; set; }
        [Inject] private IMemberLineManager MemberLineManager { get; set; }

        [Parameter] public AddEditTransactionCommand AddEditTransactionModel { get; set; } = new();
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }
        private List<GetAllMoneyLinesResponse> _moneyLineList = new();
        private GetAllMoneyLinesResponse _selectedLine = new();
        private GetTransactionByLineIdQuery _lineQuery =new();
        private GetMemberLineByLineIdResponse _selectCaller =new();
        private List<GetTransactionByLineIdResponse> _transactionByLineIdList = new();
        private List<GetMemberLineByLineIdResponse> _readyCallerList = new();
        private int _moneyLineCount = 0;
        private Decimal _thankMoneyTotal = 0;
        private Decimal _money = 0;
        private int _quantity = 0;
        private int _section = 0;
        private Decimal _earn = 0;
        private Decimal _thankmoney =0;
        private Decimal _realearn = 0;
        private Decimal _call = 0;
        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        public void Cancel()
        {
            MudDialog.Cancel();
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

        private async Task GetTransactionByLineId(GetTransactionByLineIdQuery lineQuery)
        {
            var response = await TransactionManager.GetByLineIdAsync(lineQuery);
            if (response.Succeeded)
            {
                _section = response.Data != null ? response.Data.Count() : 0;
                _section = _section + 1;
                _thankMoneyTotal = response.Data?.Select(x => x.ThankMoney)?.Sum() ?? 0;
                _transactionByLineIdList = response.Data;
                GetMemberLineByLineIdQuery memberLineQuery = new GetMemberLineByLineIdQuery();
                memberLineQuery.LineId = lineQuery.LineId;
                await GetMemberLineByLineId(memberLineQuery);
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }

        }

        private async Task GetMemberLineByLineId(GetMemberLineByLineIdQuery memberLineQuery)
        {
            var response = await MemberLineManager.GetByLineIdAsync(memberLineQuery);
            if (response.Succeeded)
            {
                List<GetMemberLineByLineIdResponse> _memberLineList = response.Data.ToList();
                _readyCallerList = _memberLineList.Where(m => !_transactionByLineIdList.Any(t => t.LineId == m.LineId && t.CallerId == m.MemberId && t.Position == m.Position)).ToList();
                foreach (var item in _readyCallerList)
                {
                    string memberName = item.MemberName;
                }
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private async Task SaveAsync()
        {
            if(AddEditTransactionModel.Id == 0)
            {
                AddEditTransactionModel.Section = _section;
                AddEditTransactionModel.LineId = _selectedLine.Id;
                AddEditTransactionModel.TypeId = _selectedLine.TypeId;
                AddEditTransactionModel.CreatedDate = DateTime.Now;
                AddEditTransactionModel.CallerId = _selectCaller.MemberId;
                AddEditTransactionModel.Position = _selectCaller.Position;
                AddEditTransactionModel.Earn = _earn;
                AddEditTransactionModel.RealEarn = _realearn;
                AddEditTransactionModel.Dead = _money * (_selectedLine.Quantity - _section);
                AddEditTransactionModel.ThankMoney = _thankmoney;
                AddEditTransactionModel.Call = _call;
                AddEditTransactionModel.Quantity = _quantity;
            }
            else
            {
                AddEditTransactionModel.CreatedDate = DateTime.Now;
            }
            //AddEditTransactionCommand AddEditTransactionModel = new AddEditTransactionCommand
            //{
            //    
            //};
            var response = await TransactionManager.SaveAsync(AddEditTransactionModel);
            if (response.Succeeded)
            {
                _snackBar.Add(response.Messages[0], Severity.Success);
                MudDialog.Close();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
            await HubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
        }

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            await GetMoneyLinesAsync();
            
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task LoadDataAsync()
        {
            await Task.CompletedTask;
        }

        private void HandleCallerChange(GetMemberLineByLineIdResponse selectedCaller)
        {
            _selectCaller = selectedCaller;
        }

        private async Task HandleLineChange(GetAllMoneyLinesResponse selectedLine)
        {
            _selectedLine = selectedLine;
            _lineQuery.LineId = selectedLine.Id;
            _money = selectedLine.Money;
            _quantity=selectedLine.Quantity;
            await GetTransactionByLineId(_lineQuery);
            // Do other stuff
        }
        protected void OnValueCallChangeHandler(string newValue)
        {
            _call = decimal.Parse(newValue);
            _earn = (_money - _call) * (_quantity - 1);
            _realearn = _earn;
        }
        private void OnValueThankMoneyChangeHandler(string newValue)
        {
            _thankmoney = decimal.Parse(newValue);
            _realearn = _earn - _thankmoney;

        }
        private void UpdateRealEarn()
        {
            
        }
    }
}