using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionType
    {
        Equals,
        Contains,
        Less,
        Greater,
        NotEquals,
        NotContains,
        Exists,
        Listed,
        NotListed,
        HasError,
        OnlyErrors,
        NoErrors,
    }
}