using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDirectionType
    {
        None,
        Descending,
        Ascending,
    }
}