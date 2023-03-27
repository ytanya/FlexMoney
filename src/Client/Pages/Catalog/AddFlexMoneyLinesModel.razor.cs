using Blazored.FluentValidation;

using FlexMoney.Application.Features.Members.Queries.GetAll;
using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Application.Features.Types.Queries.GettAll;
using FlexMoney.Client.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.FlexMoneyType;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Member;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Type;
using FlexMoney.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class AddFlexMoneyLinesModel
    {
        [Inject] private ITypeManager TypeManager { get; set; }
        [Inject] private IMemberManager MemberManager { get; set; } 
        [Inject] private IMoneyLineManager MoneyLineManager { get; set; }

        [Parameter] public AddEditMoneyLineCommand AddMoneyLineModel { get; set; } = new();
        private List<GetAllMoneyLinesResponse> _moneyLineList { get; set; }
        private List<GetAllMoneyLinesResponse> _flexMoneyLineslistAdd { get; set; }
        private GetAllMoneyLinesResponse _flexMoneyLineSelected { get; set; }
        private GetAllMembersResponse _memberSelected { get; set; }
        private List<GetAllMembersResponse> _memberList { get; set; } = new();
        private List<GetAllMembersResponse> _memberListToAdd { get; set; } = new();
        private GetAllTypesResponse _type { get; set; }
        private List<GetAllTypesResponse> _typeList { get; set; } = new();
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
         
        DateTime? date = DateTime.Today;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });


        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            await GetMembersAsync();
            await GetTypesAsync();
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }

        }

        public void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task SaveAsync()
        {
            var response = await MoneyLineManager.SaveAsync(AddMoneyLineModel);
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
        private async Task GetMembersAsync()
        {
            var response = await MemberManager.GetAllAsync();
            if (response.Succeeded)
            {
                _memberList = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }
        private async Task GetTypesAsync()
        {
            var response = await TypeManager.GetAllAsync();
            if (response.Succeeded)
            {
                _typeList = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private async Task LoadDataAsync()
        {
            await Task.CompletedTask;
        }

        private async Task InvokeModalMember(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _memberSelected = _memberList.Find(c => c.Id == id);
            }
        }

        private async Task InvokeModalMoneyTypes(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _flexMoneyLineSelected = _moneyLineList.Find(c => c.Id == id);
            }
        }
        private void AddMemberToList()
        {
            if (_memberSelected != null)
            {
                _memberListToAdd.Add(_memberSelected);
            }
        }
        private void DeleMemberInList()
        {
            if (_memberSelected != null)
            {
                _memberListToAdd.Remove(_memberSelected);
            }
        }
        private void AddAllLine()
        {
            foreach (var member in _memberList)
            {
                _memberListToAdd.Add(member);
            }
        }
        private void DeleteAllLine()
        {
            _memberListToAdd.Clear();
        }
    }
}
