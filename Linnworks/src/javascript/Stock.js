var Stock =
{
	// http://apidoc.linnworks.net/#/Stock-AddVariationItems
	AddVariationItems: function(pkVariationItemId,pkStockItemIds,token, server)
	{
		return Factory.GetResponse("Stock/AddVariationItems", token, server, "pkVariationItemId=" + pkVariationItemId + "&pkStockItemIds=" + JSON.stringify(pkStockItemIds) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-BookInStockBatch
	BookInStockBatch: function(stockItem,token, server)
	{
		return Factory.GetResponse("Stock/BookInStockBatch", token, server, "stockItem=" + JSON.stringify(stockItem) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-BookInStockItem
	BookInStockItem: function(stockItem,token, server)
	{
		return Factory.GetResponse("Stock/BookInStockItem", token, server, "stockItem=" + JSON.stringify(stockItem) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-CheckVariationParentSKUExists
	CheckVariationParentSKUExists: function(parentSKU,token, server)
	{
		return Factory.GetResponse("Stock/CheckVariationParentSKUExists", token, server, "parentSKU=" + parentSKU +"");
	},
	// http://apidoc.linnworks.net/#/Stock-CreateStockBatches
	CreateStockBatches: function(batches,token, server)
	{
		return Factory.GetResponse("Stock/CreateStockBatches", token, server, "batches=" + JSON.stringify(batches) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-CreateVariationGroup
	CreateVariationGroup: function(template,token, server)
	{
		return Factory.GetResponse("Stock/CreateVariationGroup", token, server, "template=" + JSON.stringify(template) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-DeleteVariationGroup
	DeleteVariationGroup: function(pkVariationGroupId,token, server)
	{
		return Factory.GetResponse("Stock/DeleteVariationGroup", token, server, "pkVariationGroupId=" + pkVariationGroupId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-DeleteVariationItem
	DeleteVariationItem: function(pkVariationItemId,pkStockItemId,token, server)
	{
		return Factory.GetResponse("Stock/DeleteVariationItem", token, server, "pkVariationItemId=" + pkVariationItemId + "&pkStockItemId=" + pkStockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetItemChangesHistory
	GetItemChangesHistory: function(stockItemId,locationId,entriesPerPage,pageNumber,token, server)
	{
		return Factory.GetResponse("Stock/GetItemChangesHistory", token, server, "stockItemId=" + stockItemId + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetItemChangesHistoryCSV
	GetItemChangesHistoryCSV: function(stockItemId,locationId,token, server)
	{
		return Factory.GetResponse("Stock/GetItemChangesHistoryCSV", token, server, "stockItemId=" + stockItemId + "&locationId=" + locationId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetSoldStat
	GetSoldStat: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetSoldStat", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockConsumption
	GetStockConsumption: function(stockItemId,locationId,startDate,endDate,token, server)
	{
		return Factory.GetResponse("Stock/GetStockConsumption", token, server, "stockItemId=" + stockItemId + "&locationId=" + JSON.stringify(locationId) + "&startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockDuePO
	GetStockDuePO: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetStockDuePO", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockItemReturnStat
	GetStockItemReturnStat: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetStockItemReturnStat", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockItems
	GetStockItems: function(keyWord,locationId,entriesPerPage,pageNumber,excludeComposites,excludeVariations,excludeBatches,token, server)
	{
		return Factory.GetResponse("Stock/GetStockItems", token, server, "keyWord=" + keyWord + "&locationId=" + JSON.stringify(locationId) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&excludeComposites=" + excludeComposites + "&excludeVariations=" + excludeVariations + "&excludeBatches=" + excludeBatches +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockItemsByKey
	GetStockItemsByKey: function(stockIdentifier,token, server)
	{
		return Factory.GetResponse("Stock/GetStockItemsByKey", token, server, "stockIdentifier=" + JSON.stringify(stockIdentifier) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockItemScrapStat
	GetStockItemScrapStat: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetStockItemScrapStat", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockItemsFull
	GetStockItemsFull: function(keyword,loadCompositeParents,loadVariationParents,entriesPerPage,pageNumber,dataRequirements,searchTypes,token, server)
	{
		return Factory.GetResponse("Stock/GetStockItemsFull", token, server, "keyword=" + keyword + "&loadCompositeParents=" + loadCompositeParents + "&loadVariationParents=" + loadVariationParents + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&dataRequirements=" + JSON.stringify(dataRequirements) + "&searchTypes=" + JSON.stringify(searchTypes) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockLevel
	GetStockLevel: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetStockLevel", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockSold
	GetStockSold: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetStockSold", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetVariationGroupByName
	GetVariationGroupByName: function(variationName,token, server)
	{
		return Factory.GetResponse("Stock/GetVariationGroupByName", token, server, "variationName=" + variationName +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetVariationGroupByParentId
	GetVariationGroupByParentId: function(pkStockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetVariationGroupByParentId", token, server, "pkStockItemId=" + pkStockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetVariationGroupSearchTypes
	GetVariationGroupSearchTypes: function(token, server)
	{
		return Factory.GetResponse("Stock/GetVariationGroupSearchTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Stock-GetVariationItems
	GetVariationItems: function(pkVariationItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetVariationItems", token, server, "pkVariationItemId=" + pkVariationItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-RenameVariationGroup
	RenameVariationGroup: function(pkVariationItemId,variationName,token, server)
	{
		return Factory.GetResponse("Stock/RenameVariationGroup", token, server, "pkVariationItemId=" + pkVariationItemId + "&variationName=" + variationName +"");
	},
	// http://apidoc.linnworks.net/#/Stock-SearchVariationGroups
	SearchVariationGroups: function(searchType,searchText,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("Stock/SearchVariationGroups", token, server, "searchType=" + searchType + "&searchText=" + searchText + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/Stock-SetStockLevel
	SetStockLevel: function(stockLevels,changeSource,token, server)
	{
		return Factory.GetResponse("Stock/SetStockLevel", token, server, "stockLevels=" + JSON.stringify(stockLevels) + "&changeSource=" + changeSource +"");
	},
	// http://apidoc.linnworks.net/#/Stock-SKUExists
	SKUExists: function(SKU,token, server)
	{
		return Factory.GetResponse("Stock/SKUExists", token, server, "SKU=" + SKU +"");
	},
	// http://apidoc.linnworks.net/#/Stock-Update_StockItemPartial
	Update_StockItemPartial: function(update,token, server)
	{
		return Factory.GetResponse("Stock/Update_StockItemPartial", token, server, "update=" + JSON.stringify(update) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-UpdateStockLevelsBySKU
	UpdateStockLevelsBySKU: function(stockLevels,changeSource,token, server)
	{
		return Factory.GetResponse("Stock/UpdateStockLevelsBySKU", token, server, "stockLevels=" + JSON.stringify(stockLevels) + "&changeSource=" + changeSource +"");
	},
	// http://apidoc.linnworks.net/#/Stock-UpdateStockMinimumLevel
	UpdateStockMinimumLevel: function(stockItemId,locationId,minimumLevel,token, server)
	{
		return Factory.GetResponse("Stock/UpdateStockMinimumLevel", token, server, "stockItemId=" + stockItemId + "&locationId=" + locationId + "&minimumLevel=" + minimumLevel +"");
	},
};
