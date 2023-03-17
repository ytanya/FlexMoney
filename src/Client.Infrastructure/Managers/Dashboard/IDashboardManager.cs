using FlexMoney.Shared.Wrapper;
using System.Threading.Tasks;
using FlexMoney.Application.Features.Dashboards.Queries.GetData;

namespace FlexMoney.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}