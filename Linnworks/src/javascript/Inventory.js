var Inventory =
{
	// http://apidoc.linnworks.net/#/Inventory-AddImageToInventoryItem
	AddImageToInventoryItem: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/AddImageToInventoryItem", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AddInventoryItem
	AddInventoryItem: function(inventoryItem,token, server)
	{
		return Factory.GetResponse("Inventory/AddInventoryItem", token, server, "inventoryItem=" + JSON.stringify(inventoryItem) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AddItemLocations
	AddItemLocations: function(itemLocations,token, server)
	{
		return Factory.GetResponse("Inventory/AddItemLocations", token, server, "itemLocations=" + JSON.stringify(itemLocations) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AddScrapCategories
	AddScrapCategories: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/AddScrapCategories", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AddScrapItem
	AddScrapItem: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/AddScrapItem", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AddSupplier
	AddSupplier: function(supplier,token, server)
	{
		return Factory.GetResponse("Inventory/AddSupplier", token, server, "supplier=" + JSON.stringify(supplier) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AdjustTemplatesInstant
	AdjustTemplatesInstant: function(inventoryItemIds,source,subSource,adjustmentOptions,token, server)
	{
		return Factory.GetResponse("Inventory/AdjustTemplatesInstant", token, server, "inventoryItemIds=" + JSON.stringify(inventoryItemIds) + "&source=" + source + "&subSource=" + subSource + "&adjustmentOptions=" + JSON.stringify(adjustmentOptions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-ArchiveInventoryItems
	ArchiveInventoryItems: function(parameters,token, server)
	{
		return Factory.GetResponse("Inventory/ArchiveInventoryItems", token, server, "parameters=" + JSON.stringify(parameters) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateBatches
	CreateBatches: function(batches,token, server)
	{
		return Factory.GetResponse("Inventory/CreateBatches", token, server, "batches=" + JSON.stringify(batches) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateCategory
	CreateCategory: function(categoryName,token, server)
	{
		return Factory.GetResponse("Inventory/CreateCategory", token, server, "categoryName=" + categoryName +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateCountries
	CreateCountries: function(countries,token, server)
	{
		return Factory.GetResponse("Inventory/CreateCountries", token, server, "countries=" + JSON.stringify(countries) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateCountryRegions
	CreateCountryRegions: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/CreateCountryRegions", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemChannelSKUs
	CreateInventoryItemChannelSKUs: function(inventoryItemChannelSKUs,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemChannelSKUs", token, server, "inventoryItemChannelSKUs=" + JSON.stringify(inventoryItemChannelSKUs) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemCompositions
	CreateInventoryItemCompositions: function(inventoryItemCompositions,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemCompositions", token, server, "inventoryItemCompositions=" + JSON.stringify(inventoryItemCompositions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemDescriptions
	CreateInventoryItemDescriptions: function(inventoryItemDescriptions,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemDescriptions", token, server, "inventoryItemDescriptions=" + JSON.stringify(inventoryItemDescriptions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemExtendedProperties
	CreateInventoryItemExtendedProperties: function(inventoryItemExtendedProperties,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemExtendedProperties", token, server, "inventoryItemExtendedProperties=" + JSON.stringify(inventoryItemExtendedProperties) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemPrices
	CreateInventoryItemPrices: function(inventoryItemPrices,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemPrices", token, server, "inventoryItemPrices=" + JSON.stringify(inventoryItemPrices) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemPricingRules
	CreateInventoryItemPricingRules: function(rules,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemPricingRules", token, server, "rules=" + JSON.stringify(rules) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemTitles
	CreateInventoryItemTitles: function(inventoryItemTitles,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemTitles", token, server, "inventoryItemTitles=" + JSON.stringify(inventoryItemTitles) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateStockSupplierStat
	CreateStockSupplierStat: function(itemSuppliers,token, server)
	{
		return Factory.GetResponse("Inventory/CreateStockSupplierStat", token, server, "itemSuppliers=" + JSON.stringify(itemSuppliers) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateUserSpecificView
	CreateUserSpecificView: function(view,token, server)
	{
		return Factory.GetResponse("Inventory/CreateUserSpecificView", token, server, "view=" + JSON.stringify(view) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteBatchesByStockItemId
	DeleteBatchesByStockItemId: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteBatchesByStockItemId", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteBatchInventoryInBulk
	DeleteBatchInventoryInBulk: function(batchInventoryIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteBatchInventoryInBulk", token, server, "batchInventoryIds=" + JSON.stringify(batchInventoryIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteCategoryById
	DeleteCategoryById: function(categoryId,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteCategoryById", token, server, "categoryId=" + categoryId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteCountries
	DeleteCountries: function(countriesIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteCountries", token, server, "countriesIds=" + JSON.stringify(countriesIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteEbayCompatibilityList
	DeleteEbayCompatibilityList: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteEbayCompatibilityList", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteImagesFromInventoryItem
	DeleteImagesFromInventoryItem: function(inventoryItemImages,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteImagesFromInventoryItem", token, server, "inventoryItemImages=" + JSON.stringify(inventoryItemImages) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemChannelSKUs
	DeleteInventoryItemChannelSKUs: function(inventoryItemChannelSKUIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemChannelSKUs", token, server, "inventoryItemChannelSKUIds=" + JSON.stringify(inventoryItemChannelSKUIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemCompositions
	DeleteInventoryItemCompositions: function(stockItemId,inventoryItemCompositionIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemCompositions", token, server, "stockItemId=" + stockItemId + "&inventoryItemCompositionIds=" + JSON.stringify(inventoryItemCompositionIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemDescriptions
	DeleteInventoryItemDescriptions: function(inventoryItemDescriptionIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemDescriptions", token, server, "inventoryItemDescriptionIds=" + JSON.stringify(inventoryItemDescriptionIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemExtendedProperties
	DeleteInventoryItemExtendedProperties: function(inventoryItemId,inventoryItemExtendedPropertyIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemExtendedProperties", token, server, "inventoryItemId=" + inventoryItemId + "&inventoryItemExtendedPropertyIds=" + JSON.stringify(inventoryItemExtendedPropertyIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemPrices
	DeleteInventoryItemPrices: function(inventoryItemPriceIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemPrices", token, server, "inventoryItemPriceIds=" + JSON.stringify(inventoryItemPriceIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemPricingRules
	DeleteInventoryItemPricingRules: function(pricingRuleIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemPricingRules", token, server, "pricingRuleIds=" + JSON.stringify(pricingRuleIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItems
	DeleteInventoryItems: function(request,inventoryItemIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItems", token, server, "request=" + JSON.stringify(request) + "&inventoryItemIds=" + JSON.stringify(inventoryItemIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemTitles
	DeleteInventoryItemTitles: function(inventoryItemTitleIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemTitles", token, server, "inventoryItemTitleIds=" + JSON.stringify(inventoryItemTitleIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteItemLocations
	DeleteItemLocations: function(inventoryItemId,itemLocations,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteItemLocations", token, server, "inventoryItemId=" + inventoryItemId + "&itemLocations=" + JSON.stringify(itemLocations) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteScrapCategories
	DeleteScrapCategories: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteScrapCategories", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteStockSupplierStat
	DeleteStockSupplierStat: function(stockItemId,itemSupplierIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteStockSupplierStat", token, server, "stockItemId=" + stockItemId + "&itemSupplierIds=" + JSON.stringify(itemSupplierIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteSuppliers
	DeleteSuppliers: function(suppliersIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteSuppliers", token, server, "suppliersIds=" + JSON.stringify(suppliersIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteUserSpecificView
	DeleteUserSpecificView: function(viewName,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteUserSpecificView", token, server, "viewName=" + viewName +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DuplicateInventoryItem
	DuplicateInventoryItem: function(inventoryItem,sourceItemId,copyImages,token, server)
	{
		return Factory.GetResponse("Inventory/DuplicateInventoryItem", token, server, "inventoryItem=" + JSON.stringify(inventoryItem) + "&sourceItemId=" + sourceItemId + "&copyImages=" + copyImages +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetAllExtendedPropertyNames
	GetAllExtendedPropertyNames: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetAllExtendedPropertyNames", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetBatchAudit
	GetBatchAudit: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/GetBatchAudit", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetBatchesByStockItemId
	GetBatchesByStockItemId: function(stockItemId,onlyAvailable,token, server)
	{
		return Factory.GetResponse("Inventory/GetBatchesByStockItemId", token, server, "stockItemId=" + stockItemId + "&onlyAvailable=" + onlyAvailable +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetCategories
	GetCategories: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetCategories", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetChannels
	GetChannels: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetChannels", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetChannelsBySource
	GetChannelsBySource: function(source,token, server)
	{
		return Factory.GetResponse("Inventory/GetChannelsBySource", token, server, "source=" + source +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetCountries
	GetCountries: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetCountries", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetCountryCodes
	GetCountryCodes: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetCountryCodes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetEbayCompatibilityList
	GetEbayCompatibilityList: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetEbayCompatibilityList", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetExtendedPropertyNames
	GetExtendedPropertyNames: function(propertyType,token, server)
	{
		return Factory.GetResponse("Inventory/GetExtendedPropertyNames", token, server, "propertyType=" + propertyType +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetExtendedPropertyTypes
	GetExtendedPropertyTypes: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetExtendedPropertyTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryBatchTypes
	GetInventoryBatchTypes: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryBatchTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemAuditTrail
	GetInventoryItemAuditTrail: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemAuditTrail", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemBatchInformation
	GetInventoryItemBatchInformation: function(Request,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemBatchInformation", token, server, "Request=" + JSON.stringify(Request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemById
	GetInventoryItemById: function(id,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemById", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemChannelSKUs
	GetInventoryItemChannelSKUs: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemChannelSKUs", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemChannelSKUsWithLocation
	GetInventoryItemChannelSKUsWithLocation: function(channelSKURowId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemChannelSKUsWithLocation", token, server, "channelSKURowId=" + channelSKURowId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemCompositions
	GetInventoryItemCompositions: function(inventoryItemId,getFullDetail,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemCompositions", token, server, "inventoryItemId=" + inventoryItemId + "&getFullDetail=" + getFullDetail +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemDescriptions
	GetInventoryItemDescriptions: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemDescriptions", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemExtendedProperties
	GetInventoryItemExtendedProperties: function(inventoryItemId,propertyParams,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemExtendedProperties", token, server, "inventoryItemId=" + inventoryItemId + "&propertyParams=" + JSON.stringify(propertyParams) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemImages
	GetInventoryItemImages: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemImages", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemLocations
	GetInventoryItemLocations: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemLocations", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemPriceRulesById
	GetInventoryItemPriceRulesById: function(stockItemPriceId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemPriceRulesById", token, server, "stockItemPriceId=" + stockItemPriceId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemPriceRulesBySource
	GetInventoryItemPriceRulesBySource: function(stockItemId,source,subSource,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemPriceRulesBySource", token, server, "stockItemId=" + stockItemId + "&source=" + source + "&subSource=" + subSource +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemPrices
	GetInventoryItemPrices: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemPrices", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemsCount
	GetInventoryItemsCount: function(includeDeleted,includeArchived,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemsCount", token, server, "includeDeleted=" + JSON.stringify(includeDeleted) + "&includeArchived=" + JSON.stringify(includeArchived) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemTitles
	GetInventoryItemTitles: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemTitles", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetNewItemNumber
	GetNewItemNumber: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetNewItemNumber", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetPackageGroups
	GetPackageGroups: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetPackageGroups", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetPostalServices
	GetPostalServices: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetPostalServices", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetPreDefinedViews
	GetPreDefinedViews: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetPreDefinedViews", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetScrapCategories
	GetScrapCategories: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetScrapCategories", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetScrapHistory
	GetScrapHistory: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/GetScrapHistory", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetStockItemBatchesByLocation
	GetStockItemBatchesByLocation: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/GetStockItemBatchesByLocation", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetStockItemLabels
	GetStockItemLabels: function(selectedRegions,token,location,token, server)
	{
		return Factory.GetResponse("Inventory/GetStockItemLabels", token, server, "selectedRegions=" + JSON.stringify(selectedRegions) + "&token=" + token + "&location=" + location +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetStockLocations
	GetStockLocations: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetStockLocations", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetStockSupplierStat
	GetStockSupplierStat: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetStockSupplierStat", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetSupplierDetails
	GetSupplierDetails: function(supplierId,token, server)
	{
		return Factory.GetResponse("Inventory/GetSupplierDetails", token, server, "supplierId=" + supplierId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetSuppliers
	GetSuppliers: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetSuppliers", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetUserSpecificViews
	GetUserSpecificViews: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetUserSpecificViews", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-HasStockItemBatches
	HasStockItemBatches: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Inventory/HasStockItemBatches", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-HasStockItemStockLevel
	HasStockItemStockLevel: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/HasStockItemStockLevel", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-InsertUpdateEbayCompatibilityList
	InsertUpdateEbayCompatibilityList: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/InsertUpdateEbayCompatibilityList", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-IsInventoryItemChannelSKULinked
	IsInventoryItemChannelSKULinked: function(channelSKU,source,subSource,token, server)
	{
		return Factory.GetResponse("Inventory/IsInventoryItemChannelSKULinked", token, server, "channelSKU=" + channelSKU + "&source=" + source + "&subSource=" + subSource +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-IsOwnedStockLocation
	IsOwnedStockLocation: function(locationId,token, server)
	{
		return Factory.GetResponse("Inventory/IsOwnedStockLocation", token, server, "locationId=" + locationId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-ScrapBatchedItem
	ScrapBatchedItem: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/ScrapBatchedItem", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-SetInventoryItemImageAsMain
	SetInventoryItemImageAsMain: function(inventoryItemId,mainImageId,token, server)
	{
		return Factory.GetResponse("Inventory/SetInventoryItemImageAsMain", token, server, "inventoryItemId=" + inventoryItemId + "&mainImageId=" + mainImageId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UnarchiveInventoryItems
	UnarchiveInventoryItems: function(parameters,token, server)
	{
		return Factory.GetResponse("Inventory/UnarchiveInventoryItems", token, server, "parameters=" + JSON.stringify(parameters) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UnlinkChannelListing
	UnlinkChannelListing: function(channelRefId,source,subSource,token, server)
	{
		return Factory.GetResponse("Inventory/UnlinkChannelListing", token, server, "channelRefId=" + channelRefId + "&source=" + source + "&subSource=" + subSource +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateBatchDetails
	UpdateBatchDetails: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateBatchDetails", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateBatchesWithInventory
	UpdateBatchesWithInventory: function(batches,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateBatchesWithInventory", token, server, "batches=" + JSON.stringify(batches) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateCategory
	UpdateCategory: function(category,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateCategory", token, server, "category=" + JSON.stringify(category) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateCompositeParentStockLevel
	UpdateCompositeParentStockLevel: function(stockItemId,locationId,fieldValue,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateCompositeParentStockLevel", token, server, "stockItemId=" + stockItemId + "&locationId=" + locationId + "&fieldValue=" + fieldValue +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateCountries
	UpdateCountries: function(countries,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateCountries", token, server, "countries=" + JSON.stringify(countries) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateCountryRegions
	UpdateCountryRegions: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateCountryRegions", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateEbayCompatibilityList
	UpdateEbayCompatibilityList: function(ebayCompatibilityList,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateEbayCompatibilityList", token, server, "ebayCompatibilityList=" + JSON.stringify(ebayCompatibilityList) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateImages
	UpdateImages: function(images,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateImages", token, server, "images=" + JSON.stringify(images) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItem
	UpdateInventoryItem: function(inventoryItem,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItem", token, server, "inventoryItem=" + JSON.stringify(inventoryItem) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemChannelSKUs
	UpdateInventoryItemChannelSKUs: function(inventoryItemChannelSKUs,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemChannelSKUs", token, server, "inventoryItemChannelSKUs=" + JSON.stringify(inventoryItemChannelSKUs) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemChannelSKUsWithLocation
	UpdateInventoryItemChannelSKUsWithLocation: function(inventoryItemChannelSKUsWithLocation,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemChannelSKUsWithLocation", token, server, "inventoryItemChannelSKUsWithLocation=" + JSON.stringify(inventoryItemChannelSKUsWithLocation) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemCompositions
	UpdateInventoryItemCompositions: function(inventoryItemCompositions,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemCompositions", token, server, "inventoryItemCompositions=" + JSON.stringify(inventoryItemCompositions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemDescriptions
	UpdateInventoryItemDescriptions: function(inventoryItemDescriptions,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemDescriptions", token, server, "inventoryItemDescriptions=" + JSON.stringify(inventoryItemDescriptions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemExtendedProperties
	UpdateInventoryItemExtendedProperties: function(inventoryItemExtendedProperties,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemExtendedProperties", token, server, "inventoryItemExtendedProperties=" + JSON.stringify(inventoryItemExtendedProperties) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemField
	UpdateInventoryItemField: function(inventoryItemId,fieldName,fieldValue,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemField", token, server, "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemLevels
	UpdateInventoryItemLevels: function(inventoryItemId,fieldName,fieldValue,locationId,changeSource,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemLevels", token, server, "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "&changeSource=" + changeSource +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemLocationField
	UpdateInventoryItemLocationField: function(inventoryItemId,fieldName,fieldValue,locationId,changeSource,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemLocationField", token, server, "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "&changeSource=" + changeSource +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemPrices
	UpdateInventoryItemPrices: function(inventoryItemPrices,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemPrices", token, server, "inventoryItemPrices=" + JSON.stringify(inventoryItemPrices) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemPricingRules
	UpdateInventoryItemPricingRules: function(rules,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemPricingRules", token, server, "rules=" + JSON.stringify(rules) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemStockField
	UpdateInventoryItemStockField: function(inventoryItemId,fieldName,fieldValue,locationId,changeSource,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemStockField", token, server, "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "&changeSource=" + changeSource +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemTitles
	UpdateInventoryItemTitles: function(inventoryItemTitles,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemTitles", token, server, "inventoryItemTitles=" + JSON.stringify(inventoryItemTitles) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateItemLocations
	UpdateItemLocations: function(itemLocations,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateItemLocations", token, server, "itemLocations=" + JSON.stringify(itemLocations) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateScrapCategories
	UpdateScrapCategories: function(request,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateScrapCategories", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateStockSupplierStat
	UpdateStockSupplierStat: function(itemSuppliers,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateStockSupplierStat", token, server, "itemSuppliers=" + JSON.stringify(itemSuppliers) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateSupplier
	UpdateSupplier: function(supplier,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateSupplier", token, server, "supplier=" + JSON.stringify(supplier) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateUserSpecificView
	UpdateUserSpecificView: function(viewName,view,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateUserSpecificView", token, server, "viewName=" + viewName + "&view=" + JSON.stringify(view) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UploadImagesToInventoryItem
	UploadImagesToInventoryItem: function(inventoryItemId,imageIds,token, server)
	{
		return Factory.GetResponse("Inventory/UploadImagesToInventoryItem", token, server, "inventoryItemId=" + inventoryItemId + "&imageIds=" + JSON.stringify(imageIds) +"");
	},
};
