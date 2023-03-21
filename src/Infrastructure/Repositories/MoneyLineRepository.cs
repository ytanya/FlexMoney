using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Infrastructure.Repositories
{
    public class MoneyLineRepository : IMoneyLineRepository
    {
        private readonly IRepositoryAsync<MoneyLine, int> _repository;

        public MoneyLineRepository(IRepositoryAsync<MoneyLine, int> repository)
        {
            _repository = repository;
        }
    }
}