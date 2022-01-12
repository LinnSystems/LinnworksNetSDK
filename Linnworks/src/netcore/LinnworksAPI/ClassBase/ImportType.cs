using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ImportType
	{
		StockItemCompositions,
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
		DeleteNonPrimaryImages,
		DeletePrimaryImages,
		DeleteExtendedProperties,
		DeleteVariationItems,
		DeleteItemMapping,
		DeleteComposition,
		StockLevelBatch,
		ebayListingStrikeOff,
		ebayListingRelistPendingDelete,
		RenameSKU,
		ProductIdentifiers,
		TrackingNumbers,
		JITStatus,
		ReorderPointGeneralParams,
		ReorderPointWeeklyParams,
		eBayCompatibilityKtypesCulture,
		eBayCompatibilityePIDCulture,
		MultipleListingTitlesAndPrices,
	}
}