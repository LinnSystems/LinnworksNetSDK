using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{ [JsonConverter(typeof(StringEnumConverter))]
public enum ImportType
{ StockItemCompositions,
Customers,
eBayCompatibility,
eBayCompatibilityKtypes,
eBayCompatibilityePID,
Inventory,
ProcessOrder,
StockCount,
SupplierPricesByCode,
StockLevelBySupplierCode,
StockLevel,
ItemMapping,
ItemMappingWithChannelLocations,
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
StockLevelBatch,
ebayListingStrikeOff,
RenameSKU,
TrackingNumbers,
 
} 
}