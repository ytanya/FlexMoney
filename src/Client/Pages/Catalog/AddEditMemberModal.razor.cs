﻿using FlexMoney.Client.Extensions;
using FlexMoney.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Member;
using FlexMoney.Application.Features.Members.Commands.AddEdit;

using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Client.Infrastructure.Managers.Catalog.Member;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class AddEditMemberModal
    {
        [Inject] private IMemberManager MemberManager { get; set; }

        [Parameter] public AddEditMemberCommand AddEditMemberModel { get; set; } = new();
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        public void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task SaveAsync()
        {
            var response = await MemberManager.SaveAsync(AddEditMemberModel);
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
    }
}