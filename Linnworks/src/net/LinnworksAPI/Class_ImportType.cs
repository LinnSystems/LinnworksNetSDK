using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LinnworksAPI
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImportType
    {
        StockItemCompositions,
        Customers,
        eBayCompatibility,
        eBayCompatibilityKtypes,
        Inventory,
        ProcessOrder,
        StockCount,
        SupplierPricesByCode,
        StockLevelBySupplierCode,
        StockLevel,
        ItemMapping,
        Orders,
        FulfilmentCenterOrdersImport,
        FulfilmentCenterInventoryImport,
        DeletePriceByChannel,
        DeleteTitleByChannel,
        DeleteDescriptionByChannel,
        DeleteStockItem,
        DeleteImages,
        DeleteExtendedProperties,
        DeleteVariationItems,
        DeleteItemMapping,
        DeleteComposition,
    }
}