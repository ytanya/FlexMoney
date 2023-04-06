using FlexMoney.Application.Features.Members.Commands.Delete;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Infrastructure.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FlexMoney.Infrastructure.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly IRepositoryAsync<Member, int> _repository;
        private readonly BlazorHeroContext _dbContext;

        public MemberRepository(IRepositoryAsync<Member, int> repository, BlazorHeroContext dbContext)
        {
            _repository = repository;
            _dbContext = dbContext;
        }

        public async Task<bool> IsNameUnique(string name)
        {
            return await _repository.Entities.AnyAsync(b => b.Name == name && b.IsDeleted == false);
        }
        public async Task<int> DeleteMemberAsync(DeleteMemberCommand command)
        {
            var parameters = new[]
            {
                new SqlParameter("@Memberid", command.Id),
            };

            var result = await _dbContext.Database.ExecuteSqlRawAsync("EXEC DeleteMember @Memberid", parameters);

            return result;
        }
    }
}