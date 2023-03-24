using FlexMoney.Application.Features.Types.Commands.AddEdit;
using FlexMoney.Application.Features.Types.Commands.Delete;
using FlexMoney.Application.Features.Types.Queries.GetById;
using FlexMoney.Application.Features.Types.Queries.GettAll;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FlexMoney.Server.Controllers.v1.Catalog
{

    public class TypesController  : BaseApiController<TypesController>
    {
        /// <summary>
        /// Get All Types
        /// </summary>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Types.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var types = await _mediator.Send(new GetAllTypesQuery());
            return Ok(types);
        }

        /// <summary>
        /// Get a Type By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.Types.View)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var type = await _mediator.Send(new GetTypeByIdQuery() { Id = id });
            return Ok(type);
        }

        /// <summary>
        /// Create/Update a Type
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Types.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditTypeCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Delete a Type
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Types.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteTypeCommand { Id = id }));
        }
    }
}
