using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FilterNameType
    {
        General,
        SKU,
        Title,
        RetailPrice,
        PurchasePrice,
        Tracked,
        Barcode,
        VariationGroupName,
        Available,
        MinimumLevel,
        InOrder,
        StockLevel,
        StockValue,
        Due,
        BinRack,
        Category,
        ChannelSKU,
        SupplierCode,
        eBayId,
        AmazonASIN,
        Image,
        ExtendedProperty,
        ExtendedPropertyName,
        Channel,
        CreatedDate,
        ModifiedDate,
        SerialNumberScanRequired,
        BatchNumberScanRequired,
        BatchType,
        BatchNumber,
        Weight,
        DimHeight,
        DimWidth,
        DimDepth,
    }
}