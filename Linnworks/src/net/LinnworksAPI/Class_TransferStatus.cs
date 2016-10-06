using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransferStatus
    {
        Draft,
        Request,
        Accepted,
        Packing,
        InTransit,
        CheckingIn,
        Delivered,
    }
}