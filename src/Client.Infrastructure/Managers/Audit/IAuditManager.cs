using FlexMoney.Application.Responses.Audit;
using FlexMoney.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Audit
{
    public interface IAuditManager : IManager
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync();

        Task<IResult<string>> DownloadFileAsync(string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}