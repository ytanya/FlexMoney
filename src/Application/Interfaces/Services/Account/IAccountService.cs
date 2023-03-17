using FlexMoney.Application.Interfaces.Common;
using FlexMoney.Application.Requests.Identity;
using FlexMoney.Shared.Wrapper;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}