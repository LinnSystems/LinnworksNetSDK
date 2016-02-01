var Stock =
{
	// http://apidoc.linnworks.net/#/Stock-CheckVariationParentSKUExists
	CheckVariationParentSKUExists: function(parentSKU,token, server)
	{
		return Factory.GetResponse("Stock/CheckVariationParentSKUExists", token, server, "parentSKU=" + parentSKU +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetVariationGroupSearchTypes
	GetVariationGroupSearchTypes: function(token, server)
	{
		return Factory.GetResponse("Stock/GetVariationGroupSearchTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Stock-SearchVariationGroups
	SearchVariationGroups: function(searchType,searchText,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("Stock/SearchVariationGroups", token, server, "searchType=" + JSON.stringify(searchType) + "&searchText=" + searchText + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/Stock-DeleteVariationGroup
	DeleteVariationGroup: function(pkVariationGroupId,token, server)
	{
		return Factory.GetResponse("Stock/DeleteVariationGroup", token, server, "pkVariationGroupId=" + pkVariationGroupId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetVariationGroupByParentId
	GetVariationGroupByParentId: function(pkStockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetVariationGroupByParentId", token, server, "pkStockItemId=" + pkStockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetVariationGroupByName
	GetVariationGroupByName: function(variationName,token, server)
	{
		return Factory.GetResponse("Stock/GetVariationGroupByName", token, server, "variationName=" + variationName +"");
	},
	// http://apidoc.linnworks.net/#/Stock-RenameVariationGroup
	RenameVariationGroup: function(pkVariationItemId,variationName,token, server)
	{
		return Factory.GetResponse("Stock/RenameVariationGroup", token, server, "pkVariationItemId=" + pkVariationItemId + "&variationName=" + variationName +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetVariationItems
	GetVariationItems: function(pkVariationItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetVariationItems", token, server, "pkVariationItemId=" + pkVariationItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-AddVariationItems
	AddVariationItems: function(pkVariationItemId,pkStockItemIds,token, server)
	{
		return Factory.GetResponse("Stock/AddVariationItems", token, server, "pkVariationItemId=" + pkVariationItemId + "&pkStockItemIds=" + JSON.stringify(pkStockItemIds) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-DeleteVariationItem
	DeleteVariationItem: function(pkVariationItemId,pkStockItemId,token, server)
	{
		return Factory.GetResponse("Stock/DeleteVariationItem", token, server, "pkVariationItemId=" + pkVariationItemId + "&pkStockItemId=" + pkStockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-FindInstantNewParentSKU
	FindInstantNewParentSKU: function(keyWord,token, server)
	{
		return Factory.GetResponse("Stock/FindInstantNewParentSKU", token, server, "keyWord=" + keyWord +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetNewParentSKUs
	GetNewParentSKUs: function(keyWord,entriesPerPage,pageNumber,token, server)
	{
		return Factory.GetResponse("Stock/GetNewParentSKUs", token, server, "keyWord=" + keyWord + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber +"");
	},
	// http://apidoc.linnworks.net/#/Stock-CreateVariationGroup
	CreateVariationGroup: function(template,token, server)
	{
		return Factory.GetResponse("Stock/CreateVariationGroup", token, server, "template=" + JSON.stringify(template) +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetSystemWeightMeasure
	GetSystemWeightMeasure: function(token, server)
	{
		return Factory.GetResponse("Stock/GetSystemWeightMeasure", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Stock-GetWeightMeasures
	GetWeightMeasures: function(token, server)
	{
		return Factory.GetResponse("Stock/GetWeightMeasures", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Stock-GetNewSKU
	GetNewSKU: function(token, server)
	{
		return Factory.GetResponse("Stock/GetNewSKU", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Stock-SKUExists
	SKUExists: function(SKU,token, server)
	{
		return Factory.GetResponse("Stock/SKUExists", token, server, "SKU=" + SKU +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetStockConsumption
	GetStockConsumption: function(stockItemId,locationId,startDate,endDate,token, server)
	{
		return Factory.GetResponse("Stock/GetStockConsumption", token, server, "stockItemId=" + stockItemId + "&locationId=" + locationId + "&startDate=" + JSON.stringify(startDate) + "&endDate=" + JSON.stringify(endDate) +"");
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
	// http://apidoc.linnworks.net/#/Stock-GetStockItems
	GetStockItems: function(keyWord,locationId,entriesPerPage,pageNumber,excludeComposites,token, server)
	{
		return Factory.GetResponse("Stock/GetStockItems", token, server, "keyWord=" + keyWord + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&excludeComposites=" + excludeComposites +"");
	},
	// http://apidoc.linnworks.net/#/Stock-FindInstantStockItems
	FindInstantStockItems: function(keyWord,locationId,excludeComposites,token, server)
	{
		return Factory.GetResponse("Stock/FindInstantStockItems", token, server, "keyWord=" + keyWord + "&locationId=" + locationId + "&excludeComposites=" + excludeComposites +"");
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
	// http://apidoc.linnworks.net/#/Stock-GetStockItemScrapStat
	GetStockItemScrapStat: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetStockItemScrapStat", token, server, "stockItemId=" + stockItemId +"");
	},
	// http://apidoc.linnworks.net/#/Stock-GetSoldStat
	GetSoldStat: function(stockItemId,token, server)
	{
		return Factory.GetResponse("Stock/GetSoldStat", token, server, "stockItemId=" + stockItemId +"");
	},
};
