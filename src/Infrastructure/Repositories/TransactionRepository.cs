using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IRepositoryAsync<Transaction, int> _repository;

        public TransactionRepository(IRepositoryAsync<Transaction, int> repository)
        {
            _repository = repository;
        }
    }
}