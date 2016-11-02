using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StockInformationDataRequirement
    {
        StockLevels,
        Pricing,
        Supplier,
        ShippingInformation,
        ChannelTitle,
        ChannelDescription,
        ChannelPrice,
    }
}