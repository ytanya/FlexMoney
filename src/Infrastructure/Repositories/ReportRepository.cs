using FlexMoney.Application.Features.Reports.Queries.GetById;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Infrastructure.Contexts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using FlexMoney.Application.Features.Reports.Queries.GetAll;
using static FlexMoney.Shared.Constants.Permission.Permissions;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace FlexMoney.Infrastructure.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly BlazorHeroContext _dbContext;
        public ReportRepository(BlazorHeroContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<List<GetByOwnerIdReportResponse>> GetByOwnerIdReportAsync(int ownerId)
        {
            var connection = (SqlConnection)_dbContext.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandText = "ThankMoneyReport";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Ownerid", ownerId);
            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            var result = new List<GetByOwnerIdReportResponse>();
            while (await reader.ReadAsync())
            {
                result.Add(new GetByOwnerIdReportResponse
                {
                    CreatedDate = reader.GetDateTime(0),
                    LineName = reader.GetString(1),
                    Quantity = reader.GetInt32(2),
                    CurrentSection = reader.GetInt32(3),
                    ThankMoney = reader.GetDecimal(4),
                });
            }

            return result;
        }
        public async Task<List<GetByIdReportResponse>> GetByIdReportAsync(int memberId)
        {
            var connection = (SqlConnection)_dbContext.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SingleMemberReport";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Memberid", memberId);
            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            var result = new List<GetByIdReportResponse>();
            while (await reader.ReadAsync())
            {
                result.Add(new GetByIdReportResponse
                {
                    CreatedDate = reader.GetDateTime(2),
                    LineName = reader.GetString(3),
                    CurrentSection = reader.GetInt32(4),
                    Earn = reader.GetDecimal(5),
                    Pay = reader.GetDecimal(6),
                });
            }

            return result;
        }
        public async Task<List<GetAllMembersReportResponse>> GetAllMembersReportAsync()
        {
            var connection = (SqlConnection)_dbContext.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandText = "AllMemberReport";
            command.CommandType = CommandType.StoredProcedure;
            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            var result = new List<GetAllMembersReportResponse>();
            while (await reader.ReadAsync())
            {
                result.Add(new GetAllMembersReportResponse
                {
                    MemberName = reader.GetString(0),
                    Earn = reader.GetDecimal(1),
                    Pay = reader.GetDecimal(2),
                    ThankMoney = reader.GetDecimal(3),
                    Alive   = reader.GetDecimal(4),
                    Dead = reader.GetDecimal(5),
                });
            }

            return result;
        }





    }
}