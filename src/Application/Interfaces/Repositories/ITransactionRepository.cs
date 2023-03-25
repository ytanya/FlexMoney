using FlexMoney.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        Task<List<Transaction>> GetByLineIdAsync(int id);
        Task<List<Transaction>> GetAllAsync(bool latestOnly = false);
    }
}