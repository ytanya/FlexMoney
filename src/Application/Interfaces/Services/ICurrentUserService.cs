using FlexMoney.Application.Interfaces.Common;

namespace FlexMoney.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}