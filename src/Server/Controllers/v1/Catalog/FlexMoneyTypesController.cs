using FlexMoney.Application.Features.FlexMoneyTypes.Commands.AddFlexMoneyType;
using FlexMoney.Application.Features.FlexMoneyTypes.Queries.GettAll;
using FlexMoney.Application.Features.Memberships.Commands.AddEdit;
using FlexMoney.Application.Features.Memberships.Queries.GetAll;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polly;
using System.Threading.Tasks;

namespace FlexMoney.Server.Controllers.v1.Catalog
{

    public class FlexMoneyTypesController  : BaseApiController<MembershipsController>
    {
        //[Authorize(Policy = Permissions.FlexMoneyTypes.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var brands = await _mediator.Send(new GetAllFlexMoneyTypeQuery());
            return Ok(brands);
        }

        [Authorize(Policy = Permissions.FlexMoneyTypes.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddFlexMonryTypeCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
