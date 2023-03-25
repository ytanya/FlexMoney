using FlexMoney.Application.Features.MemberLines.Commands.AddEdit;
using FlexMoney.Application.Features.MemberLines.Commands.Delete;
using FlexMoney.Application.Features.MemberLines.Queries.GetAll;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexMoney.Server.Controllers.v1.Catalog
{
    public class MemberLinesController : BaseApiController<MemberLinesController>
    {
        /// <summary>
        /// Get All Member Line
        /// </summary>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.MemberLines.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var memberLines = await _mediator.Send(new GetAllMemberLinesQuery());
            return Ok(memberLines);
        }

        /// <summary>
        /// Get a Member Line By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.MemberLines.View)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var memberLine = await _mediator.Send(new GetMemberLineByIdQuery() { Id = id });
            return Ok(memberLine);
        }

        /// <summary>
        /// Create/Update a Member Line
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.MemberLines.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditMemberLineCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Delete a Member Line
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.MemberLines.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteMemberLineCommand { Id = id }));
        }

        /// <summary>
        /// Get a Member Line By Line Id
        /// </summary>
        /// <param name="lineId"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.MemberLines.View)]
        [HttpGet("line/{lineId}")]
        public async Task<IActionResult> GetByLineId(int lineId)
        {
            var memberLine = await _mediator.Send(new GetMemberLineByLineIdQuery() { LineId = lineId });
            return Ok(memberLine);
        }
    }
}
