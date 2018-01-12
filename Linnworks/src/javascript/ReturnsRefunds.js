var ReturnsRefunds =
{
	// http://apidoc.linnworks.net/#/ReturnsRefunds-ActionBookedOrder
	ActionBookedOrder: function(pkOrderId,bookedItems,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/ActionBookedOrder", token, server, "pkOrderId=" + pkOrderId + "&bookedItems=" + JSON.stringify(bookedItems) +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-CreateReturnsRefundsCSV
	CreateReturnsRefundsCSV: function(from,to,dateType,searchField,exactMatch,searchTerm,sortColumn,sortDirection,historyType,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/CreateReturnsRefundsCSV", token, server, "from=" + JSON.stringify(from) + "&to=" + JSON.stringify(to) + "&dateType=" + dateType + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&sortColumn=" + sortColumn + "&sortDirection=" + sortDirection + "&historyType=" + historyType +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-DeleteBookedItem
	DeleteBookedItem: function(pkOrderId,pkReturnId,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/DeleteBookedItem", token, server, "pkOrderId=" + pkOrderId + "&pkReturnId=" + pkReturnId +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-DeleteBookedOrder
	DeleteBookedOrder: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/DeleteBookedOrder", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-DeletePendingRefundItem
	DeletePendingRefundItem: function(fkOrderId,pkRefundRowId,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/DeletePendingRefundItem", token, server, "fkOrderId=" + fkOrderId + "&pkRefundRowId=" + pkRefundRowId +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-EditBookedItemInfo
	EditBookedItemInfo: function(pkOrderId,bookedReturnsExchangeItem,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/EditBookedItemInfo", token, server, "pkOrderId=" + pkOrderId + "&bookedReturnsExchangeItem=" + JSON.stringify(bookedReturnsExchangeItem) +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-GetBookedReturnsExchangeItems
	GetBookedReturnsExchangeItems: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/GetBookedReturnsExchangeItems", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-GetBookedReturnsExchangeOrders
	GetBookedReturnsExchangeOrders: function(token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/GetBookedReturnsExchangeOrders", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-GetRefundOrders
	GetRefundOrders: function(token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/GetRefundOrders", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-GetRefunds
	GetRefunds: function(pkOrderId,refundReference,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/GetRefunds", token, server, "pkOrderId=" + pkOrderId + "&refundReference=" + JSON.stringify(refundReference) +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-GetSearchTypes
	GetSearchTypes: function(historyType,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/GetSearchTypes", token, server, "historyType=" + historyType +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-GetTotalRefunds
	GetTotalRefunds: function(fkOrderId,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/GetTotalRefunds", token, server, "fkOrderId=" + fkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-GetWarehouseLocations
	GetWarehouseLocations: function(token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/GetWarehouseLocations", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-RefundOrder
	RefundOrder: function(pkOrderId,refundReference,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/RefundOrder", token, server, "pkOrderId=" + pkOrderId + "&refundReference=" + JSON.stringify(refundReference) +"");
	},
	// http://apidoc.linnworks.net/#/ReturnsRefunds-SearchReturnsRefundsPaged
	SearchReturnsRefundsPaged: function(from,to,dateType,searchField,exactMatch,searchTerm,pageNum,numEntriesPerPage,historyType,token, server)
	{
		return Factory.GetResponse("ReturnsRefunds/SearchReturnsRefundsPaged", token, server, "from=" + JSON.stringify(from) + "&to=" + JSON.stringify(to) + "&dateType=" + dateType + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage + "&historyType=" + historyType +"");
	},
};
