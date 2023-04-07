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
using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using System.Data.Common;
using FlexMoney.Application.Interfaces.Services;
using FlexMoney.Application.Features.Transactions.Commands.Delete;

namespace FlexMoney.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IRepositoryAsync<Transaction, int> _repository;
        private readonly BlazorHeroContext _dbContext;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTimeService _dateTimeService;

        public TransactionRepository(IRepositoryAsync<Transaction, int> repository, BlazorHeroContext dbContext, ICurrentUserService currentUserService, IDateTimeService dateTimeService)
        {
            _repository = repository;
            _dbContext = dbContext;
            _currentUserService = currentUserService;
            _dateTimeService = dateTimeService;
        }
        public async Task<List<Transaction>> GetByLineIdAsync(int lineId)
        {
            IQueryable<Transaction> transactionsQuery = _dbContext.Set<Transaction>().AsQueryable();
            List<Transaction> transactions = await transactionsQuery
                .Where(t => t.LineId == lineId)
                .ToListAsync();

            return transactions;
        }
        public async Task<List<Transaction>> GetAllAsync(bool latestOnly)
        {
            IQueryable<Transaction> query = _dbContext.Set<Transaction>();

            if (latestOnly)
            {
                var transactions = await query.Where(t => t.Section > 0).ToListAsync();
                var latestTransactions = transactions.GroupBy(e => e.LineId)
                                                     .Select(g => g.OrderByDescending(e => e.Section).FirstOrDefault())
                                                     .ToList();
                return latestTransactions;
            }

            return query.ToList();
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
                    IsDead = reader.GetInt32(3),
                });
            }

            return result;
        }

        public async Task<int> AddTransactionAsync(AddEditTransactionCommand command)
        {
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
            idParam.Direction = ParameterDirection.Output;

            var parameters = new[]
        {
            new SqlParameter("@createddate", command.CreatedDate),
            new SqlParameter("@lineid", command.LineId),
            new SqlParameter("@typeid", command.TypeId),
            new SqlParameter("@section", command.Section),
            new SqlParameter("@callerid", command.CallerId),
            new SqlParameter("@position", command.Position),
            new SqlParameter("@pay", command.Pay),
            new SqlParameter("@call", command.Call),
            new SqlParameter("@earn", command.Earn),
            new SqlParameter("@thankmoney", command.ThankMoney),
            new SqlParameter("@realearn", command.RealEarn),
            new SqlParameter("@dead", command.Dead),
            new SqlParameter("@alive", command.Alive),
            new SqlParameter("@createdby", _currentUserService.UserId),
            new SqlParameter("@createdon", _dateTimeService.NowUtc),
            idParam
        };

            var result = await _dbContext.Database.ExecuteSqlRawAsync("EXEC InsertTransaction @createddate, @lineid, @typeid, @section, @callerid, @position, @pay, @call, @earn, @thankmoney, @realearn, @dead, @alive, @createdby, @createdon, @id OUTPUT", parameters);
            
            return result;
        }

        public async Task<int> UpdateTransactionAsync(AddEditTransactionCommand command)
        {
            var parameters = new[]
        {
            new SqlParameter("@id", command.Id),
            new SqlParameter("@lineid", command.LineId),
            new SqlParameter("@typeid", command.TypeId),
            new SqlParameter("@section", command.Section),
            new SqlParameter("@callerid", command.CallerId),
            new SqlParameter("@position", command.Position),
            new SqlParameter("@pay", command.Pay),
            new SqlParameter("@call", command.Call),
            new SqlParameter("@earn", command.Earn),
            new SqlParameter("@thankmoney", command.ThankMoney),
            new SqlParameter("@realearn", command.RealEarn),
            new SqlParameter("@dead", command.Dead),
            new SqlParameter("@alive", command.Alive),
        };

            var result = await _dbContext.Database.ExecuteSqlRawAsync("EXEC UpdateTransaction @id, @lineid, @typeid, @section, @callerid, @position, @pay, @call, @earn, @thankmoney, @realearn, @dead, @alive", parameters);

            return result;
        }

        public async Task<int> DeleteTransactionAsync(DeleteTransactionCommand command)
        {
            var parameters = new[]
        {
            new SqlParameter("@lineid", command.Id),
        };

            var result = await _dbContext.Database.ExecuteSqlRawAsync("EXEC DeleteTransaction @lineid", parameters);

            return result;
        }
    }
}