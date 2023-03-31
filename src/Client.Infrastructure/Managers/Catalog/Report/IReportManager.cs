using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexMoney.Application.Features.Reports.Queries.GetAll;
using FlexMoney.Application.Features.Reports.Queries.GetById;
using FlexMoney.Shared.Wrapper;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Report
{
    public interface IReportManager : IManager
    {
        Task<IResult<List<GetAllMembersReportResponse>>> GetAllMembersReportAsync();
        Task<IResult<List<GetByIdReportResponse>>> GetReportByMemberIdAsync(GetByIdReportQuery request);
        Task<IResult<List<GetByOwnerIdReportResponse>>> GetReportByOwnerIdAsync(GetByOwnerIdReportQuery request);
    }
}
