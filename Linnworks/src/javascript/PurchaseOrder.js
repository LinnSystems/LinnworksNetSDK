var PurchaseOrder =
{
	// http://apidoc.linnworks.net/#/PurchaseOrder-Add_PurchaseOrderExtendedProperty
	Add_PurchaseOrderExtendedProperty: function(request,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderExtendedProperty", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Add_PurchaseOrderItem
	Add_PurchaseOrderItem: function(addItemParameter,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderItem", token, server, "addItemParameter=" + JSON.stringify(addItemParameter) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Add_PurchaseOrderNote
	Add_PurchaseOrderNote: function(pkPurchaseId,Note,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderNote", token, server, "pkPurchaseId=" + pkPurchaseId + "&Note=" + Note +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Change_PurchaseOrderStatus
	Change_PurchaseOrderStatus: function(changeStatusParameter,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Change_PurchaseOrderStatus", token, server, "changeStatusParameter=" + JSON.stringify(changeStatusParameter) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Create_PurchaseOrder_Initial
	Create_PurchaseOrder_Initial: function(createParameters,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Create_PurchaseOrder_Initial", token, server, "createParameters=" + JSON.stringify(createParameters) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Delete_PurchaseOrder
	Delete_PurchaseOrder: function(pkPurchaseId,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrder", token, server, "pkPurchaseId=" + pkPurchaseId +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Delete_PurchaseOrderExtendedProperty
	Delete_PurchaseOrderExtendedProperty: function(request,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderExtendedProperty", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Delete_PurchaseOrderItem
	Delete_PurchaseOrderItem: function(deleteItemParameter,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderItem", token, server, "deleteItemParameter=" + JSON.stringify(deleteItemParameter) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Delete_PurchaseOrderNote
	Delete_PurchaseOrderNote: function(pkPurchaseId,pkPurchaseOrderNoteId,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderNote", token, server, "pkPurchaseId=" + pkPurchaseId + "&pkPurchaseOrderNoteId=" + pkPurchaseOrderNoteId +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Deliver_PurchaseItem
	Deliver_PurchaseItem: function(deliverItemParameter,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItem", token, server, "deliverItemParameter=" + JSON.stringify(deliverItemParameter) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Deliver_PurchaseItemAll
	Deliver_PurchaseItemAll: function(purchaseId,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItemAll", token, server, "purchaseId=" + purchaseId +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Deliver_PurchaseItemAll_ExceptBatchItems
	Deliver_PurchaseItemAll_ExceptBatchItems: function(purchaseId,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItemAll_ExceptBatchItems", token, server, "purchaseId=" + purchaseId +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Get_PurchaseOrder
	Get_PurchaseOrder: function(pkPurchaseId,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Get_PurchaseOrder", token, server, "pkPurchaseId=" + pkPurchaseId +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Get_PurchaseOrderAudit
	Get_PurchaseOrderAudit: function(auditLog,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderAudit", token, server, "auditLog=" + JSON.stringify(auditLog) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Get_PurchaseOrderExtendedProperty
	Get_PurchaseOrderExtendedProperty: function(request,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderExtendedProperty", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Get_PurchaseOrderNote
	Get_PurchaseOrderNote: function(pkPurchaseId,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderNote", token, server, "pkPurchaseId=" + pkPurchaseId +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-GetPurchaseOrderStatusList
	GetPurchaseOrderStatusList: function(token, server)
	{
		return Factory.GetResponse("PurchaseOrder/GetPurchaseOrderStatusList", token, server, "");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-GetPurchaseOrdersWithStockItems
	GetPurchaseOrdersWithStockItems: function(purchaseOrder,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/GetPurchaseOrdersWithStockItems", token, server, "purchaseOrder=" + JSON.stringify(purchaseOrder) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Search_PurchaseOrders
	Search_PurchaseOrders: function(searchParameter,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Search_PurchaseOrders", token, server, "searchParameter=" + JSON.stringify(searchParameter) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Update_PurchaseOrderExtendedProperty
	Update_PurchaseOrderExtendedProperty: function(request,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderExtendedProperty", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Update_PurchaseOrderHeader
	Update_PurchaseOrderHeader: function(updateParameter,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderHeader", token, server, "updateParameter=" + JSON.stringify(updateParameter) +"");
	},
	// http://apidoc.linnworks.net/#/PurchaseOrder-Update_PurchaseOrderItem
	Update_PurchaseOrderItem: function(updateItemParameter,token, server)
	{
		return Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderItem", token, server, "updateItemParameter=" + JSON.stringify(updateItemParameter) +"");
	},
};
