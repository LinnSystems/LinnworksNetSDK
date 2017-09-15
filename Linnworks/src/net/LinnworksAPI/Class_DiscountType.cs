using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiscountType
    {
        AllEvenly,
        ItemsThenPostage,
        PostageThenItems,
    }
}