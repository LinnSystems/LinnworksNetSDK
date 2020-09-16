using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace TemplateProxyExample.Models.Order
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentStatus
    {
        PAID,
        UNPAID,
        CANCELLED
    }
}