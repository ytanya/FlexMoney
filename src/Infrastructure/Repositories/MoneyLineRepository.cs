using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FlexMoney.Infrastructure.Repositories
{
    public class MoneyLineRepository : IMoneyLineRepository
    {
        private readonly IRepositoryAsync<MoneyLine, int> _repository;

        public MoneyLineRepository(IRepositoryAsync<MoneyLine, int> repository)
        {
            _repository = repository;
        }
        public async Task<bool> IsNameUnique(string name)
        {
            return await _repository.Entities.AnyAsync(b => b.Name == name);
        }
    }
}