using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Infrastructure.Contexts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using FlexMoney.Application.Features.Reports.Queries.GetById;
using Microsoft.Data.SqlClient;
using System.Data;

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
        
        public async Task<GetTransactionInfoByLineIdResponse> GetTransactionInfoByLineIdAsync(int lineId)
        {
            var connection = (SqlConnection)_dbContext.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandText = "GetTransactionInfoByLineId";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@LineId", lineId);
            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new GetTransactionInfoByLineIdResponse
                {
                    TypeName = reader.GetString(0),
                    CurrentSection = reader.GetInt32(1),
                    Money = reader.GetDecimal(2),
                    TotalThankMoney = reader.GetDecimal(3),
                };
            }

            return null;
        }
        public async Task<List<GetReadyCallerByLineIdResponse>> GetReadyCallerByLineIdAsync(int lineId)
        {
            var connection = (SqlConnection)_dbContext.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandText = "GetReadyCallerByLineId";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@LineId", lineId);
            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            var result = new List<GetReadyCallerByLineIdResponse>();
            while (await reader.ReadAsync())
            {
                result.Add(new GetReadyCallerByLineIdResponse
                {
                    Id = reader.GetInt32(0),
                    MemberName = reader.GetString(1),
                    Position = reader.GetInt32(2),
                });
            }

            return result;
        }
    }
}