using FlexMoney.Application.Features.Types.Commands.AddEdit;
using FlexMoney.Application.Features.Types.Queries.GetAll;
using FlexMoney.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Type
{
    public interface ITypeManager : IManager
    {
        Task<IResult<List<GetAllTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}
