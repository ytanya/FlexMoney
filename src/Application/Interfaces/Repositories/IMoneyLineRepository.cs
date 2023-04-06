using FlexMoney.Application.Features.MemberLines.Commands.AddEdit;
using FlexMoney.Application.Features.MemberLines.Commands.Delete;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Repositories
{
    public interface IMoneyLineRepository
    {
        Task<bool> IsNameUnique(string name);
        Task<bool> IsTypeUsed(int typeId);
    }
}