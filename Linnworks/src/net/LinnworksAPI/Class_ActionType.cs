using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionType
    {
        AssignShippingService,
        AssignToFolder,
        AssignToLocation,
        SplitOrderByWeight,
        SplitOrderByValue,
        SplitOrderSingle,
    }
}