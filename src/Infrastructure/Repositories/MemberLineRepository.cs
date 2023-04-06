using FlexMoney.Application.Features.MemberLines.Commands.Delete;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Infrastructure.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexMoney.Infrastructure.Repositories
{
    public class MemberLineRepository : IMemberLineRepository
    {
        private readonly BlazorHeroContext _dbContext;
        private readonly IRepositoryAsync<MemberLine, int> _repository;

        public MemberLineRepository(IRepositoryAsync<MemberLine, int> repository, BlazorHeroContext dbContext)
        {
            _repository = repository;
            _dbContext = dbContext;
        }
        public async Task<List<MemberLine>> GetByLineIdAsync(int lineId)
        {
            IQueryable<MemberLine> memberLinesQuery = _dbContext.Set<MemberLine>().AsQueryable();
            List<MemberLine> memberLines = await memberLinesQuery
                .Where(t => t.LineId == lineId)
                .ToListAsync();

            return memberLines;
        }
        public async Task<bool> IsMemberUsed(int memberId)
        {
            return await _repository.Entities.AnyAsync(b => b.MemberId == memberId);
        }

        public async Task<bool> IsLineUsed(int lineId)
        {
            return await _repository.Entities.AnyAsync(b => b.LineId == lineId);
        }
        public async Task<int> DeleteMemberLinesAsync(DeleteMemberLineCommand command)
        {
            var parameters = new[]
        {
            new SqlParameter("@Lineid", command.Id),
        };

            var result = await _dbContext.Database.ExecuteSqlRawAsync("EXEC DeleteMemberLines @Lineid", parameters);

            return result;
        }
    }
}