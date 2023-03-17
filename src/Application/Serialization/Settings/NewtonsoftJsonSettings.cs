
using FlexMoney.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace FlexMoney.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}