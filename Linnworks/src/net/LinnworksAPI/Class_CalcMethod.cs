using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CalcMethod
    {
        LEGACY,
        MAX,
        STACKED,
        WEIGHTFIT,
        THREEDIM_ALL,
        THREEDIM_ITEMS,
    }
}