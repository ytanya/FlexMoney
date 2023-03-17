using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexMoney.Application.Features.Memberships.Commands.AddEdit;
using FlexMoney.Application.Features.Memberships.Queries.GetAll;
using FlexMoney.Shared.Wrapper;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Membership
{
    public interface IMembershipManager : IManager
    {
        Task<IResult<List<GetAllMembershipsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditMembershipCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}
