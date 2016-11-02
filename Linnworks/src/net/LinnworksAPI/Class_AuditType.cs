using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditType
    {
        TransferStatusChange,
        TransferItem,
        TransferNote,
        TransferProperty,
        TransferBin,
        TransferInformation,
        TransferMerge,
    }
}