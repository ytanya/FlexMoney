using FlexMoney.Application.Features.FlexMoneyTypes.Commands.AddFlexMoneyType;
using FlexMoney.Application.Features.FlexMoneyTypes.Queries.GettAll;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.FlexMoneyType
{
    public interface IFlexMoneyTypesManager : IManager
    {
        Task<IResult<List<GetAllFlexMoneyResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddFlexMonryTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}
