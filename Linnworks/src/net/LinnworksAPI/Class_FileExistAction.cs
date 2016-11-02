using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileExistAction
    {
        Overwride,
        Overwrite,
        Append,
    }
}