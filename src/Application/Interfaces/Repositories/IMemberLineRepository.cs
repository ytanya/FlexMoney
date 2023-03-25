using FlexMoney.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Repositories
{
    public interface IMemberLineRepository
    {
        Task<List<MemberLine>> GetByLineIdAsync(int id);
    }
}