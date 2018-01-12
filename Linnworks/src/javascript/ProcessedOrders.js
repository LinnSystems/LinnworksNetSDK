var ProcessedOrders =
{
	// http://apidoc.linnworks.net/#/ProcessedOrders-AddOrderNote
	AddOrderNote: function(pkOrderID,noteText,isInternal,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/AddOrderNote", token, server, "pkOrderID=" + pkOrderID + "&noteText=" + noteText + "&isInternal=" + isInternal +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-AddReturnCategory
	AddReturnCategory: function(categoryName,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/AddReturnCategory", token, server, "categoryName=" + categoryName +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-ChangeOrderNote
	ChangeOrderNote: function(pkOrderNoteId,noteText,isInternal,noteTypeId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/ChangeOrderNote", token, server, "pkOrderNoteId=" + pkOrderNoteId + "&noteText=" + noteText + "&isInternal=" + isInternal + "&noteTypeId=" + JSON.stringify(noteTypeId) +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-CheckOrderFullyReturned
	CheckOrderFullyReturned: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/CheckOrderFullyReturned", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-CreateExchange
	CreateExchange: function(pkOrderId,exchangeItems,despatchLocation,returnLocation,channelReason,channelSubReason,category,reason,isBooking,ignoredValidation,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/CreateExchange", token, server, "pkOrderId=" + pkOrderId + "&exchangeItems=" + JSON.stringify(exchangeItems) + "&despatchLocation=" + despatchLocation + "&returnLocation=" + returnLocation + "&channelReason=" + channelReason + "&channelSubReason=" + channelSubReason + "&category=" + category + "&reason=" + reason + "&isBooking=" + isBooking + "&ignoredValidation=" + ignoredValidation +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-CreateFullResend
	CreateFullResend: function(pkOrderId,despatchLocation,category,reason,additionalCost,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/CreateFullResend", token, server, "pkOrderId=" + pkOrderId + "&despatchLocation=" + despatchLocation + "&category=" + category + "&reason=" + reason + "&additionalCost=" + additionalCost +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-CreateProcessedOrdersCSV
	CreateProcessedOrdersCSV: function(from,to,dateType,searchField,exactMatch,searchTerm,sortColumn,sortDirection,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/CreateProcessedOrdersCSV", token, server, "from=" + JSON.stringify(from) + "&to=" + JSON.stringify(to) + "&dateType=" + dateType + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&sortColumn=" + sortColumn + "&sortDirection=" + sortDirection +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-CreateResend
	CreateResend: function(pkOrderId,resendItems,despatchLocation,category,reason,additionalCost,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/CreateResend", token, server, "pkOrderId=" + pkOrderId + "&resendItems=" + JSON.stringify(resendItems) + "&despatchLocation=" + despatchLocation + "&category=" + category + "&reason=" + reason + "&additionalCost=" + additionalCost +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-CreateReturn
	CreateReturn: function(pkOrderId,returnitems,returnLocation,channelReason,channelSubReason,category,reason,isReturnBooking,ignoredValidation,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/CreateReturn", token, server, "pkOrderId=" + pkOrderId + "&returnitems=" + JSON.stringify(returnitems) + "&returnLocation=" + returnLocation + "&channelReason=" + channelReason + "&channelSubReason=" + channelSubReason + "&category=" + category + "&reason=" + reason + "&isReturnBooking=" + isReturnBooking + "&ignoredValidation=" + ignoredValidation +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-DeleteOrderNote
	DeleteOrderNote: function(pkOrderNoteId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/DeleteOrderNote", token, server, "pkOrderNoteId=" + pkOrderNoteId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-DeleteReturnCategory
	DeleteReturnCategory: function(pkItemId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/DeleteReturnCategory", token, server, "pkItemId=" + pkItemId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetChannelRefundReasons
	GetChannelRefundReasons: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetChannelRefundReasons", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetOrderInfo
	GetOrderInfo: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetOrderInfo", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetPackageSplit
	GetPackageSplit: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetPackageSplit", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetProcessedAuditTrail
	GetProcessedAuditTrail: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetProcessedAuditTrail", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetProcessedOrderExtendedProperties
	GetProcessedOrderExtendedProperties: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetProcessedOrderExtendedProperties", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetProcessedOrderNotes
	GetProcessedOrderNotes: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetProcessedOrderNotes", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetProcessedRelatives
	GetProcessedRelatives: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetProcessedRelatives", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetRefundableServiceItems
	GetRefundableServiceItems: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetRefundableServiceItems", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetRefunds
	GetRefunds: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetRefunds", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetRefundsOptions
	GetRefundsOptions: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetRefundsOptions", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetReturnCategories
	GetReturnCategories: function(token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetReturnCategories", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetReturnItemsInfo
	GetReturnItemsInfo: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetReturnItemsInfo", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetReturnOrderInfo
	GetReturnOrderInfo: function(pkOrderId,includeRefundLink,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetReturnOrderInfo", token, server, "pkOrderId=" + pkOrderId + "&includeRefundLink=" + includeRefundLink +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetReturnsExchanges
	GetReturnsExchanges: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetReturnsExchanges", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-GetTotalRefunds
	GetTotalRefunds: function(pkOrderId,includeBookings,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/GetTotalRefunds", token, server, "pkOrderId=" + pkOrderId + "&includeBookings=" + JSON.stringify(includeBookings) +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-IsRefundValid
	IsRefundValid: function(pkOrderId,refundItems,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/IsRefundValid", token, server, "pkOrderId=" + pkOrderId + "&refundItems=" + JSON.stringify(refundItems) +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-IsRefundValidationRequiredByOrderId
	IsRefundValidationRequiredByOrderId: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/IsRefundValidationRequiredByOrderId", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-MarkManualRefundsAsActioned
	MarkManualRefundsAsActioned: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/MarkManualRefundsAsActioned", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-RefundCompleteOrder
	RefundCompleteOrder: function(pkOrderId,isManualRefund,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/RefundCompleteOrder", token, server, "pkOrderId=" + pkOrderId + "&isManualRefund=" + isManualRefund +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-RefundFreeText
	RefundFreeText: function(pkOrderId,refundItems,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/RefundFreeText", token, server, "pkOrderId=" + pkOrderId + "&refundItems=" + JSON.stringify(refundItems) +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-RefundServices
	RefundServices: function(pkOrderId,refundItems,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/RefundServices", token, server, "pkOrderId=" + pkOrderId + "&refundItems=" + JSON.stringify(refundItems) +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-RefundShipping
	RefundShipping: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/RefundShipping", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-RenameReturnCategory
	RenameReturnCategory: function(pkItemId,newName,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/RenameReturnCategory", token, server, "pkItemId=" + pkItemId + "&newName=" + newName +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-SearchProcessedOrdersPaged
	SearchProcessedOrdersPaged: function(from,to,dateType,searchField,exactMatch,searchTerm,pageNum,numEntriesPerPage,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/SearchProcessedOrdersPaged", token, server, "from=" + JSON.stringify(from) + "&to=" + JSON.stringify(to) + "&dateType=" + dateType + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/ProcessedOrders-ValidateCompleteOrderRefund
	ValidateCompleteOrderRefund: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("ProcessedOrders/ValidateCompleteOrderRefund", token, server, "pkOrderId=" + pkOrderId +"");
	},
};
