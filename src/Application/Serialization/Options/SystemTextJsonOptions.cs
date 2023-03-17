using System.Text.Json;
using FlexMoney.Application.Interfaces.Serialization.Options;

namespace FlexMoney.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}