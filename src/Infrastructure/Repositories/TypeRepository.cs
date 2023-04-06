using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FlexMoney.Infrastructure.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private readonly IRepositoryAsync<Type, int> _repository;

        public TypeRepository(IRepositoryAsync<Type, int> repository)
        {
            _repository = repository;
        }
        public async Task<bool> IsNameUnique(string name)
        {
            return await _repository.Entities.AnyAsync(b => b.Name == name);
        }
    }
}