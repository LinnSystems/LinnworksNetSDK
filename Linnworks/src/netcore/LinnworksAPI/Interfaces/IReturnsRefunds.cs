using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{ 
    public interface IReturnsRefundsController
	{
		AcknowledgeRefundErrorsResponse AcknowledgeRefundErrors(AcknowledgeRefundErrorsRequest request);
		AcknowledgeRMAErrorsResponse AcknowledgeRMAErrors(AcknowledgeRMAErrorsRequest request);
		void ActionBookedOrder(Guid pkOrderId,List<BookedReturnsExchangeItem> bookedItems);
		ActionRefundResponse ActionRefund(ActionRefundRequest request);
		ActionRMABookingResponse ActionRMABooking(ActionRMABookingRequest request);
		CreateRefundResponse CreateRefund(CreateRefundRequest request);
		String CreateReturnsRefundsCSV(DateTime? from,DateTime? to,ReturnsRefundsSearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,String sortColumn,Boolean sortDirection,HistoryType historyType = HistoryType.RETURNS);
		CreateRMABookingResponse CreateRMABooking(CreateRMABookingRequest request);
		void DeleteBookedItem(Guid pkOrderId,Int32 pkReturnId);
		void DeleteBookedOrder(Guid pkOrderId);
		void DeletePendingRefundItem(Guid fkOrderId,Guid pkRefundRowId);
		DeleteRefundResponse DeleteRefund(DeleteRefundRequest request);
		DeleteRMAResponse DeleteRMA(DeleteRMARequest request);
		void EditBookedItemInfo(Guid pkOrderId,BookedReturnsExchangeItem bookedReturnsExchangeItem);
		GetActionableRefundHeadersResponse GetActionableRefundHeaders(GetActionableRefundHeadersRequest request);
		GetActionableRMAHeadersResponse GetActionableRMAHeaders(GetActionableRMAHeadersRequest request);
		List<BookedReturnsExchangeOrder> GetBookedReturnsExchangeOrders();
		GetProcessedOrAckedErrorRefundHeadersResponse GetProcessedOrAckedErrorRefundHeaders(GetProcessedOrAckedErrorRefundHeadersRequest request);
		GetProcessedOrAckedErrorRMAHeadersResponse GetProcessedOrAckedErrorRMAHeaders(GetProcessedOrAckedErrorRMAHeadersRequest request);
		GetRefundHeadersByOrderIdResponse GetRefundHeadersByOrderId(GetRefundHeadersByOrderIdRequest request);
		GetRefundLinesByHeaderIdResponse GetRefundLinesByHeaderId(GetRefundLinesByHeaderIdRequest request);
		GetRefundOptionsResponse GetRefundOptions(GetRefundOptionsRequest request);
		List<RefundOrder> GetRefundOrders();
		GetReturnOptionsResponse GetReturnOptions(GetReturnOptionsRequest request);
		GetRMAHeadersByOrderIdResponse GetRMAHeadersByOrderId(GetRMAHeadersByOrderIdRequest request);
		List<SearchField> GetSearchTypes(HistoryType historyType);
		Double GetTotalRefunds(Guid fkOrderId);
		List<WarehouseLocation> GetWarehouseLocations();
		void RefundOrder(Guid pkOrderId,String refundReference);
		GenericPagedResult<ReturnsRefundsWeb> SearchReturnsRefundsPaged(DateTime? from,DateTime? to,ReturnsRefundsSearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,Int32 pageNum,Int32 numEntriesPerPage,HistoryType historyType = HistoryType.RETURNS);
		UpdateRefundResponse UpdateRefund(UpdateRefundRequest request);
		UpdateRMABookingResponse UpdateRMABooking(UpdateRMABookingRequest request);
	} 
}