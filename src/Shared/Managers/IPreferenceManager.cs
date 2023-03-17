using FlexMoney.Shared.Settings;
using System.Threading.Tasks;
using FlexMoney.Shared.Wrapper;

namespace FlexMoney.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}