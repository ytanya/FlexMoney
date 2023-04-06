using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Repositories
{
    public interface ITypeRepository
    {
        Task<bool> IsNameUnique(string name);
    }
}