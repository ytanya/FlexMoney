using FlexMoney.Application.Features.Members.Commands.Delete;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Repositories
{
    public interface IMemberRepository
    {
        Task<bool> IsNameUnique(string name);
        Task<int> DeleteMemberAsync(DeleteMemberCommand command);
    }
}