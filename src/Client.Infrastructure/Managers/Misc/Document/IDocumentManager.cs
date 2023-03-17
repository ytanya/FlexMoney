using FlexMoney.Application.Features.Documents.Commands.AddEdit;
using FlexMoney.Application.Features.Documents.Queries.GetAll;
using FlexMoney.Application.Requests.Documents;
using FlexMoney.Shared.Wrapper;
using System.Threading.Tasks;
using FlexMoney.Application.Features.Documents.Queries.GetById;

namespace FlexMoney.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}