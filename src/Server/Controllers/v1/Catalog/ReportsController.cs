using FlexMoney.Application.Features.Reports.Queries.Export;
using FlexMoney.Application.Features.Reports.Queries.GetAll;
using FlexMoney.Application.Features.Reports.Queries.GetById;
using FlexMoney.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// Search Products and Export to Excel
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Reports.Export)]
        [HttpGet("all/export")]
        public async Task<IActionResult> Export(string searchString = "")
        {
            return Ok(await _mediator.Send(new ExportReportsQuery() { Id = 0, Prefix="all" }));
        }
        /// <summary>
        /// Search Products and Export to Excel
        /// </summary>
        /// <param name="id"></param>
        /// <param name="searchString"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Reports.Export)]
        [HttpGet("{id}/export")]
        public async Task<IActionResult> ExportById(int id, string searchString = "")
        {
            return Ok(await _mediator.Send(new ExportReportsQuery() { Id= id, Prefix=""}));
        }

        /// <summary>
        /// Search Products and Export to Excel
        /// </summary>
        /// <param name="id"></param>
        /// <param name="searchString"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Products.Export)]
        [HttpGet("thankmoney/{id}/export")]
        public async Task<IActionResult> ExportThankMoney(int id, string searchString = "")
        {
            return Ok(await _mediator.Send(new ExportReportsQuery() { Id=id, Prefix="thankmoney"}));
        }
    }
}
