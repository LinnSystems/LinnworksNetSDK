using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReturnsRefundsSearchDateType
    {
        ALLDATES,
        RECEIVED,
        PROCESSED,
        BOOKED,
        ACTIONED,
    }
}