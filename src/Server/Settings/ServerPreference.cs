using System.Linq;
using FlexMoney.Shared.Constants.Localization;
using FlexMoney.Shared.Settings;

namespace FlexMoney.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}