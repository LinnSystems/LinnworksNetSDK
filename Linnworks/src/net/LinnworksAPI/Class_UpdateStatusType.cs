using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpdateStatusType
    {
        NoChange,
        Pending,
        SentNotConfirmed,
        Success,
        Error,
    }
}