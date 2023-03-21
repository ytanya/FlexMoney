using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Application.Features.Members.Commands.Delete;
using FlexMoney.Application.Features.Members.Queries.GetAll;
using FlexMoney.Application.Features.Members.Queries.GetById;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexMoney.Server.Controllers.v1.Catalog
{
    public class MembersController : BaseApiController<MembersController>
    {
        /// <summary>
        /// Get All Members
        /// </summary>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Members.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var members = await _mediator.Send(new GetAllMembersQuery());
            return Ok(members);
        }

        /// <summary>
        /// Get a Member By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.Members.View)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var member = await _mediator.Send(new GetMemberByIdQuery() { Id = id });
            return Ok(member);
        }

        /// <summary>
        /// Create/Update a Member
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Members.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditMemberCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Delete a Member
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Members.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteMemberCommand { Id = id }));
        }
    }
}
