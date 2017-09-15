using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderProcessedState
    {
        PROCESSED,
        NOT_FOUND,
        SCAN_REQUIRED,
        NOT_PROCESSED,
        NOTE_ACKNOWLEDGEMENT_REQUIRED,
        NOT_IN_WORKFLOW,
    }
}