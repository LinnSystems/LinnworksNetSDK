using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SampleChannel.Models.Order
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentStatus
    {
        /// <summary>
        /// The order will be downloaded as a paid order in Linnworks
        /// </summary>
        PAID,

        /// <summary>
        /// The order will be downloaded as an unpaid order in Linnworks
        /// </summary>
        UNPAID,

        /// <summary>
        /// If the order exists in Linnworks, it will be marked as cancelled. If it doesn't exist in Linnworks, it will be ignored
        /// </summary>
        CANCELLED
    }
}