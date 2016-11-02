using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValidationResultTypes
    {
        Success,
        Unknown,
        RefundAutomationDisabled,
        NotAllowedByChannel,
        InvalidRefundAmounts,
        NotImplementedForChannel,
    }
}