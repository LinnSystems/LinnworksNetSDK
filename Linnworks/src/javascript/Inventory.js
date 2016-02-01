var Inventory =
{
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemPrices
	CreateInventoryItemPrices: function(inventoryItemPrices,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemPrices", token, server, "inventoryItemPrices=" + JSON.stringify(inventoryItemPrices) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemPrices
	UpdateInventoryItemPrices: function(inventoryItemPrices,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemPrices", token, server, "inventoryItemPrices=" + JSON.stringify(inventoryItemPrices) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemPrices
	DeleteInventoryItemPrices: function(inventoryItemPriceIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemPrices", token, server, "inventoryItemPriceIds=" + JSON.stringify(inventoryItemPriceIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemDescriptions
	GetInventoryItemDescriptions: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemDescriptions", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemDescriptions
	CreateInventoryItemDescriptions: function(inventoryItemDescriptions,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemDescriptions", token, server, "inventoryItemDescriptions=" + JSON.stringify(inventoryItemDescriptions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemDescriptions
	UpdateInventoryItemDescriptions: function(inventoryItemDescriptions,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemDescriptions", token, server, "inventoryItemDescriptions=" + JSON.stringify(inventoryItemDescriptions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemDescriptions
	DeleteInventoryItemDescriptions: function(inventoryItemDescriptionIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemDescriptions", token, server, "inventoryItemDescriptionIds=" + JSON.stringify(inventoryItemDescriptionIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetChannels
	GetChannels: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetChannels", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetExtendedPropertyNames
	GetExtendedPropertyNames: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetExtendedPropertyNames", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetExtendedPropertyTypes
	GetExtendedPropertyTypes: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetExtendedPropertyTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetSystemPropertyNames
	GetSystemPropertyNames: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetSystemPropertyNames", token, server, "");
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
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItems
	GetInventoryItems: function(view,stockLocationIds,startIndex,itemsCount,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItems", token, server, "view=" + JSON.stringify(view) + "&stockLocationIds=" + JSON.stringify(stockLocationIds) + "&startIndex=" + startIndex + "&itemsCount=" + itemsCount +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemField
	UpdateInventoryItemField: function(inventoryItemId,fieldName,fieldValue,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemField", token, server, "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemStockField
	UpdateInventoryItemStockField: function(inventoryItemId,fieldName,fieldValue,locationId,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemStockField", token, server, "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemLocationField
	UpdateInventoryItemLocationField: function(inventoryItemId,fieldName,fieldValue,locationId,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemLocationField", token, server, "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemById
	GetInventoryItemById: function(id,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemById", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryViews
	GetInventoryViews: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryViews", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryFilterTypes
	GetInventoryFilterTypes: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryFilterTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryColumnTypes
	GetInventoryColumnTypes: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryColumnTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetNewInventoryView
	GetNewInventoryView: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetNewInventoryView", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryViews
	UpdateInventoryViews: function(views,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryViews", token, server, "views=" + JSON.stringify(views) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AddInventoryItem
	AddInventoryItem: function(inventoryItem,token, server)
	{
		return Factory.GetResponse("Inventory/AddInventoryItem", token, server, "inventoryItem=" + JSON.stringify(inventoryItem) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DuplicateInventoryItem
	DuplicateInventoryItem: function(inventoryItem,sourceItemId,token, server)
	{
		return Factory.GetResponse("Inventory/DuplicateInventoryItem", token, server, "inventoryItem=" + JSON.stringify(inventoryItem) + "&sourceItemId=" + sourceItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetNewItemNumber
	GetNewItemNumber: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetNewItemNumber", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItem
	UpdateInventoryItem: function(inventoryItem,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItem", token, server, "inventoryItem=" + JSON.stringify(inventoryItem) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItems
	DeleteInventoryItems: function(inventoryItemIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItems", token, server, "inventoryItemIds=" + JSON.stringify(inventoryItemIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AdjustTemplatesInstant
	AdjustTemplatesInstant: function(inventoryItemIds,source,subSource,adjustmentOptions,token, server)
	{
		return Factory.GetResponse("Inventory/AdjustTemplatesInstant", token, server, "inventoryItemIds=" + JSON.stringify(inventoryItemIds) + "&source=" + source + "&subSource=" + subSource + "&adjustmentOptions=" + JSON.stringify(adjustmentOptions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemChannelSKUs
	GetInventoryItemChannelSKUs: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemChannelSKUs", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemChannelSKUs
	CreateInventoryItemChannelSKUs: function(inventoryItemChannelSKUs,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemChannelSKUs", token, server, "inventoryItemChannelSKUs=" + JSON.stringify(inventoryItemChannelSKUs) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemChannelSKUs
	DeleteInventoryItemChannelSKUs: function(inventoryItemChannelSKUIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemChannelSKUs", token, server, "inventoryItemChannelSKUIds=" + JSON.stringify(inventoryItemChannelSKUIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UnlinkChannelListing
	UnlinkChannelListing: function(channelRefId,source,subSource,token, server)
	{
		return Factory.GetResponse("Inventory/UnlinkChannelListing", token, server, "channelRefId=" + channelRefId + "&source=" + source + "&subSource=" + subSource +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemAuditTrail
	GetInventoryItemAuditTrail: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemAuditTrail", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemImages
	GetInventoryItemImages: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemImages", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemImagesForTemplates
	GetInventoryItemImagesForTemplates: function(inventoryItemIds,source,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemImagesForTemplates", token, server, "inventoryItemIds=" + JSON.stringify(inventoryItemIds) + "&source=" + source +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-SetInventoryItemImageAsMain
	SetInventoryItemImageAsMain: function(inventoryItemId,mainImageId,token, server)
	{
		return Factory.GetResponse("Inventory/SetInventoryItemImageAsMain", token, server, "inventoryItemId=" + inventoryItemId + "&mainImageId=" + mainImageId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UploadImagesToInventoryItem
	UploadImagesToInventoryItem: function(inventoryItemId,imageIds,token, server)
	{
		return Factory.GetResponse("Inventory/UploadImagesToInventoryItem", token, server, "inventoryItemId=" + inventoryItemId + "&imageIds=" + JSON.stringify(imageIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteImagesFromInventoryItem
	DeleteImagesFromInventoryItem: function(imageURL,inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteImagesFromInventoryItem", token, server, "imageURL=" + imageURL + "&inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetCategories
	GetCategories: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetCategories", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateCategory
	CreateCategory: function(categoryName,token, server)
	{
		return Factory.GetResponse("Inventory/CreateCategory", token, server, "categoryName=" + categoryName +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateCategory
	UpdateCategory: function(category,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateCategory", token, server, "category=" + JSON.stringify(category) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteCategoryById
	DeleteCategoryById: function(categoryId,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteCategoryById", token, server, "categoryId=" + categoryId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetCountryCodes
	GetCountryCodes: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetCountryCodes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetCountries
	GetCountries: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetCountries", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateCountries
	CreateCountries: function(countries,token, server)
	{
		return Factory.GetResponse("Inventory/CreateCountries", token, server, "countries=" + JSON.stringify(countries) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateCountries
	UpdateCountries: function(countries,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateCountries", token, server, "countries=" + JSON.stringify(countries) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteCountries
	DeleteCountries: function(countries,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteCountries", token, server, "countries=" + JSON.stringify(countries) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetStockLocations
	GetStockLocations: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetStockLocations", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemLocations
	GetInventoryItemLocations: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemLocations", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-AddItemLocations
	AddItemLocations: function(itemLocations,token, server)
	{
		return Factory.GetResponse("Inventory/AddItemLocations", token, server, "itemLocations=" + JSON.stringify(itemLocations) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateItemLocations
	UpdateItemLocations: function(itemLocations,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateItemLocations", token, server, "itemLocations=" + JSON.stringify(itemLocations) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteItemLocations
	DeleteItemLocations: function(inventoryItemId,itemLocations,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteItemLocations", token, server, "inventoryItemId=" + inventoryItemId + "&itemLocations=" + JSON.stringify(itemLocations) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemCompositions
	GetInventoryItemCompositions: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemCompositions", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemCompositions
	CreateInventoryItemCompositions: function(inventoryItemCompositions,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemCompositions", token, server, "inventoryItemCompositions=" + JSON.stringify(inventoryItemCompositions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemCompositions
	UpdateInventoryItemCompositions: function(inventoryItemCompositions,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemCompositions", token, server, "inventoryItemCompositions=" + JSON.stringify(inventoryItemCompositions) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemCompositions
	DeleteInventoryItemCompositions: function(stockItemId,inventoryItemCompositionIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemCompositions", token, server, "stockItemId=" + stockItemId + "&inventoryItemCompositionIds=" + JSON.stringify(inventoryItemCompositionIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemExtendedProperties
	GetInventoryItemExtendedProperties: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemExtendedProperties", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemExtendedProperties
	CreateInventoryItemExtendedProperties: function(inventoryItemExtendedProperties,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemExtendedProperties", token, server, "inventoryItemExtendedProperties=" + JSON.stringify(inventoryItemExtendedProperties) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemExtendedProperties
	UpdateInventoryItemExtendedProperties: function(inventoryItemExtendedProperties,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemExtendedProperties", token, server, "inventoryItemExtendedProperties=" + JSON.stringify(inventoryItemExtendedProperties) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemExtendedProperties
	DeleteInventoryItemExtendedProperties: function(inventoryItemId,inventoryItemExtendedPropertyIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemExtendedProperties", token, server, "inventoryItemId=" + inventoryItemId + "&inventoryItemExtendedPropertyIds=" + JSON.stringify(inventoryItemExtendedPropertyIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemTitles
	GetInventoryItemTitles: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemTitles", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateInventoryItemTitles
	CreateInventoryItemTitles: function(inventoryItemTitles,token, server)
	{
		return Factory.GetResponse("Inventory/CreateInventoryItemTitles", token, server, "inventoryItemTitles=" + JSON.stringify(inventoryItemTitles) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateInventoryItemTitles
	UpdateInventoryItemTitles: function(inventoryItemTitles,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateInventoryItemTitles", token, server, "inventoryItemTitles=" + JSON.stringify(inventoryItemTitles) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteInventoryItemTitles
	DeleteInventoryItemTitles: function(inventoryItemTitleIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteInventoryItemTitles", token, server, "inventoryItemTitleIds=" + JSON.stringify(inventoryItemTitleIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetSupplierList
	GetSupplierList: function(token, server)
	{
		return Factory.GetResponse("Inventory/GetSupplierList", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetStockSupplierStat
	GetStockSupplierStat: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetStockSupplierStat", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-CreateStockSupplierStat
	CreateStockSupplierStat: function(itemSuppliers,token, server)
	{
		return Factory.GetResponse("Inventory/CreateStockSupplierStat", token, server, "itemSuppliers=" + JSON.stringify(itemSuppliers) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-UpdateStockSupplierStat
	UpdateStockSupplierStat: function(itemSuppliers,token, server)
	{
		return Factory.GetResponse("Inventory/UpdateStockSupplierStat", token, server, "itemSuppliers=" + JSON.stringify(itemSuppliers) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-DeleteStockSupplierStat
	DeleteStockSupplierStat: function(stockItemId,itemSupplierIds,token, server)
	{
		return Factory.GetResponse("Inventory/DeleteStockSupplierStat", token, server, "stockItemId=" + stockItemId + "&itemSupplierIds=" + JSON.stringify(itemSupplierIds) +"");
	},
	// http://apidoc.linnworks.net/#/Inventory-GetInventoryItemPrices
	GetInventoryItemPrices: function(inventoryItemId,token, server)
	{
		return Factory.GetResponse("Inventory/GetInventoryItemPrices", token, server, "inventoryItemId=" + inventoryItemId +"");
	},
};
