using FlexMoney.Client.Extensions;
using FlexMoney.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using System.Globalization;
using MudBlazor;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Type;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Member;
using FlexMoney.Application.Features.Members.Queries.GetAll;
using System.Collections.Generic;
using FlexMoney.Application.Features.Types.Queries.GetAll;
using System;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MemberLine;
using FlexMoney.Application.Features.MemberLines.Commands.AddEdit;
using FlexMoney.Shared.Wrapper;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using System.Linq;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class AddEditMoneyLineModal
    {
        [Inject] private IMoneyLineManager MoneyLineManager { get; set; }
        [Inject] private ITypeManager MoneyTypeManager { get; set; }
        [Inject] private IMemberManager MemberManager { get; set; }
        [Inject] private IMemberLineManager MemberLineManager { get; set; }

        [Parameter] public AddEditMoneyLineCommand AddEditMoneyLineModel { get; set; } = new();
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        private List<GetAllMembersResponse> _allMember = new();
        private List<GetAllTypesResponse> _moneyTypeList = new();
        private List<GetAllMembersResponse> _allSelectedMember = new();
        private GetAllMembersResponse _selectedMember = new();
        private GetAllTypesResponse _selectedType = new();
        private GetAllMembersResponse _selectedOwner = new();
        private GetMemberLineByLineIdQuery _memberLine = new();
        public void Cancel()
        {
            MudDialog.Cancel();
        }


        public void AddFlexmoneyLineCart()
        {
            if (_allMember != null)
            {
                _allSelectedMember.Add(_selectedMember);
            }

        }

        public void DeleMemberInList()
        {
            if (_selectedMember != null)
            {
                _allSelectedMember.Remove(_selectedMember);
            }
        }


        public void DeleteAllMember()
        {
            _allSelectedMember.Clear();
        }

        public void AddAllMember()
        {
            foreach (var item in _allMember)
            {
                _allSelectedMember.Add(item);
            }
        }
        private async Task InvokeModal(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _selectedMember = _allMember.Find(c => c.Id == id);
            }


        }
        private async Task InvokeModal1(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _selectedMember = _allSelectedMember.Find(c => c.Id == id);
            }
        }

        private async Task GetMoneyTypesAsync()
        {
            var response = await MoneyTypeManager.GetAllAsync();
            if (response.Succeeded)
            {
                _moneyTypeList = response.Data;
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private async Task GetAllMemberAsync()
        {
            var response = await MemberManager.GetAllAsync();
            if (response.Succeeded)
            {
                _allMember = response.Data;
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
            if (AddEditMoneyLineModel.Id == 0)
            {
                AddEditMoneyLineModel.CreatedDate = DateTime.Now;
                AddEditMoneyLineModel.TypeId = _selectedType.Id;
                AddEditMoneyLineModel.OwnerId = _selectedOwner.Id;
                AddEditMoneyLineModel.StatusId = 1; //New
            }
            var responseAddEditMoneyLine = await MoneyLineManager.SaveAsync(AddEditMoneyLineModel);
            if (responseAddEditMoneyLine.Succeeded)
            {
                var lineId = responseAddEditMoneyLine.Data;
                AddEditMemberLineCommand request = new AddEditMemberLineCommand();
                foreach (var item in _allSelectedMember)
                {
                    request.MemberId = item.Id;
                    request.LineId = lineId;

                    _memberLine.LineId = request.LineId;
                    var allMemberByLineId = await MemberLineManager.GetByLineIdAsync(_memberLine);
                    var data = allMemberByLineId.Data;
                    bool existingMember = data.Any(m => m.MemberId == request.MemberId && m.LineId == request.LineId);

                    if (existingMember)
                    {
                        var currentPosition = data.OrderByDescending(m => m.Position).Select(m => m.Position).FirstOrDefault();
                        request.Position = currentPosition + 1;
                    }
                    else
                    {
                        request.Position = 1;
                    }
                    var responseAddEditMemberLine = await MemberLineManager.SaveAsync(request);
                }
                _snackBar.Add(responseAddEditMoneyLine.Messages[0], Severity.Success);
                MudDialog.Close();
               
            }
            else
            {
                foreach (var message in responseAddEditMoneyLine.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
            await HubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
        }

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            await GetMoneyTypesAsync();
            await GetAllMemberAsync();

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

        private void HandleTypeChange(GetAllTypesResponse selectedType)
        {
            _selectedType = selectedType;
        }

        private void HandleMemberChange(GetAllMembersResponse selectedMember)
        {
            _selectedOwner = selectedMember;
        }

    }
}