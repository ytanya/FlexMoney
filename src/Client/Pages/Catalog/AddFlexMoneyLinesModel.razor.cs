using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System;
using System.Collections.Generic;

namespace FlexMoney.Client.Pages.Catalog
{
    public partial class AddFlexMoneyLinesModel
    {
        [Parameter] public FlexMoneyLineReponse AddFlexMoneyLineModel { get; set; } = new();
        public List<FlexMoneyLineReponse> _flexMoneyLineslist = new List<FlexMoneyLineReponse>
        {
            new FlexMoneyLineReponse{Id = 1,Name = "Name" , Note = ""},
            new FlexMoneyLineReponse{Id = 2,Name = "Hoang" , Note = ""},
            new FlexMoneyLineReponse{Id = 3,Name = "Phuc" , Note = ""},
            new FlexMoneyLineReponse{Id = 4,Name = "VY" , Note = ""}
        };
        public List<FlexMoneyLineReponse> _flexMoneyLineslistAdd = new List<FlexMoneyLineReponse>();

        public FlexMoneyLineReponse flexMoneyLineToAdd { get; set; }
        public FlexMoneyLineReponse flexMoneyLineSelect { get; set; }

        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }
        DateTime? date = DateTime.Today;
        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        public void Cancel()
        {
            MudDialog.Cancel();
        }
        public void AddFlexmoneyLineCart()
        {
            if (flexMoneyLineSelect != null)
            {
                _flexMoneyLineslistAdd.Add(flexMoneyLineSelect);
                _flexMoneyLineslist.Remove(flexMoneyLineSelect);
            }
        }
    }
}
