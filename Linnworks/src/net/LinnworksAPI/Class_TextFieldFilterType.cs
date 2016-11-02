using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextFieldFilterType
    {
        Equal,
        Contains,
        StartWith,
        EndsWith,
    }
}