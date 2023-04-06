using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Shared.Wrapper;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Transaction
{
    public interface ITransactionManager : IManager
    {
        Task<IResult<List<GetAllTransactionsResponse>>> GetAllAsync(bool latestOnly);

        Task<IResult<int>> SaveAsync(AddEditTransactionCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");

        Task<IResult<List<GetTransactionByLineIdResponse>>> GetByLineIdAsync(GetTransactionByLineIdQuery request);

        Task<IResult<GetTransactionInfoByLineIdResponse>> GetTransactionInfoByLineIdAsync(GetTransactionInfoByLineIdQuery request);
        Task<IResult<List<GetReadyCallerByLineIdResponse>>> GetReadyCallerByLineIdAsync(GetReadyCallerByLineIdQuery request);
    }
}
