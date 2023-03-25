using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexMoney.Application.Features.MemberLines.Commands.AddEdit;
using FlexMoney.Application.Features.MemberLines.Queries.GetAll;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using FlexMoney.Shared.Wrapper;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.MemberLine
{
    public interface IMemberLineManager : IManager
    {
        Task<IResult<List<GetAllMemberLinesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditMemberLineCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");

        Task<IResult<List<GetMemberLineByLineIdResponse>>> GetByLineIdAsync(GetMemberLineByLineIdQuery request);
    }
}
