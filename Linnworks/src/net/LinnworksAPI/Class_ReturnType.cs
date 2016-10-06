using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReturnType
    {
        UNKNOWN,
        RETURN,
        RETURNREFUND,
        EXCHANGE,
        RESEND,
        RETURNBOOKING,
        EXCHANGEBOOKING,
    }
}