using FlexMoney.Application.Interfaces.Common;
using FlexMoney.Application.Requests.Identity;
using FlexMoney.Application.Responses.Identity;
using FlexMoney.Shared.Wrapper;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}