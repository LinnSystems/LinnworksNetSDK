var Dashboards =
{
	// http://apidoc.linnworks.net/#/Dashboards-ExecuteCustomPagedScript
	ExecuteCustomPagedScript: function(scriptId,parameters,entriesPerPage,pageNumber,token, server)
	{
		return Factory.GetResponse("Dashboards/ExecuteCustomPagedScript", token, server, "scriptId=" + scriptId + "&parameters=" + JSON.stringify(parameters) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber +"");
	},
	// http://apidoc.linnworks.net/#/Dashboards-ExecuteCustomScriptQuery
	ExecuteCustomScriptQuery: function(script,token, server)
	{
		return Factory.GetResponse("Dashboards/ExecuteCustomScriptQuery", token, server, "script=" + script +"");
	},
	// http://apidoc.linnworks.net/#/Dashboards-GetInventoryLocationCategoriesData
	GetInventoryLocationCategoriesData: function(date,locationId,token, server)
	{
		return Factory.GetResponse("Dashboards/GetInventoryLocationCategoriesData", token, server, "date=" + JSON.stringify(date) + "&locationId=" + locationId +"");
	},
	// http://apidoc.linnworks.net/#/Dashboards-GetInventoryLocationData
	GetInventoryLocationData: function(date,token, server)
	{
		return Factory.GetResponse("Dashboards/GetInventoryLocationData", token, server, "date=" + JSON.stringify(date) +"");
	},
	// http://apidoc.linnworks.net/#/Dashboards-GetInventoryLocationProductsData
	GetInventoryLocationProductsData: function(date,locationId,categoryId,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("Dashboards/GetInventoryLocationProductsData", token, server, "date=" + JSON.stringify(date) + "&locationId=" + locationId + "&categoryId=" + categoryId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/Dashboards-GetLowStockLevel
	GetLowStockLevel: function(locationId,numRows,token, server)
	{
		return Factory.GetResponse("Dashboards/GetLowStockLevel", token, server, "locationId=" + JSON.stringify(locationId) + "&numRows=" + JSON.stringify(numRows) +"");
	},
	// http://apidoc.linnworks.net/#/Dashboards-GetPerformanceDetail
	GetPerformanceDetail: function(period,timeScale,token, server)
	{
		return Factory.GetResponse("Dashboards/GetPerformanceDetail", token, server, "period=" + period + "&timeScale=" + timeScale +"");
	},
	// http://apidoc.linnworks.net/#/Dashboards-GetPerformanceTableData
	GetPerformanceTableData: function(period,token, server)
	{
		return Factory.GetResponse("Dashboards/GetPerformanceTableData", token, server, "period=" + period +"");
	},
	// http://apidoc.linnworks.net/#/Dashboards-GetTopProducts
	GetTopProducts: function(type,period,numRows,orderStatus,token, server)
	{
		return Factory.GetResponse("Dashboards/GetTopProducts", token, server, "type=" + type + "&period=" + period + "&numRows=" + numRows + "&orderStatus=" + orderStatus +"");
	},
};
