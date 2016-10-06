using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FieldType
    {
        Int,
        Double,
        String,
        Boolean,
        Select,
        Date,
        Channel,
        Other,
    }
}