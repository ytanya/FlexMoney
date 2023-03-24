using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Infrastructure.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private readonly IRepositoryAsync<Type, int> _repository;

        public TypeRepository(IRepositoryAsync<Type, int> repository)
        {
            _repository = repository;
        }
    }
}