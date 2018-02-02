using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IReturnsRefundsController
	{
		void ActionBookedOrder(Guid pkOrderId,List<BookedReturnsExchangeItem> bookedItems);
		String CreateReturnsRefundsCSV(DateTime? from,DateTime? to,ReturnsRefundsSearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,String sortColumn,Boolean sortDirection,HistoryType historyType = HistoryType.RETURNS);
		void DeleteBookedItem(Guid pkOrderId,Int32 pkReturnId);
		void DeleteBookedOrder(Guid pkOrderId);
		void DeletePendingRefundItem(Guid fkOrderId,Guid pkRefundRowId);
		void EditBookedItemInfo(Guid pkOrderId,BookedReturnsExchangeItem bookedReturnsExchangeItem);
		List<BookedReturnsExchangeItem> GetBookedReturnsExchangeItems(Guid pkOrderId);
		List<BookedReturnsExchangeOrder> GetBookedReturnsExchangeOrders();
		OrderRefundLinesPaged GetNotActionedRefundLines(Int32 page);
		List<RefundOrder> GetRefundOrders();
		List<RefundInfo> GetRefunds(Guid pkOrderId,Guid? refundReference = null);
		List<SearchField> GetSearchTypes(HistoryType historyType);
		Double GetTotalRefunds(Guid fkOrderId);
		List<WarehouseLocation> GetWarehouseLocations();
		void RefundOrder(Guid pkOrderId,String refundReference);
		GenericPagedResult<ReturnsRefundsWeb> SearchReturnsRefundsPaged(DateTime? from,DateTime? to,ReturnsRefundsSearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,Int32 pageNum,Int32 numEntriesPerPage,HistoryType historyType = HistoryType.RETURNS);
	} 
}