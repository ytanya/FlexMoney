using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Infrastructure.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly IRepositoryAsync<Member, int> _repository;

        public MemberRepository(IRepositoryAsync<Member, int> repository)
        {
            _repository = repository;
        }
    }
}