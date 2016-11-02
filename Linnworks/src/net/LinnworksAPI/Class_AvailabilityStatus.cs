using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AvailabilityStatus
    {
        Draft,
        Request,
        Accepted,
        Packing,
        InTransit,
        CheckingIn,
        Delivered,
        PARTIAL,
        PENDING,
        OPEN,
    }
}