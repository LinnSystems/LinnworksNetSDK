using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PostSaleStatusType
    {
        NONE,
        BOOKED,
        CHANNEL_INITIATED,
        PENDING,
        SUBMITTED,
        CONFIRMED,
        INTERNAL,
        ERROR_HANDLED,
        ERROR_LOCKED,
        ERROR_UNLOCKED,
    }
}