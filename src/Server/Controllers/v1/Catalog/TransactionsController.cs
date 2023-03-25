using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Application.Features.Transactions.Commands.Delete;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexMoney.Server.Controllers.v1.Catalog
{
    public class TransactionsController : BaseApiController<TransactionsController>
    {
        /// <summary>
        /// Get All Transactions
        /// </summary>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Transactions.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var transactions = await _mediator.Send(new GetAllTransactionsQuery());
            return Ok(transactions);
        }

        /// <summary>
        /// Get a Transaction By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.Transactions.View)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var transaction = await _mediator.Send(new GetTransactionByIdQuery() { Id = id });
            return Ok(transaction);
        }

        /// <summary>
        /// Create/Update a Transaction
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Transactions.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditTransactionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Delete a Transaction
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Transactions.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteTransactionCommand { Id = id }));
        }

        /// <summary>
        /// Get a Transaction By Line Id
        /// </summary>
        /// <param name="lineId"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.Transactions.View)]
        [HttpGet("line/{lineId}")]
        public async Task<IActionResult> GetByLineId(int lineId)
        {
            var transaction = await _mediator.Send(new GetTransactionByLineIdQuery() { LineId = lineId });
            return Ok(transaction);
        }
    }
}
