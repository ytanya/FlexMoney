using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using FlexMoney.Application.Features.MemberLines.Queries.GetAll;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Application.Features.Members.Queries.GetAll;
using FlexMoney.Client.Extensions;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Member;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MemberLine;
using FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine;
using FlexMoney.Client.Shared.Dialogs;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class Members
    {
        [Inject] private IMemberManager MemberManager { get; set; }
        [Inject] private IMemberLineManager MemberLineManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }

        private AddEditMemberCommand _addEditMemberModel { get; set; }
        private List<GetAllMembersResponse> _memberList = new();
        private GetAllMembersResponse _member = new();
        private GetAllMemberLinesResponse _memberLineResponse = new();
        private List<GetAllMemberLinesResponse> _memberLineResponseList = new();
        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canCreateMembers;
        private bool _canEditMembers;
        private bool _canDeleteMembers;
        //private bool _canExportMembers;
        private bool _canSearchMembers;
        private bool _loaded;
        private List<string> data;
        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            _canCreateMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Create)).Succeeded;
            _canEditMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Edit)).Succeeded;
            _canDeleteMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Delete)).Succeeded;
            //_canExportBrands = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Brands.Export)).Succeeded;
            _canSearchMembers = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Members.Search)).Succeeded;

            await GetMembersAsync();
            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
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

        private async Task Delete(int id)
        {
            if (SearchMemberIdInLineId(id) == true)
            {
                string deleteContent = _localizer["This member has a MoneyLine"];
                var parameters = new DialogParameters
                {
                    {nameof(Shared.Dialogs.CanNotDeleteComfirmation.ContentText), string.Format(deleteContent, id)}
                };
                var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
                var dialog = _dialogService.Show<Shared.Dialogs.CanNotDeleteComfirmation>(_localizer["Can not Delete"], parameters, options);
                var result = await dialog.Result;

            }
            else
            {
                string deleteContent = _localizer["Delete Member"];
                var parameters = new DialogParameters();
                if (id != 0)
                {
                    _member = _memberList.FirstOrDefault(c => c.Id == id);
                    if (_member != null)
                    {
                        parameters.Add(nameof(IsDeletedConfirmation.AddEditMemberModel), new AddEditMemberCommand
                        {
                            Id = _member.Id,
                            Name = _member.Name,
                            AccountNumber = _member.AccountNumber,
                            Note = _member.Note,
                            IsDeleted = true,
                        });
                    }
                }
                var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
                var dialog = _dialogService.Show<IsDeletedConfirmation>(id == 0 ? _localizer["Delete"] : _localizer["Delete"], parameters, options);
                var result = await dialog.Result;
                if (!result.Cancelled)
                {
                    await Reset();
                }
            }
        }

        private async Task InvokeModal(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _member = _memberList.FirstOrDefault(c => c.Id == id);
                if (_member != null)
                {
                    parameters.Add(nameof(AddEditMemberModal.AddEditMemberModel), new AddEditMemberCommand
                    {
                        Id = _member.Id,
                        Name = _member.Name,
                        AccountNumber = _member.AccountNumber,
                        Note = _member.Note
                    });
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddEditMemberModal>(id == 0 ? _localizer["Create"] : _localizer["Edit"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                await Reset();
            }
        }

        private async Task Reset()
        {
            _member = new GetAllMembersResponse();
            await GetMembersAsync();
        }

        private bool Search(GetAllMembersResponse member)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (member.Name?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
        private async Task GetMemberLinesAsync()
        {
            var response = await MemberLineManager.GetAllAsync();
            if (response.Succeeded)
            {
                _memberLineResponseList = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private bool SearchMemberIdInLineId(int memberId)
        {
            GetMemberLinesAsync();
            _memberLineResponse = _memberLineResponseList.FirstOrDefault(c => c.MemberId == memberId);
            if (_memberLineResponse == null)
            {
                return false;
            }
            return true;
        }
    }
}
