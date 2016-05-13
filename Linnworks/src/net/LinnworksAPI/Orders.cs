using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace LinnworksAPI
{public static class OrdersMethods 
{ public static void SaveOrderView(Int32 pkViewId,String viewName,String OrderViewDetailJSON,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/SaveOrderView", "pkViewId=" + pkViewId + "&viewName=" + viewName + "&OrderViewDetailJSON=" + OrderViewDetailJSON + "", ApiToken, ApiServer); 
}

public static List<CustomerAddress> CustomerLookUp(String field,String txt,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<CustomerAddress>>(Factory.GetResponse("Orders/CustomerLookUp", "field=" + field + "&txt=" + txt + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<LinkedItem> GetLinkedItems(Guid itemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<LinkedItem>>(Factory.GetResponse("Orders/GetLinkedItems", "itemId=" + itemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void UpdateLinkItem(Guid pkStockId,Guid pkStockItemId,String source,String subSource,String channelSKU,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/UpdateLinkItem", "pkStockId=" + pkStockId + "&pkStockItemId=" + pkStockItemId + "&source=" + source + "&subSource=" + subSource + "&channelSKU=" + channelSKU + "", ApiToken, ApiServer); 
}

public static Guid? CreateNewItemAndLink(Guid pkStockItemId,String itemTitle,String source,String subSource,String channelSKU,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid?>(Factory.GetResponse("Orders/CreateNewItemAndLink", "pkStockItemId=" + pkStockItemId + "&itemTitle=" + itemTitle + "&source=" + source + "&subSource=" + subSource + "&channelSKU=" + channelSKU + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderPackagingSplit> GetOrderPackagingSplit(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderPackagingSplit>>(Factory.GetResponse("Orders/GetOrderPackagingSplit", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static UpdateTotalsResult SetOrderPackagingSplit(Guid orderId,List<OrderPackagingSplit> packagingSplit,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateTotalsResult>(Factory.GetResponse("Orders/SetOrderPackagingSplit", "orderId=" + orderId + "&packagingSplit=" + Newtonsoft.Json.JsonConvert.SerializeObject(packagingSplit) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Guid? GetOpenOrderIdByOrderOrReferenceId(String orderOrReferenceId,FieldsFilter filters,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid?>(Factory.GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceId", "orderOrReferenceId=" + orderOrReferenceId + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static KeyValuePair<OrderSummary,String> GetOpenOrderIdByOrderOrReferenceIdAndProcess(String orderOrReferenceId,Guid fulfilmentCenter,FieldsFilter filters,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<KeyValuePair<OrderSummary,String>>(Factory.GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceIdAndProcess", "orderOrReferenceId=" + orderOrReferenceId + "&fulfilmentCenter=" + fulfilmentCenter + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static KeyValuePair<List<OrderSummary>,String> GetOpenOrdersByItemBarcode(String productBarcode,FieldsFilter filters,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<KeyValuePair<List<OrderSummary>,String>>(Factory.GetResponse("Orders/GetOpenOrdersByItemBarcode", "productBarcode=" + productBarcode + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderDetails> GetOrderDetailsByReferenceId(String ReferenceId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderDetails>>(Factory.GetResponse("Orders/GetOrderDetailsByReferenceId", "ReferenceId=" + ReferenceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static OrderDetails GetOrderDetailsByNumOrderId(Int32 OrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderDetails>(Factory.GetResponse("Orders/GetOrderDetailsByNumOrderId", "OrderId=" + OrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static OrderDetails GetOrderById(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderDetails>(Factory.GetResponse("Orders/GetOrderById", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderDetails> GetOrdersById(List<Guid> pkOrderIds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderDetails>>(Factory.GetResponse("Orders/GetOrdersById", "pkOrderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(pkOrderIds) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Guid GetUserLocationId(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("Orders/GetUserLocationId", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void SetUserLocationId(Guid locationId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/SetUserLocationId", "locationId=" + locationId + "", ApiToken, ApiServer); 
}

public static GenericPagedResult<OpenOrder> GetOpenOrders(Int32 entriesPerPage,Int32 pageNumber,FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<OpenOrder>>(Factory.GetResponse("Orders/GetOpenOrders", "entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters) + "&sorting=" + Newtonsoft.Json.JsonConvert.SerializeObject(sorting) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> GetAllOpenOrders(FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetAllOpenOrders", "filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters) + "&sorting=" + Newtonsoft.Json.JsonConvert.SerializeObject(sorting) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> GetAllOpenOrdersBetweenIndex(Int32 fromIndex,Int32 toIndex,FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetAllOpenOrdersBetweenIndex", "fromIndex=" + fromIndex + "&toIndex=" + toIndex + "&filters=" + Newtonsoft.Json.JsonConvert.SerializeObject(filters) + "&sorting=" + Newtonsoft.Json.JsonConvert.SerializeObject(sorting) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + additionalFilter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> SetLabelsPrinted(List<Guid> orderIds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/SetLabelsPrinted", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> SetInvoicesPrinted(List<Guid> orderIds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/SetInvoicesPrinted", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static OrderItem GetOrderItemComposition(Guid orderId,Guid stockItemId,Guid fulfilmentCenter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderItem>(Factory.GetResponse("Orders/GetOrderItemComposition", "orderId=" + orderId + "&stockItemId=" + stockItemId + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> ChangeOrderTag(List<Guid> orderIds,Int32? tag,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeOrderTag", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "&tag=" + Newtonsoft.Json.JsonConvert.SerializeObject(tag) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderFolder> GetAvailableFolders(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderFolder>>(Factory.GetResponse("Orders/GetAvailableFolders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderFolder> SetAvailableFolders(List<OrderFolder> folders,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderFolder>>(Factory.GetResponse("Orders/SetAvailableFolders", "folders=" + Newtonsoft.Json.JsonConvert.SerializeObject(folders) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> AssignToFolder(List<Guid> orderIds,String folder,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/AssignToFolder", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "&folder=" + folder + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> UnassignToFolder(List<Guid> orderIds,String folder,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/UnassignToFolder", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "&folder=" + folder + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static String GetOrderXmlJSTree(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Orders/GetOrderXmlJSTree", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderXML> GetOrderXml(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderXML>>(Factory.GetResponse("Orders/GetOrderXml", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> ChangeShippingMethod(List<Guid> orderIds,String shippingMethod,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeShippingMethod", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "&shippingMethod=" + shippingMethod + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> ChangeStatus(List<Guid> orderIds,Int32 status,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ChangeStatus", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "&status=" + status + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void LockOrder(List<Guid> orderIds,Boolean lockOrder,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/LockOrder", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "&lockOrder=" + lockOrder + "", ApiToken, ApiServer); 
}

public static void DeleteOrder(Guid orderId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/DeleteOrder", "orderId=" + orderId + "", ApiToken, ApiServer); 
}

public static String CancelOrder(Guid orderId,Guid fulfilmentCenter,Double refund,String note,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Orders/CancelOrder", "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "&refund=" + refund + "&note=" + note + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static MoveToFulfilmentCenterResult MoveToFulfilmentCenter(List<Guid> orderIds,Guid fulfilmentCenterId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<MoveToFulfilmentCenterResult>(Factory.GetResponse("Orders/MoveToFulfilmentCenter", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "&fulfilmentCenterId=" + fulfilmentCenterId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<KeyValuePair<Guid,String>> ClearShippingLabelInfo(List<Guid> orderIds,Boolean withoutConfirmation,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<Guid,String>>>(Factory.GetResponse("Orders/ClearShippingLabelInfo", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "&withoutConfirmation=" + withoutConfirmation + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> ClearInvoicePrinted(List<Guid> orderIds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/ClearInvoicePrinted", "orderIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderIds) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ShippingMethod> GetShippingMethods(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ShippingMethod>>(Factory.GetResponse("Orders/GetShippingMethods", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<PackageGroup> GetPackagingGroups(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PackageGroup>>(Factory.GetResponse("Orders/GetPackagingGroups", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ExtendedProperty> GetExtendedProperties(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExtendedProperty>>(Factory.GetResponse("Orders/GetExtendedProperties", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<String> GetExtendedPropertyTypes(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Orders/GetExtendedPropertyTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ExtendedProperty> SetExtendedProperties(Guid orderId,ExtendedProperty extendedProperties,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExtendedProperty>>(Factory.GetResponse("Orders/SetExtendedProperties", "orderId=" + orderId + "&extendedProperties=" + Newtonsoft.Json.JsonConvert.SerializeObject(extendedProperties) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<KeyValuePair<Guid,String>> GetBatchPilots(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<Guid,String>>>(Factory.GetResponse("Orders/GetBatchPilots", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static OpenOrder GetOrder(Guid orderId,Guid fulfilmentLocationId,Boolean loadItems,Boolean loadAdditionalInfo,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/GetOrder", "orderId=" + orderId + "&fulfilmentLocationId=" + fulfilmentLocationId + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OpenOrder> GetOrders(List<Guid> ordersIds,Guid fulfilmentLocationId,Boolean loadItems,Boolean loadAdditionalInfo,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OpenOrder>>(Factory.GetResponse("Orders/GetOrders", "ordersIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(ordersIds) + "&fulfilmentLocationId=" + fulfilmentLocationId + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderAuditTrail> GetOrderAuditTrail(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderAuditTrail>>(Factory.GetResponse("Orders/GetOrderAuditTrail", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderNote> GetOrderNotes(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderNote>>(Factory.GetResponse("Orders/GetOrderNotes", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void SetOrderNotes(Guid orderId,List<OrderNote> orderNotes,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/SetOrderNotes", "orderId=" + orderId + "&orderNotes=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderNotes) + "", ApiToken, ApiServer); 
}

public static List<OrderRelation> GetOrderRelations(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderRelation>>(Factory.GetResponse("Orders/GetOrderRelations", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderItem> GetOrderItems(Guid orderId,Guid fulfilmentCenter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderItem>>(Factory.GetResponse("Orders/GetOrderItems", "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<KeyValuePair<Guid,Guid>> GetOpenOrderItemsSuppliers(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyValuePair<Guid,Guid>>>(Factory.GetResponse("Orders/GetOpenOrderItemsSuppliers", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static UpdateOrderItemResult AddOrderItem(Guid orderId,Guid itemId,String channelSKU,Guid fulfilmentCenter,Int32 quantity,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddOrderItem", "orderId=" + orderId + "&itemId=" + itemId + "&channelSKU=" + channelSKU + "&fulfilmentCenter=" + fulfilmentCenter + "&quantity=" + quantity + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static UpdateOrderItemResult AddOrderService(Guid orderId,String service,Double cost,Double taxRate,Guid fulfilmentCenter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddOrderService", "orderId=" + orderId + "&service=" + service + "&cost=" + cost + "&taxRate=" + taxRate + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static UpdateOrderItemResult UpdateOrderItem(Guid orderId,OrderItem orderItem,Guid fulfilmentCenter,String source,String subSource,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/UpdateOrderItem", "orderId=" + orderId + "&orderItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderItem) + "&fulfilmentCenter=" + fulfilmentCenter + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static UpdateOrderItemResult RemoveOrderItem(Guid orderId,Guid rowid,Guid fulfilmentCenter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/RemoveOrderItem", "orderId=" + orderId + "&rowid=" + rowid + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Country> GetCountries(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(Factory.GetResponse("Orders/GetCountries", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<PaymentMethod> GetPaymentMethods(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PaymentMethod>>(Factory.GetResponse("Orders/GetPaymentMethods", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Guid GetDefaultPaymentMethodIdForNewOrder(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("Orders/GetDefaultPaymentMethodIdForNewOrder", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void SetDefaultPaymentMethodIdForNewOrder(Guid paymentMethod,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/SetDefaultPaymentMethodIdForNewOrder", "paymentMethod=" + paymentMethod + "", ApiToken, ApiServer); 
}

public static List<PaymentMethod> SetPaymentMethods(PaymentMethod paymentMethods,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PaymentMethod>>(Factory.GetResponse("Orders/SetPaymentMethods", "paymentMethods=" + Newtonsoft.Json.JsonConvert.SerializeObject(paymentMethods) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static OpenOrder CreateNewOrder(Guid fulfilmentCenter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/CreateNewOrder", "fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<Guid> GetDraftOrders(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("Orders/GetDraftOrders", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static String CompleteOrder(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Orders/CompleteOrder", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OpenOrder> SplitOrder(Guid orderId,OrderSplit newOrders,String type,Guid fulfilmentLocationId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OpenOrder>>(Factory.GetResponse("Orders/SplitOrder", "orderId=" + orderId + "&newOrders=" + Newtonsoft.Json.JsonConvert.SerializeObject(newOrders) + "&type=" + type + "&fulfilmentLocationId=" + fulfilmentLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static OpenOrder MergeOrders(List<Guid> ordersToMerge,Guid fulfilmentCenter,Guid pkPostalServiceId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenOrder>(Factory.GetResponse("Orders/MergeOrders", "ordersToMerge=" + Newtonsoft.Json.JsonConvert.SerializeObject(ordersToMerge) + "&fulfilmentCenter=" + fulfilmentCenter + "&pkPostalServiceId=" + pkPostalServiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static ProcessOrderResult ProcessOrder(Guid orderId,Boolean scanPerformed,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<ProcessOrderResult>(Factory.GetResponse("Orders/ProcessOrder", "orderId=" + orderId + "&scanPerformed=" + scanPerformed + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ProcessOrderResult> ProcessOrdersInBatch(List<Guid> ordersIds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProcessOrderResult>>(Factory.GetResponse("Orders/ProcessOrdersInBatch", "ordersIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(ordersIds) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static ProcessOrderResult ProcessFulfilmentCentreOrder(Guid orderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<ProcessOrderResult>(Factory.GetResponse("Orders/ProcessFulfilmentCentreOrder", "orderId=" + orderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void SetOrderGeneralInfo(Guid orderId,OrderGeneralInfo info,Boolean wasDraft,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/SetOrderGeneralInfo", "orderId=" + orderId + "&info=" + Newtonsoft.Json.JsonConvert.SerializeObject(info) + "&wasDraft=" + wasDraft + "", ApiToken, ApiServer); 
}

public static UpdateTotalsResult SetOrderShippingInfo(Guid orderId,OrderShippingInfo info,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateTotalsResult>(Factory.GetResponse("Orders/SetOrderShippingInfo", "orderId=" + orderId + "&info=" + Newtonsoft.Json.JsonConvert.SerializeObject(info) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void SetOrderCustomerInfo(Guid orderId,OrderCustomerInfo info,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/SetOrderCustomerInfo", "orderId=" + orderId + "&info=" + Newtonsoft.Json.JsonConvert.SerializeObject(info) + "", ApiToken, ApiServer); 
}

public static void SetOrderTotalsInfo(Guid orderId,OrderTotalsInfo info,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/SetOrderTotalsInfo", "orderId=" + orderId + "&info=" + Newtonsoft.Json.JsonConvert.SerializeObject(info) + "", ApiToken, ApiServer); 
}

public static CouponValidationResult ValidateCoupon(Guid orderId,String barcode,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<CouponValidationResult>(Factory.GetResponse("Orders/ValidateCoupon", "orderId=" + orderId + "&barcode=" + barcode + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static UpdateOrderItemResult AddCoupon(Guid orderId,String barcode,CouponValidationResult couponData,Guid fulfilmentCenter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateOrderItemResult>(Factory.GetResponse("Orders/AddCoupon", "orderId=" + orderId + "&barcode=" + barcode + "&couponData=" + Newtonsoft.Json.JsonConvert.SerializeObject(couponData) + "&fulfilmentCenter=" + fulfilmentCenter + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void UpdateBillingAddress(Guid orderId,Address billingAddress,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/UpdateBillingAddress", "orderId=" + orderId + "&billingAddress=" + Newtonsoft.Json.JsonConvert.SerializeObject(billingAddress) + "", ApiToken, ApiServer); 
}

public static void SetAdditionalInfo(Guid orderId,Guid rowId,OrderItemOption additionalInfo,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Orders/SetAdditionalInfo", "orderId=" + orderId + "&rowId=" + rowId + "&additionalInfo=" + Newtonsoft.Json.JsonConvert.SerializeObject(additionalInfo) + "", ApiToken, ApiServer); 
}

public static List<UserOrderView> GetOrderViews(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserOrderView>>(Factory.GetResponse("Orders/GetOrderViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static UserOrderView GetOrderView(Int32 pkViewId,Boolean markAsLatestViewed,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<UserOrderView>(Factory.GetResponse("Orders/GetOrderView", "pkViewId=" + pkViewId + "&markAsLatestViewed=" + markAsLatestViewed + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
} 
}
}