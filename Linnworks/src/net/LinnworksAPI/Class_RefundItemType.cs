using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RefundItemType
    {
        Item,
        Service,
        Shipping,
        FreeText,
    }
}