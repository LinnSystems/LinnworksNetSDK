using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NumericFilterType
    {
        Equal,
        Greater,
        Less,
    }
}