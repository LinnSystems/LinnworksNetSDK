using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IProcessedOrdersController
	{
		Guid AddOrderNote(Guid pkOrderID,String noteText,Boolean isInternal);
		OrderReturnCategory AddReturnCategory(String categoryName);
		void ChangeOrderNote(Guid pkOrderNoteId,String noteText,Boolean isInternal,Byte? noteTypeId = null);
		Boolean CheckOrderFullyReturned(Guid pkOrderId);
		List<ReturnInfo> CreateExchange(Guid pkOrderId,List<RowQty> exchangeItems,Guid despatchLocation,Guid returnLocation,String channelReason,String channelSubReason,String category,String reason,Boolean isBooking,Boolean ignoredValidation);
		List<ReturnInfo> CreateFullResend(Guid pkOrderId,Guid despatchLocation,String category,String reason,Double additionalCost);
		List<ReturnInfo> CreateResend(Guid pkOrderId,List<RowQty> resendItems,Guid despatchLocation,String category,String reason,Double additionalCost);
		List<ReturnInfo> CreateReturn(Guid pkOrderId,List<RowQty> returnitems,Guid returnLocation,String channelReason,String channelSubReason,String category,String reason,Boolean isReturnBooking,Boolean ignoredValidation);
		void DeleteOrderNote(Guid pkOrderNoteId);
		void DeleteReturnCategory(Int32 pkItemId);
		DownloadOrdersToCSVResponse DownloadOrdersToCSV(DownloadOrdersToCSVRequest request);
		List<ChannelRefundReason> GetChannelRefundReasons(Guid pkOrderId);
		ProcessedOrderWeb GetOrderInfo(Guid pkOrderId);
		GetOrderTrackingURLsResponse GetOrderTrackingURLs(GetOrderTrackingURLsRequest request);
		List<SplitPackaging> GetPackageSplit(Guid pkOrderId);
		List<AuditEntry> GetProcessedAuditTrail(Guid pkOrderId);
		List<OrderExtendedProperty> GetProcessedOrderExtendedProperties(Guid pkOrderId);
		List<ProcessedOrderNote> GetProcessedOrderNotes(Guid pkOrderId);
		List<ProcessedOrderRelation> GetProcessedRelatives(Guid pkOrderId);
		List<ServiceItem> GetRefundableServiceItems(Guid pkOrderId);
		List<RefundInfo> GetRefunds(Guid pkOrderId);
		RefundScreenOptions GetRefundsOptions(Guid pkOrderId);
		List<OrderReturnCategory> GetReturnCategories();
		List<OrderItemReturnInfo> GetReturnItemsInfo(Guid pkOrderId);
		ReturnOrderHeader GetReturnOrderInfo(Guid pkOrderId,Boolean includeRefundLink);
		List<ReturnInfo> GetReturnsExchanges(Guid pkOrderId);
		ExistingRefundTotal GetTotalRefunds(Guid pkOrderId,Boolean? includeBookings = null);
		ValidationResult IsRefundValid(Guid pkOrderId,List<RefundItem> refundItems);
		Boolean IsRefundValidationRequiredByOrderId(Guid pkOrderId);
		void MarkManualRefundsAsActioned(Guid pkOrderId);
		List<RefundInfo> RefundFreeText(Guid pkOrderId,List<RefundItem> refundItems);
		List<RefundInfo> RefundServices(Guid pkOrderId,List<RefundItem> refundItems);
		List<RefundInfo> RefundShipping(Guid pkOrderId);
		void RenameReturnCategory(Int32 pkItemId,String newName);
		SearchProcessedOrdersResponse SearchProcessedOrders(SearchProcessedOrdersRequest request);
		GenericPagedResult<ProcessedOrderWeb> SearchProcessedOrdersPaged(DateTime? from,DateTime? to,SearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,Int32 pageNum,Int32 numEntriesPerPage);
		ValidationResult ValidateCompleteOrderRefund(Guid pkOrderId);
	} 
}