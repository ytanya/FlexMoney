using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Application.Features.Transactions.Commands.Delete;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        Task<List<Transaction>> GetByLineIdAsync(int id);
        Task<List<Transaction>> GetAllAsync(bool latestOnly);
        Task<GetTransactionInfoByLineIdResponse> GetTransactionInfoByLineIdAsync(int id);
        Task<List<GetReadyCallerByLineIdResponse>> GetReadyCallerByLineIdAsync(int id);
        Task<int> AddTransactionAsync(AddEditTransactionCommand command);
        Task<int> UpdateTransactionAsync(AddEditTransactionCommand command);
        Task<int> DeleteTransactionAsync(DeleteTransactionCommand command);
    }
}