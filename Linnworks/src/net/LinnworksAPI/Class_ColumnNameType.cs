using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ColumnNameType
    {
        SKU,
        Title,
        RetailPrice,
        PurchasePrice,
        Tracked,
        Barcode,
        Available,
        MinimumLevel,
        InOrder,
        StockLevel,
        StockValue,
        Due,
        BinRack,
        Category,
        Image,
        VariationGroupName,
    }
}