using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Application.Features.MoneyLines.Commands.Delete;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Application.Features.MoneyLines.Queries.GetById;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexMoney.Server.Controllers.v1.Catalog
{
    public class MoneyLinesController : BaseApiController<MoneyLinesController>
    {
        /// <summary>
        /// Get All Money Line
        /// </summary>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.MoneyLines.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var moneyLines = await _mediator.Send(new GetAllMoneyLinesQuery());
            return Ok(moneyLines);
        }

        /// <summary>
        /// Get a Money Line By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.MoneyLines.View)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var moneyLine = await _mediator.Send(new GetMoneyLineByIdQuery() { Id = id });
            return Ok(moneyLine);
        }

        /// <summary>
        /// Create/Update a Money Line
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.MoneyLines.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditMoneyLineCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Delete a Money Line
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.MoneyLines.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteMoneyLineCommand { Id = id }));
        }
    }
}
