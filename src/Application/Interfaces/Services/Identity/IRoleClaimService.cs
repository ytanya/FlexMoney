using System.Collections.Generic;
using System.Threading.Tasks;
using FlexMoney.Application.Interfaces.Common;
using FlexMoney.Application.Requests.Identity;
using FlexMoney.Application.Responses.Identity;
using FlexMoney.Shared.Wrapper;

namespace FlexMoney.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}