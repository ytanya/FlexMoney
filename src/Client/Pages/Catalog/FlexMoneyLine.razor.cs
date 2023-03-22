
using FlexMoney.Application.Features.FlexMoneyTypes.Queries.GettAll;
using FlexMoney.Client.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Collections.Generic;
using System.Security.Claims;
using System;
using System.Threading.Tasks;
using FlexMoney.Application.Features.Memberships.Commands.AddEdit;

namespace FlexMoney.Client.Pages.Catalog
{
    public class FlexMoneyLineReponse 
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Note { get; set; }

    }

    public partial class FlexMoneyLine
    {
        public List<FlexMoneyLineReponse> _flexMoneyLineslist = new List<FlexMoneyLineReponse>
        {
            new FlexMoneyLineReponse{Id = 1,Name = "Name" , Note = ""},
            new FlexMoneyLineReponse{Id = 2,Name = "Hoang" , Note = ""},
            new FlexMoneyLineReponse{Id = 3,Name = "Phuc" , Note = ""},
            new FlexMoneyLineReponse{Id = 4,Name = "VY" , Note = ""}
        };
        public FlexMoneyLineReponse _flexmoneylines;


        private async Task InvokeModal(int id = 0)
        {
     
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddFlexMoneyLinesModel>(id == 0 ? _localizer["Create"] : _localizer["Edit"], options);
            var result = await dialog.Result;

        }
    }


}
