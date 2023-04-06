using FlexMoney.Client.Extensions;
using FlexMoney.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
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
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Application.Features.MemberLines.Queries.GetAll;
using Microsoft.AspNetCore.Components.Forms;

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
        private EditContext _editContext;
        private List<GetAllMembersResponse> _allMember = new();
        private List<GetAllTypesResponse> _moneyTypeList = new();
        private List<GetAllMembersResponse> _allSelectedMember = new();
        private List<GetAllMembersResponse> _insertSelectedMember = new();
        private GetAllMembersResponse _selectedMember = new();
        private GetAllTypesResponse _selectedType = new();
        private GetAllMembersResponse _selectedOwner = new();
        private GetMemberLineByLineIdQuery _memberLine = new();
        private int _quantity = 0;
        private HashSet<GetAllTypesResponse> _selectedTypes = new HashSet<GetAllTypesResponse>();
        private HashSet<GetAllMembersResponse> _selectedOwners = new HashSet<GetAllMembersResponse>();
        private HashSet<GetAllMembersResponse> _selectedMembers = new HashSet<GetAllMembersResponse>();
        private List<GetAllMemberLinesResponse> _allLineMember = new();
        private List<GetAllMemberLinesResponse> _moneyLineMember = new();
        private GetAllMembersResponse _defaultMember = new();
        public void Cancel()
        {
            MudDialog.Cancel();
        }


        public void AddFlexmoneyLine()
        {
            if (_selectedMember != null && _selectedMember.Id >0)
            {
                _allSelectedMember.Add(_selectedMember);
                _quantity = _allSelectedMember.Count;
            }

        }

        public void DeleMemberInList()
        {
            if (_selectedMember != null && _selectedMember.Id > 0)
            {
                _allSelectedMember.Remove(_selectedMember);
                _quantity = _allSelectedMember.Count;
            }
        }


        public void DeleteAllMember()
        {
            _allSelectedMember.Clear();
            _quantity = _allSelectedMember.Count;
        }

        public void AddAllMember()
        {
            foreach (var item in _allMember)
            {
                _allSelectedMember.Add(item);
            }
            _quantity = _allSelectedMember.Count;
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
                _moneyTypeList = response.Data.ToList();
                if (_moneyTypeList != null)
                {
                    _selectedType = _moneyTypeList.Where(x => x.Id == AddEditMoneyLineModel.TypeId).FirstOrDefault();
                    if(_selectedType != null ) _selectedTypes.Add(_selectedType);
                    else _selectedTypes.Add(_moneyTypeList.FirstOrDefault());
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

        private async Task GetAllMemberAsync()
        {
            var response = await MemberManager.GetAllAsync();
            if (response.Succeeded)
            {
                _allMember = response.Data.ToList();
                if (_allMember != null)
                {
                    _selectedOwner = _allMember.Where(x => x.Id == AddEditMoneyLineModel.OwnerId).FirstOrDefault();
                    _selectedOwners.Add(_selectedOwner);
                    _defaultMember= _allMember.FirstOrDefault();
                    await InvokeModal(_defaultMember.Id);
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

        private async Task GetAllMemberByLineAsync()
        {
            var response = await MemberLineManager.GetAllAsync();
            if (response.Succeeded)
            {
                _allLineMember = response.Data.ToList();
                if (_allLineMember != null)
                {
                    _moneyLineMember = _allLineMember.Where(x => x.LineId == AddEditMoneyLineModel.Id).ToList(); 
                    foreach (var item in _moneyLineMember)
                    {
                        _selectedMember = _allMember.Where(x => x.Id == item.MemberId).FirstOrDefault();
                        _allSelectedMember.Add(_selectedMember);
                    }
                    _quantity = _allSelectedMember.Count;
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
            if (AddEditMoneyLineModel.Id == 0)
            {
                AddEditMoneyLineModel.CreatedDate = DateTime.Now;
                AddEditMoneyLineModel.TypeId = _selectedType.Id;
                AddEditMoneyLineModel.OwnerId = (_selectedOwner != null) ? _selectedOwner.Id : 0;
                AddEditMoneyLineModel.StatusId = 1; //New
            }

            var responseAddEditMoneyLine = await MoneyLineManager.SaveAsync(AddEditMoneyLineModel);
            if (responseAddEditMoneyLine.Succeeded)
            {
                var lineId = responseAddEditMoneyLine.Data;
                await MemberLineManager.DeleteAsync(lineId);

                AddEditMemberLineCommand request = new AddEditMemberLineCommand();
                foreach (var item in _allSelectedMember)
                {
                    int existingMember = _insertSelectedMember.Where(x => x.Id == item.Id).ToList().Count;
                    _insertSelectedMember.Add(item);
                    request.MemberId = item.Id;
                    request.LineId = lineId;
                    request.Position = existingMember + 1;
                    //request.DeadSection = 0;

                    var responseAddEditMemberLine = await MemberLineManager.SaveAsync(request);
                    _snackBar.Add(responseAddEditMemberLine.Messages[0], Severity.Success);
                    
                }

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
            await GetAllMemberByLineAsync();

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