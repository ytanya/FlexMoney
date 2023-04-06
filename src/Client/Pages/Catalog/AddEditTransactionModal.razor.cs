using Blazored.FluentValidation;
using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Client.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MemberLine;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Transaction;
using FlexMoney.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

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
        private GetTransactionInfoByLineIdQuery _lineQuery =new();
        private GetReadyCallerByLineIdResponse _selectCaller =new();
        private GetTransactionInfoByLineIdResponse _transactionByLineId = new();
        private List<GetReadyCallerByLineIdResponse> _readyCallerList = new();
        private GetReadyCallerByLineIdQuery _readyCaller = new();
        private int _moneyLineCount = 0;
        private Decimal _thankMoneyTotal = 0;
        private Decimal _money = 0;
        private int _quantity = 0;
        private string _typeName;
        private int _section = 0;
        private Decimal _earn = 0;
        private Decimal _thankmoney =0;
        private Decimal _realearn = 0;
        private Decimal _call = 0; 
        private int _currentSection = 0;
        private FluentValidationValidator _fluentValidationValidator;
        private HashSet<GetAllMoneyLinesResponse> _selectedLines = new HashSet<GetAllMoneyLinesResponse>();
        private HashSet<GetReadyCallerByLineIdResponse> _selectedCallers = new HashSet<GetReadyCallerByLineIdResponse>();
        private GetReadyCallerByLineIdResponse _selectedCaller = new GetReadyCallerByLineIdResponse();
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
                if(_moneyLineList != null)
                {
                    _selectedLine = _moneyLineList.Where(x => x.Id == AddEditTransactionModel.LineId).FirstOrDefault();
                    
                    if (_selectedLine != null) _selectedLines.Add(_selectedLine); 
                    else _selectedLines.Add(_moneyLineList.FirstOrDefault());
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

        private async Task GetTransactionByLineId(GetTransactionInfoByLineIdQuery lineQuery)
        {
            var response = await TransactionManager.GetTransactionInfoByLineIdAsync(lineQuery);
            if (response.Succeeded)
            {
                _transactionByLineId = response.Data;
                if (response.Data != null)
                {
                    if(AddEditTransactionModel.Id != 0)
                    {
                        _section = response.Data.CurrentSection;
                    }
                    else
                    {
                        _section = response.Data.CurrentSection + 1;
                    }
                    _thankMoneyTotal = response.Data.TotalThankMoney;
                    _money = response.Data.Money;
                }
                else
                {
                    _section = 1;
                }

                _readyCaller.LineId = lineQuery.LineId;
                await GetReadyCallerByLineId(_readyCaller);
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }

        }

        private async Task GetReadyCallerByLineId(GetReadyCallerByLineIdQuery query)
        {
            _selectedCallers = new();
            var response = await TransactionManager.GetReadyCallerByLineIdAsync(query);
            if (response.Succeeded)
            {
                foreach (var item in response.Data)
                {
                    int isDead = item.IsDead;
                }
                _readyCallerList = response.Data.Where(x=>x.IsDead == 0).ToList();
                _selectedCaller = response.Data.Where(x => x.Id == AddEditTransactionModel.CallerId && x.Position == AddEditTransactionModel.Position && x.IsDead == 1).FirstOrDefault();
                
                if(_selectedCaller != null)
                {
                    _selectedCallers.Add(_selectedCaller);
                    _readyCallerList.Add(_selectedCaller);
                }
                else
                {
                    _selectedCaller = _readyCallerList.FirstOrDefault();
                    _selectedCallers.Add(_selectedCaller);
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
            if(_transactionByLineId==null || AddEditTransactionModel.LineId != _selectedLine.Id)
            {
                AddEditTransactionModel.Section = _selectedLine.CurrentSection + 1;
                AddEditTransactionModel.LineId = _selectedLine.Id;
                AddEditTransactionModel.TypeId = _selectedLine.TypeId;
                AddEditTransactionModel.CreatedDate = DateTime.Now;
                AddEditTransactionModel.CallerId = _selectCaller.Id;
                AddEditTransactionModel.Position = _selectCaller.Position;
                AddEditTransactionModel.Earn = _earn;
                AddEditTransactionModel.RealEarn = _realearn;
                AddEditTransactionModel.Dead = _money * (_selectedLine.Quantity - AddEditTransactionModel.Section);
                AddEditTransactionModel.ThankMoney = _thankmoney;
                AddEditTransactionModel.Call = _call;
                AddEditTransactionModel.Quantity = _quantity;
                _currentSection = _selectedLine.CurrentSection + 1;
            }
            else
            {
                _currentSection = _selectedLine.CurrentSection;
                AddEditTransactionModel.Section = _currentSection;
                AddEditTransactionModel.LineId = _selectedLine.Id;
                AddEditTransactionModel.TypeId = _selectedLine.TypeId;
                AddEditTransactionModel.CallerId = _selectCaller.Id;
                AddEditTransactionModel.Position = _selectCaller.Position;
                AddEditTransactionModel.Earn = _earn;
                AddEditTransactionModel.RealEarn = _realearn;
                AddEditTransactionModel.Dead = _money * (_selectedLine.Quantity - _currentSection);
                AddEditTransactionModel.ThankMoney = _thankmoney;
                AddEditTransactionModel.Call = _call;
                AddEditTransactionModel.Quantity = _quantity;
            }
            
            var response = await TransactionManager.SaveAsync(AddEditTransactionModel);
            if (response.Succeeded)
            {
                AddEditMoneyLineCommand AddEditMoneyLineModel = new AddEditMoneyLineCommand
                {
                    CreatedDate = _selectedLine.CreatedDate,
                    Id = _selectedLine.Id,
                    Money = _selectedLine.Money,
                    Name = _selectedLine.Name,
                    OwnerId = _selectedLine.OwnerId,
                    Quantity = _selectedLine.Quantity,
                    StatusId = _selectedLine.StatusId,
                    TypeId = _selectedLine.TypeId,
                    CurrentSection = _currentSection
                };
                var responseMoneyLine = await MoneyLineManager.SaveAsync(AddEditMoneyLineModel);
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

        private void HandleCallerChange(GetReadyCallerByLineIdResponse selectedCaller)
        {
            _selectCaller = selectedCaller;
        }

        private async Task HandleLineChange(GetAllMoneyLinesResponse selectedLine)
        {
            _selectedLine = selectedLine;
            _lineQuery.LineId = selectedLine.Id;
            _money = selectedLine.Money;
            _quantity=selectedLine.Quantity;
            _typeName = selectedLine.TypeName;
            await GetTransactionByLineId(_lineQuery);           
        }
        protected void OnValueCallChangeHandler(string newValue)
        {
            decimal result = 0;

            // Remove any non-numeric characters from the input value
            string cleanedValue = new string(newValue.Where(c => char.IsDigit(c) || c == '.' || c == '-').ToArray());
            bool isDecimal = decimal.TryParse(cleanedValue, out result);
             if(isDecimal)
            {
                _call = result;
                _earn = (_money - _call) * (_quantity - 1);
                _realearn = _earn;
            }
            
        }
        private void OnValueThankMoneyChangeHandler(string newValue)
        {
            decimal result = 0;
            // Remove any non-numeric characters from the input value
            string cleanedValue = new string(newValue.Where(c => char.IsDigit(c) || c == '.' || c == '-').ToArray());

            bool isDecimal = decimal.TryParse(cleanedValue, out result);
            if (isDecimal)
            {
                _thankmoney = result;
                _realearn = _earn - _thankmoney;
            }
        }
    }
}