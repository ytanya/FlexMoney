using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Repositories
{
    public interface IMoneyLineRepository
    {
        Task<bool> IsNameUnique(string name);
    }
}