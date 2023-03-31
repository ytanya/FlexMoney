using FlexMoney.Application.Features.Reports.Queries.GetAll;
using FlexMoney.Application.Features.Reports.Queries.GetById;
using FlexMoney.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Repositories
{
    public interface IReportRepository
    {
        Task<List<GetByIdReportResponse>> GetByIdReportAsync(int memberId);
        Task<List<GetAllMembersReportResponse>> GetAllMembersReportAsync();
        Task<List<GetByOwnerIdReportResponse>> GetByOwnerIdReportAsync(int memberId);
    }
}