using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldType
    {
        Default,
        String,
        Int,
        Bool,
        Guid,
        Float,
        Double,
    }
}