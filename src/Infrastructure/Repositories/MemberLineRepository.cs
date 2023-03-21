using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Infrastructure.Repositories
{
    public class MemberLineRepository : IMemberLineRepository
    {
        private readonly IRepositoryAsync<MemberLine, int> _repository;

        public MemberLineRepository(IRepositoryAsync<MemberLine, int> repository)
        {
            _repository = repository;
        }
    }
}