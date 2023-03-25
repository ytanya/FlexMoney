using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Application.Features.MoneyLines.Queries.GetById;
using FlexMoney.Shared.Wrapper;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.MoneyLine
{
    public interface IMoneyLineManager : IManager
    {
        Task<IResult<List<GetAllMoneyLinesResponse>>> GetAllAsync();
        Task<IResult<GetMoneyLineByIdResponse>> GetByIdAsync(GetMoneyLineByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditMoneyLineCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}
