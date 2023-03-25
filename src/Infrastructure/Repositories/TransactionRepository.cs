using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Infrastructure.Contexts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace FlexMoney.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IRepositoryAsync<Transaction, int> _repository;
        private readonly BlazorHeroContext _dbContext;

        public TransactionRepository(IRepositoryAsync<Transaction, int> repository, BlazorHeroContext dbContext)
        {
            _repository = repository;
            _dbContext = dbContext;
        }
        public async Task<List<Transaction>> GetByLineIdAsync(int lineId)
        {
            IQueryable<Transaction> transactionsQuery = _dbContext.Set<Transaction>().AsQueryable();
            List<Transaction> transactions = await transactionsQuery
                .Where(t => t.LineId == lineId)
                .ToListAsync();

            return transactions;
        }
        public async Task<List<Transaction>> GetAllAsync(bool latestOnly = false)
        {
            IQueryable<Transaction> query = _dbContext.Set<Transaction>();

            if (latestOnly)
            {
                var transactions = await query.Where(t => t.Section > 0).ToListAsync();
                var latestTransactions = transactions.GroupBy(e => e.LineId)
                                                     .Select(g => g.OrderByDescending(e => e.CreatedDate).FirstOrDefault())
                                                     .ToList();
                return latestTransactions;
            }

            return await query.ToListAsync();
        }





    }
}