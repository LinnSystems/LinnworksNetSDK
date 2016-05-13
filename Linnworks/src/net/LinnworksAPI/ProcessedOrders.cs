using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace LinnworksAPI
{public static class ProcessedOrdersMethods 
{ public static List<RefundInfo> RefundFreeText(Guid pkOrderId,List<RefundItem> refundItems,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/RefundFreeText", "pkOrderId=" + pkOrderId + "&refundItems=" + Newtonsoft.Json.JsonConvert.SerializeObject(refundItems) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<RefundInfo> RefundShipping(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/RefundShipping", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void MarkManualRefundsAsActioned(Guid pkOrderId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("ProcessedOrders/MarkManualRefundsAsActioned", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer); 
}

public static List<RefundInfo> RefundServices(Guid pkOrderId,List<RefundItem> refundItems,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/RefundServices", "pkOrderId=" + pkOrderId + "&refundItems=" + Newtonsoft.Json.JsonConvert.SerializeObject(refundItems) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<RefundInfo> RefundCompleteOrder(Guid pkOrderId,Boolean isManualRefund,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/RefundCompleteOrder", "pkOrderId=" + pkOrderId + "&isManualRefund=" + isManualRefund + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static ValidationResult ValidateCompleteOrderRefund(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<ValidationResult>(Factory.GetResponse("ProcessedOrders/ValidateCompleteOrderRefund", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static RefundScreenOptions GetRefundsOptions(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<RefundScreenOptions>(Factory.GetResponse("ProcessedOrders/GetRefundsOptions", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ServiceItem> GetRefundableServiceItems(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ServiceItem>>(Factory.GetResponse("ProcessedOrders/GetRefundableServiceItems", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static ExistingRefundTotal GetTotalRefunds(Guid pkOrderId,Boolean? includeBookings,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<ExistingRefundTotal>(Factory.GetResponse("ProcessedOrders/GetTotalRefunds", "pkOrderId=" + pkOrderId + "&includeBookings=" + Newtonsoft.Json.JsonConvert.SerializeObject(includeBookings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static ValidationResult IsRefundValid(Guid pkOrderId,List<RefundItem> refundItems,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<ValidationResult>(Factory.GetResponse("ProcessedOrders/IsRefundValid", "pkOrderId=" + pkOrderId + "&refundItems=" + Newtonsoft.Json.JsonConvert.SerializeObject(refundItems) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Boolean IsRefundValidationRequiredByOrderId(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("ProcessedOrders/IsRefundValidationRequiredByOrderId", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ChannelRefundReason> GetChannelRefundReasons(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChannelRefundReason>>(Factory.GetResponse("ProcessedOrders/GetChannelRefundReasons", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ReturnInfo> GetReturnsExchanges(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/GetReturnsExchanges", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderItemReturnInfo> GetReturnItemsInfo(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderItemReturnInfo>>(Factory.GetResponse("ProcessedOrders/GetReturnItemsInfo", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static ReturnOrderHeader GetReturnOrderInfo(Guid pkOrderId,Boolean includeRefundLink,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<ReturnOrderHeader>(Factory.GetResponse("ProcessedOrders/GetReturnOrderInfo", "pkOrderId=" + pkOrderId + "&includeRefundLink=" + includeRefundLink + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static ProcessedOrderWeb GetOrderInfo(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<ProcessedOrderWeb>(Factory.GetResponse("ProcessedOrders/GetOrderInfo", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static GenericPagedResult<ProcessedOrderWeb> SearchProcessedOrdersPaged(DateTime? from,DateTime? to,SearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,Int32 pageNum,Int32 numEntriesPerPage,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<ProcessedOrderWeb>>(Factory.GetResponse("ProcessedOrders/SearchProcessedOrdersPaged", "from=" + Newtonsoft.Json.JsonConvert.SerializeObject(from) + "&to=" + Newtonsoft.Json.JsonConvert.SerializeObject(to) + "&dateType=" + Newtonsoft.Json.JsonConvert.SerializeObject(dateType) + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static String CreateProcessedOrdersCSV(DateTime? from,DateTime? to,SearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,String sortColumn,Boolean sortDirection,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("ProcessedOrders/CreateProcessedOrdersCSV", "from=" + Newtonsoft.Json.JsonConvert.SerializeObject(from) + "&to=" + Newtonsoft.Json.JsonConvert.SerializeObject(to) + "&dateType=" + Newtonsoft.Json.JsonConvert.SerializeObject(dateType) + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&sortColumn=" + sortColumn + "&sortDirection=" + sortDirection + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static OrderReturnCategory AddReturnCategory(String categoryName,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderReturnCategory>(Factory.GetResponse("ProcessedOrders/AddReturnCategory", "categoryName=" + categoryName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void RenameReturnCategory(Int32 pkItemId,String newName,String ApiToken, String ApiServer)
{
 Factory.GetResponse("ProcessedOrders/RenameReturnCategory", "pkItemId=" + pkItemId + "&newName=" + newName + "", ApiToken, ApiServer); 
}

public static void DeleteReturnCategory(Int32 pkItemId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("ProcessedOrders/DeleteReturnCategory", "pkItemId=" + pkItemId + "", ApiToken, ApiServer); 
}

public static List<OrderRelation> GetProcessedRelatives(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderRelation>>(Factory.GetResponse("ProcessedOrders/GetProcessedRelatives", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<SplitPackaging> GetPackageSplit(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<SplitPackaging>>(Factory.GetResponse("ProcessedOrders/GetPackageSplit", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<AuditEntry> GetProcessedAuditTrail(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<AuditEntry>>(Factory.GetResponse("ProcessedOrders/GetProcessedAuditTrail", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderExtendedProperty> GetProcessedOrderExtendedProperties(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderExtendedProperty>>(Factory.GetResponse("ProcessedOrders/GetProcessedOrderExtendedProperties", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderReturnCategory> GetReturnCategories(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderReturnCategory>>(Factory.GetResponse("ProcessedOrders/GetReturnCategories", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<OrderNote> GetProcessedOrderNotes(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderNote>>(Factory.GetResponse("ProcessedOrders/GetProcessedOrderNotes", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Guid AddOrderNote(Guid pkOrderID,String noteText,Boolean isInternal,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("ProcessedOrders/AddOrderNote", "pkOrderID=" + pkOrderID + "&noteText=" + noteText + "&isInternal=" + isInternal + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ReturnInfo> CreateReturn(Guid pkOrderId,List<RowQty> returnitems,Guid returnLocation,String channelReason,String channelSubReason,String category,String reason,Boolean isReturnBooking,Boolean ignoredValidation,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/CreateReturn", "pkOrderId=" + pkOrderId + "&returnitems=" + Newtonsoft.Json.JsonConvert.SerializeObject(returnitems) + "&returnLocation=" + returnLocation + "&channelReason=" + channelReason + "&channelSubReason=" + channelSubReason + "&category=" + category + "&reason=" + reason + "&isReturnBooking=" + isReturnBooking + "&ignoredValidation=" + ignoredValidation + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void ChangeOrderNote(Guid pkOrderNoteId,String noteText,Boolean isInternal,String ApiToken, String ApiServer)
{
 Factory.GetResponse("ProcessedOrders/ChangeOrderNote", "pkOrderNoteId=" + pkOrderNoteId + "&noteText=" + noteText + "&isInternal=" + isInternal + "", ApiToken, ApiServer); 
}

public static void DeleteOrderNote(Guid pkOrderNoteId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("ProcessedOrders/DeleteOrderNote", "pkOrderNoteId=" + pkOrderNoteId + "", ApiToken, ApiServer); 
}

public static List<ReturnInfo> CreateExchange(Guid pkOrderId,List<RowQty> exchangeItems,Guid despatchLocation,Guid returnLocation,String channelReason,String channelSubReason,String category,String reason,Boolean isBooking,Boolean ignoredValidation,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/CreateExchange", "pkOrderId=" + pkOrderId + "&exchangeItems=" + Newtonsoft.Json.JsonConvert.SerializeObject(exchangeItems) + "&despatchLocation=" + despatchLocation + "&returnLocation=" + returnLocation + "&channelReason=" + channelReason + "&channelSubReason=" + channelSubReason + "&category=" + category + "&reason=" + reason + "&isBooking=" + isBooking + "&ignoredValidation=" + ignoredValidation + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ReturnInfo> CreateResend(Guid pkOrderId,List<RowQty> resendItems,Guid despatchLocation,String category,String reason,Double additionalCost,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/CreateResend", "pkOrderId=" + pkOrderId + "&resendItems=" + Newtonsoft.Json.JsonConvert.SerializeObject(resendItems) + "&despatchLocation=" + despatchLocation + "&category=" + category + "&reason=" + reason + "&additionalCost=" + additionalCost + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<ReturnInfo> CreateFullResend(Guid pkOrderId,Guid despatchLocation,String category,String reason,Double additionalCost,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ReturnInfo>>(Factory.GetResponse("ProcessedOrders/CreateFullResend", "pkOrderId=" + pkOrderId + "&despatchLocation=" + despatchLocation + "&category=" + category + "&reason=" + reason + "&additionalCost=" + additionalCost + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<RefundInfo> GetRefunds(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RefundInfo>>(Factory.GetResponse("ProcessedOrders/GetRefunds", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Boolean CheckOrderFullyReturned(Guid pkOrderId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("ProcessedOrders/CheckOrderFullyReturned", "pkOrderId=" + pkOrderId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
} 
}
}