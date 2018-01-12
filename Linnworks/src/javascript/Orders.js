var Orders =
{
	// http://apidoc.linnworks.net/#/Orders-AddCoupon
	AddCoupon: function(orderId,barcode,couponData,fulfilmentCenter,token, server)
	{
		return Factory.GetResponse("Orders/AddCoupon", token, server, "orderId=" + orderId + "&barcode=" + barcode + "&couponData=" + JSON.stringify(couponData) + "&fulfilmentCenter=" + fulfilmentCenter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-AddOrderItem
	AddOrderItem: function(orderId,itemId,channelSKU,fulfilmentCenter,quantity,linePricing,token, server)
	{
		return Factory.GetResponse("Orders/AddOrderItem", token, server, "orderId=" + orderId + "&itemId=" + itemId + "&channelSKU=" + channelSKU + "&fulfilmentCenter=" + fulfilmentCenter + "&quantity=" + quantity + "&linePricing=" + JSON.stringify(linePricing) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-AddOrderService
	AddOrderService: function(orderId,service,cost,taxRate,fulfilmentCenter,token, server)
	{
		return Factory.GetResponse("Orders/AddOrderService", token, server, "orderId=" + orderId + "&service=" + service + "&cost=" + cost + "&taxRate=" + taxRate + "&fulfilmentCenter=" + fulfilmentCenter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-AssignToFolder
	AssignToFolder: function(orderIds,folder,token, server)
	{
		return Factory.GetResponse("Orders/AssignToFolder", token, server, "orderIds=" + JSON.stringify(orderIds) + "&folder=" + folder +"");
	},
	// http://apidoc.linnworks.net/#/Orders-CancelOrder
	CancelOrder: function(orderId,fulfilmentCenter,refund,note,token, server)
	{
		return Factory.GetResponse("Orders/CancelOrder", token, server, "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "&refund=" + refund + "&note=" + note +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ChangeOrderTag
	ChangeOrderTag: function(orderIds,tag,token, server)
	{
		return Factory.GetResponse("Orders/ChangeOrderTag", token, server, "orderIds=" + JSON.stringify(orderIds) + "&tag=" + JSON.stringify(tag) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ChangeShippingMethod
	ChangeShippingMethod: function(orderIds,shippingMethod,token, server)
	{
		return Factory.GetResponse("Orders/ChangeShippingMethod", token, server, "orderIds=" + JSON.stringify(orderIds) + "&shippingMethod=" + shippingMethod +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ChangeStatus
	ChangeStatus: function(orderIds,status,token, server)
	{
		return Factory.GetResponse("Orders/ChangeStatus", token, server, "orderIds=" + JSON.stringify(orderIds) + "&status=" + status +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ClearInvoicePrinted
	ClearInvoicePrinted: function(orderIds,token, server)
	{
		return Factory.GetResponse("Orders/ClearInvoicePrinted", token, server, "orderIds=" + JSON.stringify(orderIds) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ClearPickListPrinted
	ClearPickListPrinted: function(orderIds,token, server)
	{
		return Factory.GetResponse("Orders/ClearPickListPrinted", token, server, "orderIds=" + JSON.stringify(orderIds) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ClearShippingLabelInfo
	ClearShippingLabelInfo: function(orderIds,withoutConfirmation,token, server)
	{
		return Factory.GetResponse("Orders/ClearShippingLabelInfo", token, server, "orderIds=" + JSON.stringify(orderIds) + "&withoutConfirmation=" + withoutConfirmation +"");
	},
	// http://apidoc.linnworks.net/#/Orders-CompleteOrder
	CompleteOrder: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/CompleteOrder", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-CreateNewItemAndLink
	CreateNewItemAndLink: function(pkStockItemId,itemTitle,source,subSource,channelSKU,locationId,initialQuantity,token, server)
	{
		return Factory.GetResponse("Orders/CreateNewItemAndLink", token, server, "pkStockItemId=" + pkStockItemId + "&itemTitle=" + itemTitle + "&source=" + source + "&subSource=" + subSource + "&channelSKU=" + channelSKU + "&locationId=" + JSON.stringify(locationId) + "&initialQuantity=" + JSON.stringify(initialQuantity) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-CreateNewOrder
	CreateNewOrder: function(fulfilmentCenter,token, server)
	{
		return Factory.GetResponse("Orders/CreateNewOrder", token, server, "fulfilmentCenter=" + fulfilmentCenter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-CreateOrders
	CreateOrders: function(orders,location,token, server)
	{
		return Factory.GetResponse("Orders/CreateOrders", token, server, "orders=" + JSON.stringify(orders) + "&location=" + location +"");
	},
	// http://apidoc.linnworks.net/#/Orders-CustomerLookUp
	CustomerLookUp: function(field,txt,token, server)
	{
		return Factory.GetResponse("Orders/CustomerLookUp", token, server, "field=" + field + "&txt=" + txt +"");
	},
	// http://apidoc.linnworks.net/#/Orders-DeleteOrder
	DeleteOrder: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/DeleteOrder", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetAllAvailableOrderItemBatchsByOrderId
	GetAllAvailableOrderItemBatchsByOrderId: function(parameters,token, server)
	{
		return Factory.GetResponse("Orders/GetAllAvailableOrderItemBatchsByOrderId", token, server, "parameters=" + JSON.stringify(parameters) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetAllOpenOrders
	GetAllOpenOrders: function(filters,sorting,fulfilmentCenter,additionalFilter,token, server)
	{
		return Factory.GetResponse("Orders/GetAllOpenOrders", token, server, "filters=" + JSON.stringify(filters) + "&sorting=" + JSON.stringify(sorting) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetAllOpenOrdersBetweenIndex
	GetAllOpenOrdersBetweenIndex: function(fromIndex,toIndex,filters,sorting,fulfilmentCenter,additionalFilter,token, server)
	{
		return Factory.GetResponse("Orders/GetAllOpenOrdersBetweenIndex", token, server, "fromIndex=" + fromIndex + "&toIndex=" + toIndex + "&filters=" + JSON.stringify(filters) + "&sorting=" + JSON.stringify(sorting) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetAssignedOrderItemBatches
	GetAssignedOrderItemBatches: function(request,token, server)
	{
		return Factory.GetResponse("Orders/GetAssignedOrderItemBatches", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetAvailableFolders
	GetAvailableFolders: function(token, server)
	{
		return Factory.GetResponse("Orders/GetAvailableFolders", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetBatchPilots
	GetBatchPilots: function(token, server)
	{
		return Factory.GetResponse("Orders/GetBatchPilots", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetCountries
	GetCountries: function(token, server)
	{
		return Factory.GetResponse("Orders/GetCountries", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetDefaultPaymentMethodIdForNewOrder
	GetDefaultPaymentMethodIdForNewOrder: function(token, server)
	{
		return Factory.GetResponse("Orders/GetDefaultPaymentMethodIdForNewOrder", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetDraftOrders
	GetDraftOrders: function(token, server)
	{
		return Factory.GetResponse("Orders/GetDraftOrders", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetExtendedProperties
	GetExtendedProperties: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/GetExtendedProperties", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetExtendedPropertyNames
	GetExtendedPropertyNames: function(token, server)
	{
		return Factory.GetResponse("Orders/GetExtendedPropertyNames", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetExtendedPropertyTypes
	GetExtendedPropertyTypes: function(token, server)
	{
		return Factory.GetResponse("Orders/GetExtendedPropertyTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetLinkedItems
	GetLinkedItems: function(itemId,token, server)
	{
		return Factory.GetResponse("Orders/GetLinkedItems", token, server, "itemId=" + itemId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOpenOrderIdByOrderOrReferenceId
	GetOpenOrderIdByOrderOrReferenceId: function(orderOrReferenceId,filters,locationId,token, server)
	{
		return Factory.GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceId", token, server, "orderOrReferenceId=" + orderOrReferenceId + "&filters=" + JSON.stringify(filters) + "&locationId=" + JSON.stringify(locationId) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOpenOrderIdByOrderOrReferenceIdAndProcess
	GetOpenOrderIdByOrderOrReferenceIdAndProcess: function(orderOrReferenceId,fulfilmentCenter,filters,batchScanned,token, server)
	{
		return Factory.GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceIdAndProcess", token, server, "orderOrReferenceId=" + orderOrReferenceId + "&fulfilmentCenter=" + fulfilmentCenter + "&filters=" + JSON.stringify(filters) + "&batchScanned=" + batchScanned +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOpenOrderItemsSuppliers
	GetOpenOrderItemsSuppliers: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/GetOpenOrderItemsSuppliers", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOpenOrders
	GetOpenOrders: function(entriesPerPage,pageNumber,filters,sorting,fulfilmentCenter,additionalFilter,token, server)
	{
		return Factory.GetResponse("Orders/GetOpenOrders", token, server, "entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&filters=" + JSON.stringify(filters) + "&sorting=" + JSON.stringify(sorting) + "&fulfilmentCenter=" + JSON.stringify(fulfilmentCenter) + "&additionalFilter=" + additionalFilter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOpenOrdersByItemBarcode
	GetOpenOrdersByItemBarcode: function(productBarcode,filters,locationId,token, server)
	{
		return Factory.GetResponse("Orders/GetOpenOrdersByItemBarcode", token, server, "productBarcode=" + productBarcode + "&filters=" + JSON.stringify(filters) + "&locationId=" + JSON.stringify(locationId) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrder
	GetOrder: function(orderId,fulfilmentLocationId,loadItems,loadAdditionalInfo,token, server)
	{
		return Factory.GetResponse("Orders/GetOrder", token, server, "orderId=" + orderId + "&fulfilmentLocationId=" + JSON.stringify(fulfilmentLocationId) + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderAuditTrail
	GetOrderAuditTrail: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderAuditTrail", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderById
	GetOrderById: function(pkOrderId,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderById", token, server, "pkOrderId=" + pkOrderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderDetailsByNumOrderId
	GetOrderDetailsByNumOrderId: function(OrderId,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderDetailsByNumOrderId", token, server, "OrderId=" + OrderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderDetailsByReferenceId
	GetOrderDetailsByReferenceId: function(ReferenceId,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderDetailsByReferenceId", token, server, "ReferenceId=" + ReferenceId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderItemBatchsByOrderId
	GetOrderItemBatchsByOrderId: function(parameters,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderItemBatchsByOrderId", token, server, "parameters=" + JSON.stringify(parameters) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderItemComposition
	GetOrderItemComposition: function(orderId,stockItemId,fulfilmentCenter,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderItemComposition", token, server, "orderId=" + orderId + "&stockItemId=" + stockItemId + "&fulfilmentCenter=" + fulfilmentCenter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderItems
	GetOrderItems: function(orderId,fulfilmentCenter,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderItems", token, server, "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderNotes
	GetOrderNotes: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderNotes", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderNoteTypes
	GetOrderNoteTypes: function(token, server)
	{
		return Factory.GetResponse("Orders/GetOrderNoteTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderPackagingCalculation
	GetOrderPackagingCalculation: function(request,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderPackagingCalculation", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderPackagingSplit
	GetOrderPackagingSplit: function(orderId,openOrdersOnly,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderPackagingSplit", token, server, "orderId=" + orderId + "&openOrdersOnly=" + openOrdersOnly +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderRelations
	GetOrderRelations: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderRelations", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrders
	GetOrders: function(ordersIds,fulfilmentLocationId,loadItems,loadAdditionalInfo,token, server)
	{
		return Factory.GetResponse("Orders/GetOrders", token, server, "ordersIds=" + JSON.stringify(ordersIds) + "&fulfilmentLocationId=" + JSON.stringify(fulfilmentLocationId) + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrdersById
	GetOrdersById: function(pkOrderIds,token, server)
	{
		return Factory.GetResponse("Orders/GetOrdersById", token, server, "pkOrderIds=" + JSON.stringify(pkOrderIds) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderView
	GetOrderView: function(pkViewId,markAsLatestViewed,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderView", token, server, "pkViewId=" + pkViewId + "&markAsLatestViewed=" + markAsLatestViewed +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderViews
	GetOrderViews: function(token, server)
	{
		return Factory.GetResponse("Orders/GetOrderViews", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderXml
	GetOrderXml: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderXml", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetOrderXmlJSTree
	GetOrderXmlJSTree: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/GetOrderXmlJSTree", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-GetPackagingGroups
	GetPackagingGroups: function(token, server)
	{
		return Factory.GetResponse("Orders/GetPackagingGroups", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetPaymentMethods
	GetPaymentMethods: function(token, server)
	{
		return Factory.GetResponse("Orders/GetPaymentMethods", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetShippingMethods
	GetShippingMethods: function(token, server)
	{
		return Factory.GetResponse("Orders/GetShippingMethods", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-GetUserLocationId
	GetUserLocationId: function(token, server)
	{
		return Factory.GetResponse("Orders/GetUserLocationId", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Orders-LockOrder
	LockOrder: function(orderIds,lockOrder,token, server)
	{
		return Factory.GetResponse("Orders/LockOrder", token, server, "orderIds=" + JSON.stringify(orderIds) + "&lockOrder=" + lockOrder +"");
	},
	// http://apidoc.linnworks.net/#/Orders-MergeOrders
	MergeOrders: function(ordersToMerge,fulfilmentCenter,pkPostalServiceId,token, server)
	{
		return Factory.GetResponse("Orders/MergeOrders", token, server, "ordersToMerge=" + JSON.stringify(ordersToMerge) + "&fulfilmentCenter=" + fulfilmentCenter + "&pkPostalServiceId=" + pkPostalServiceId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-MoveToFulfilmentCenter
	MoveToFulfilmentCenter: function(orderIds,fulfilmentCenterId,token, server)
	{
		return Factory.GetResponse("Orders/MoveToFulfilmentCenter", token, server, "orderIds=" + JSON.stringify(orderIds) + "&fulfilmentCenterId=" + fulfilmentCenterId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-MoveToLocation
	MoveToLocation: function(orderIds,pkStockLocationId,token, server)
	{
		return Factory.GetResponse("Orders/MoveToLocation", token, server, "orderIds=" + JSON.stringify(orderIds) + "&pkStockLocationId=" + pkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ProcessFulfilmentCentreOrder
	ProcessFulfilmentCentreOrder: function(orderId,token, server)
	{
		return Factory.GetResponse("Orders/ProcessFulfilmentCentreOrder", token, server, "orderId=" + orderId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ProcessOrder
	ProcessOrder: function(orderId,scanPerformed,locationId,allowZeroAndNegativeBatchQty,token, server)
	{
		return Factory.GetResponse("Orders/ProcessOrder", token, server, "orderId=" + orderId + "&scanPerformed=" + scanPerformed + "&locationId=" + JSON.stringify(locationId) + "&allowZeroAndNegativeBatchQty=" + allowZeroAndNegativeBatchQty +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ProcessOrder_RequiredBatchScans
	ProcessOrder_RequiredBatchScans: function(BatchAssignment,token, server)
	{
		return Factory.GetResponse("Orders/ProcessOrder_RequiredBatchScans", token, server, "BatchAssignment=" + JSON.stringify(BatchAssignment) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ProcessOrderByOrderOrReferenceId
	ProcessOrderByOrderOrReferenceId: function(request,token, server)
	{
		return Factory.GetResponse("Orders/ProcessOrderByOrderOrReferenceId", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ProcessOrdersInBatch
	ProcessOrdersInBatch: function(ordersIds,locationId,token, server)
	{
		return Factory.GetResponse("Orders/ProcessOrdersInBatch", token, server, "ordersIds=" + JSON.stringify(ordersIds) + "&locationId=" + JSON.stringify(locationId) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-RecalculateSingleOrderPackaging
	RecalculateSingleOrderPackaging: function(request,token, server)
	{
		return Factory.GetResponse("Orders/RecalculateSingleOrderPackaging", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-RemoveOrderItem
	RemoveOrderItem: function(orderId,rowid,fulfilmentCenter,token, server)
	{
		return Factory.GetResponse("Orders/RemoveOrderItem", token, server, "orderId=" + orderId + "&rowid=" + rowid + "&fulfilmentCenter=" + fulfilmentCenter +"");
	},
	// http://apidoc.linnworks.net/#/Orders-RunRulesEngine
	RunRulesEngine: function(orderIds,token, server)
	{
		return Factory.GetResponse("Orders/RunRulesEngine", token, server, "orderIds=" + JSON.stringify(orderIds) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SaveOrderView
	SaveOrderView: function(pkViewId,viewName,OrderViewDetailJSON,token, server)
	{
		return Factory.GetResponse("Orders/SaveOrderView", token, server, "pkViewId=" + pkViewId + "&viewName=" + viewName + "&OrderViewDetailJSON=" + OrderViewDetailJSON +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetAdditionalInfo
	SetAdditionalInfo: function(orderId,rowId,additionalInfo,token, server)
	{
		return Factory.GetResponse("Orders/SetAdditionalInfo", token, server, "orderId=" + orderId + "&rowId=" + rowId + "&additionalInfo=" + JSON.stringify(additionalInfo) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetAvailableFolders
	SetAvailableFolders: function(folders,token, server)
	{
		return Factory.GetResponse("Orders/SetAvailableFolders", token, server, "folders=" + JSON.stringify(folders) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetDefaultPaymentMethodIdForNewOrder
	SetDefaultPaymentMethodIdForNewOrder: function(paymentMethod,token, server)
	{
		return Factory.GetResponse("Orders/SetDefaultPaymentMethodIdForNewOrder", token, server, "paymentMethod=" + paymentMethod +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetExtendedProperties
	SetExtendedProperties: function(orderId,extendedProperties,token, server)
	{
		return Factory.GetResponse("Orders/SetExtendedProperties", token, server, "orderId=" + orderId + "&extendedProperties=" + JSON.stringify(extendedProperties) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetInvoicesPrinted
	SetInvoicesPrinted: function(orderIds,token, server)
	{
		return Factory.GetResponse("Orders/SetInvoicesPrinted", token, server, "orderIds=" + JSON.stringify(orderIds) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetLabelsPrinted
	SetLabelsPrinted: function(orderIds,token, server)
	{
		return Factory.GetResponse("Orders/SetLabelsPrinted", token, server, "orderIds=" + JSON.stringify(orderIds) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetOrderCustomerInfo
	SetOrderCustomerInfo: function(orderId,info,saveToCrm,token, server)
	{
		return Factory.GetResponse("Orders/SetOrderCustomerInfo", token, server, "orderId=" + orderId + "&info=" + JSON.stringify(info) + "&saveToCrm=" + JSON.stringify(saveToCrm) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetOrderGeneralInfo
	SetOrderGeneralInfo: function(orderId,info,wasDraft,token, server)
	{
		return Factory.GetResponse("Orders/SetOrderGeneralInfo", token, server, "orderId=" + orderId + "&info=" + JSON.stringify(info) + "&wasDraft=" + wasDraft +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetOrderNotes
	SetOrderNotes: function(orderId,orderNotes,token, server)
	{
		return Factory.GetResponse("Orders/SetOrderNotes", token, server, "orderId=" + orderId + "&orderNotes=" + JSON.stringify(orderNotes) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetOrderPackaging
	SetOrderPackaging: function(request,token, server)
	{
		return Factory.GetResponse("Orders/SetOrderPackaging", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetOrderPackagingSplit
	SetOrderPackagingSplit: function(orderId,packagingSplit,token, server)
	{
		return Factory.GetResponse("Orders/SetOrderPackagingSplit", token, server, "orderId=" + orderId + "&packagingSplit=" + JSON.stringify(packagingSplit) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetOrderShippingInfo
	SetOrderShippingInfo: function(orderId,info,token, server)
	{
		return Factory.GetResponse("Orders/SetOrderShippingInfo", token, server, "orderId=" + orderId + "&info=" + JSON.stringify(info) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetOrderSplitPackagingManualOverwrite
	SetOrderSplitPackagingManualOverwrite: function(request,token, server)
	{
		return Factory.GetResponse("Orders/SetOrderSplitPackagingManualOverwrite", token, server, "request=" + JSON.stringify(request) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetOrderTotalsInfo
	SetOrderTotalsInfo: function(orderId,info,token, server)
	{
		return Factory.GetResponse("Orders/SetOrderTotalsInfo", token, server, "orderId=" + orderId + "&info=" + JSON.stringify(info) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetPaymentMethods
	SetPaymentMethods: function(paymentMethods,token, server)
	{
		return Factory.GetResponse("Orders/SetPaymentMethods", token, server, "paymentMethods=" + JSON.stringify(paymentMethods) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SetPickListPrinted
	SetPickListPrinted: function(Request,token, server)
	{
		return Factory.GetResponse("Orders/SetPickListPrinted", token, server, "Request=" + JSON.stringify(Request) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-SplitOrder
	SplitOrder: function(orderId,newOrders,type,fulfilmentLocationId,token, server)
	{
		return Factory.GetResponse("Orders/SplitOrder", token, server, "orderId=" + orderId + "&newOrders=" + JSON.stringify(newOrders) + "&type=" + type + "&fulfilmentLocationId=" + fulfilmentLocationId +"");
	},
	// http://apidoc.linnworks.net/#/Orders-UnassignToFolder
	UnassignToFolder: function(orderIds,folder,token, server)
	{
		return Factory.GetResponse("Orders/UnassignToFolder", token, server, "orderIds=" + JSON.stringify(orderIds) + "&folder=" + folder +"");
	},
	// http://apidoc.linnworks.net/#/Orders-UpdateBillingAddress
	UpdateBillingAddress: function(orderId,billingAddress,token, server)
	{
		return Factory.GetResponse("Orders/UpdateBillingAddress", token, server, "orderId=" + orderId + "&billingAddress=" + JSON.stringify(billingAddress) +"");
	},
	// http://apidoc.linnworks.net/#/Orders-UpdateLinkItem
	UpdateLinkItem: function(pkStockId,pkStockItemId,source,subSource,channelSKU,token, server)
	{
		return Factory.GetResponse("Orders/UpdateLinkItem", token, server, "pkStockId=" + pkStockId + "&pkStockItemId=" + pkStockItemId + "&source=" + source + "&subSource=" + subSource + "&channelSKU=" + channelSKU +"");
	},
	// http://apidoc.linnworks.net/#/Orders-UpdateOrderItem
	UpdateOrderItem: function(orderId,orderItem,fulfilmentCenter,source,subSource,token, server)
	{
		return Factory.GetResponse("Orders/UpdateOrderItem", token, server, "orderId=" + orderId + "&orderItem=" + JSON.stringify(orderItem) + "&fulfilmentCenter=" + fulfilmentCenter + "&source=" + source + "&subSource=" + subSource +"");
	},
	// http://apidoc.linnworks.net/#/Orders-ValidateCoupon
	ValidateCoupon: function(orderId,barcode,token, server)
	{
		return Factory.GetResponse("Orders/ValidateCoupon", token, server, "orderId=" + orderId + "&barcode=" + barcode +"");
	},
};
