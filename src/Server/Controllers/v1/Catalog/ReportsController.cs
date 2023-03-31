using FlexMoney.Application.Features.Reports.Queries.GetAll;
using FlexMoney.Application.Features.Reports.Queries.GetById;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Polly;
using System.Threading.Tasks;

namespace FlexMoney.Server.Controllers.v1.Catalog
{
    public class ReportsController : BaseApiController<ReportsController>
    {
        /// <summary>
        /// Get all  member report
        /// </summary>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.Reports.View)]
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var transaction = await _mediator.Send(new GetAllMembersReportQuery());
            return Ok(transaction);
        }

        /// <summary>
        /// Get a report By Member Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.Reports.View)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var transaction = await _mediator.Send(new GetByIdReportQuery() { MemberId = id });
            return Ok(transaction);
        }

        /// <summary>
        /// Get a report By Member Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.Reports.View)]
        [HttpGet("thankmoney/{id}")]
        public async Task<IActionResult> GetByOwnerId(int id)
        {
            var transaction = await _mediator.Send(new GetByOwnerIdReportQuery() { OwnerId = id });
            return Ok(transaction);
        }
    }
}
