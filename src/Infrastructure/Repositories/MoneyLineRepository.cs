using FlexMoney.Application.Features.MemberLines.Commands.AddEdit;
using FlexMoney.Application.Features.MemberLines.Commands.Delete;
using FlexMoney.Application.Features.Transactions.Commands.Delete;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Infrastructure.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FlexMoney.Infrastructure.Repositories
{
    public class MoneyLineRepository : IMoneyLineRepository
    {
        private readonly IRepositoryAsync<MoneyLine, int> _repository;
        private readonly BlazorHeroContext _dbContext;

        public MoneyLineRepository(IRepositoryAsync<MoneyLine, int> repository, BlazorHeroContext dbContext)
        {
            _repository = repository;
            _dbContext = dbContext;
        }
        public async Task<bool> IsNameUnique(string name)
        {
            return await _repository.Entities.AnyAsync(b => b.Name == name);
        }
        public async Task<bool> IsTypeUsed(int typeId)
        {
            return await _repository.Entities.AnyAsync(b => b.TypeId == typeId);
        }
        
    }
}