using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class ReturnsRefundsController : BaseController, IReturnsRefundsController
    {
        public ReturnsRefundsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Action list of booked returns/exchange items for a given order ID. If the return is for a batched item, the batch must be booked in manually. 
        /// </summary>
        /// <param name="pkOrderId">unique ID of the order</param>
        /// <param name="bookedItems">list of returns/exchange items to be actioned</param>
        public void ActionBookedOrder(Guid pkOrderId,List<BookedReturnsExchangeItem> bookedItems)
		{
			GetResponse("ReturnsRefunds/ActionBookedOrder", "pkOrderId=" + pkOrderId + "&bookedItems=" + JsonFormatter.ConvertToJson(bookedItems) + "");
		}

		/// <summary>
        /// Creates a CSV file of the search result for download 
        /// </summary>
        /// <param name="from">The lower end of the date range to search. Can be null if searching for 'all dates'. Maximum range is 3 months.</param>
        /// <param name="to">The upper end of the date range to search. Can be null if searching for 'all dates'. Maximum range is 3 months.</param>
        /// <param name="dateType">The search type (e.g. ALLDATES)</param>
        /// <param name="searchField">The field to search by. Can be found by calling GetSearchTypes.</param>
        /// <param name="exactMatch">Set to true if an exact match is required for the search data.</param>
        /// <param name="searchTerm">The term which you are searching for.</param>
        /// <param name="sortColumn">The column to sort by</param>
        /// <param name="sortDirection">The sort direction (true = ascending, false = descending).</param>
        /// <param name="historyType">Search type. Allow RETURNS or REFUNDS</param>
        /// <returns>Returns the URL of the CSV file</returns>
        public String CreateReturnsRefundsCSV(DateTime? from,DateTime? to,ReturnsRefundsSearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,String sortColumn,Boolean sortDirection,HistoryType historyType = HistoryType.RETURNS)
		{
			var response = GetResponse("ReturnsRefunds/CreateReturnsRefundsCSV", "from=" + JsonFormatter.ConvertToJson(from) + "&to=" + JsonFormatter.ConvertToJson(to) + "&dateType=" + dateType.ToString() + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&sortColumn=" + sortColumn + "&sortDirection=" + sortDirection + "&historyType=" + historyType.ToString() + "");
            return JsonFormatter.ConvertFromJson<String>(response);
		}

		/// <summary>
        /// Delete a booked returns/exchange order item 
        /// </summary>
        /// <param name="pkOrderId">unique ID of the order</param>
        /// <param name="pkReturnId">unique row ID of the return/exchange item</param>
        public void DeleteBookedItem(Guid pkOrderId,Int32 pkReturnId)
		{
			GetResponse("ReturnsRefunds/DeleteBookedItem", "pkOrderId=" + pkOrderId + "&pkReturnId=" + pkReturnId + "");
		}

		/// <summary>
        /// Deletes a returns/exchange order 
        /// </summary>
        /// <param name="pkOrderId">unique ID of the order</param>
        /// <returns>List of refund order items</returns>
        public void DeleteBookedOrder(Guid pkOrderId)
		{
			GetResponse("ReturnsRefunds/DeleteBookedOrder", "pkOrderId=" + pkOrderId + "");
		}

		/// <summary>
        /// Delete a refund item 
        /// </summary>
        /// <param name="fkOrderId">unique order ID of the refund order</param>
        /// <param name="pkRefundRowId">unique refund row ID of the refund item to delete</param>
        public void DeletePendingRefundItem(Guid fkOrderId,Guid pkRefundRowId)
		{
			GetResponse("ReturnsRefunds/DeletePendingRefundItem", "fkOrderId=" + fkOrderId + "&pkRefundRowId=" + pkRefundRowId + "");
		}

		/// <summary>
        /// Edit booked exchange/return item 
        /// </summary>
        /// <param name="pkOrderId">unique ID of the order</param>
        /// <param name="bookedReturnsExchangeItem">The updated booked return/exchange item object</param>
        public void EditBookedItemInfo(Guid pkOrderId,BookedReturnsExchangeItem bookedReturnsExchangeItem)
		{
			GetResponse("ReturnsRefunds/EditBookedItemInfo", "pkOrderId=" + pkOrderId + "&bookedReturnsExchangeItem=" + JsonFormatter.ConvertToJson(bookedReturnsExchangeItem) + "");
		}

		/// <summary>
        /// Gets all booked returns/exchange order items for a given order ID 
        /// </summary>
        /// <returns>List of refund order items</returns>
        public List<BookedReturnsExchangeItem> GetBookedReturnsExchangeItems(Guid pkOrderId)
		{
			var response = GetResponse("ReturnsRefunds/GetBookedReturnsExchangeItems", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<BookedReturnsExchangeItem>>(response);
		}

		/// <summary>
        /// Gets all booked returns/exchange orders 
        /// </summary>
        /// <returns>List of refund order items</returns>
        public List<BookedReturnsExchangeOrder> GetBookedReturnsExchangeOrders()
		{
			var response = GetResponse("ReturnsRefunds/GetBookedReturnsExchangeOrders", "");
            return JsonFormatter.ConvertFromJson<List<BookedReturnsExchangeOrder>>(response);
		}

		/// <summary>
        /// Returns a paged list of booked refund lines 
        /// </summary>
        /// <param name="page">The page number to retrieve</param>
        public OrderRefundLinesPaged GetNotActionedRefundLines(Int32 page)
		{
			var response = GetResponse("ReturnsRefunds/GetNotActionedRefundLines", "page=" + page + "");
            return JsonFormatter.ConvertFromJson<OrderRefundLinesPaged>(response);
		}

		/// <summary>
        /// Gets all refund order items for all orders 
        /// </summary>
        /// <returns>List of refund order items</returns>
        public List<RefundOrder> GetRefundOrders()
		{
			var response = GetResponse("ReturnsRefunds/GetRefundOrders", "");
            return JsonFormatter.ConvertFromJson<List<RefundOrder>>(response);
		}

		/// <summary>
        /// Gets all refund order items for an order 
        /// </summary>
        /// <param name="pkOrderId">Primary key for order</param>
        /// <param name="refundReference">Refund reference to return</param>
        /// <returns>List of refund order items</returns>
        public List<RefundInfo> GetRefunds(Guid pkOrderId,Guid? refundReference = null)
		{
			var response = GetResponse("ReturnsRefunds/GetRefunds", "pkOrderId=" + pkOrderId + "&refundReference=" + JsonFormatter.ConvertToJson(refundReference) + "");
            return JsonFormatter.ConvertFromJson<List<RefundInfo>>(response);
		}

		/// <summary>
        /// Gets a list of valid search types. These are needed to search processed orders. 
        /// </summary>
        /// <param name="historyType">Search type. Allow RETURNS or REFUNDS</param>
        /// <returns>All search types</returns>
        public List<SearchField> GetSearchTypes(HistoryType historyType)
		{
			var response = GetResponse("ReturnsRefunds/GetSearchTypes", "historyType=" + historyType.ToString() + "");
            return JsonFormatter.ConvertFromJson<List<SearchField>>(response);
		}

		/// <summary>
        /// Gets the refundable amunt of an order 
        /// </summary>
        /// <param name="fkOrderId">unique order ID of the order</param>
        /// <returns>Refundable amount</returns>
        public Double GetTotalRefunds(Guid fkOrderId)
		{
			var response = GetResponse("ReturnsRefunds/GetTotalRefunds", "fkOrderId=" + fkOrderId + "");
            return JsonFormatter.ConvertFromJson<Double>(response);
		}

		/// <summary>
        /// Gets all warehouse locations 
        /// </summary>
        /// <returns>List of warehouse names and location IDs</returns>
        public List<WarehouseLocation> GetWarehouseLocations()
		{
			var response = GetResponse("ReturnsRefunds/GetWarehouseLocations", "");
            return JsonFormatter.ConvertFromJson<List<WarehouseLocation>>(response);
		}

		/// <summary>
        /// Refund an order given the order ID 
        /// </summary>
        /// <param name="pkOrderId">unique ID of the order</param>
        /// <param name="refundReference">Refund Reference Id</param>
        /// <returns>List of refund order items</returns>
        public void RefundOrder(Guid pkOrderId,String refundReference)
		{
			GetResponse("ReturnsRefunds/RefundOrder", "pkOrderId=" + pkOrderId + "&refundReference=" + refundReference + "");
		}

		/// <summary>
        /// Searches through returns/refunds history that meets the parameters' criteria 
        /// </summary>
        /// <param name="from">The lower end of the date range to search. Can be null if searching for 'all dates'. Maximum range is 3 months.</param>
        /// <param name="to">The upper end of the date range to search. Can be null if searching for 'all dates'. Maximum range is 3 months.</param>
        /// <param name="dateType">The search type (e.g. ALLDATES)</param>
        /// <param name="searchField">The field to search by. Can be found by calling GetSearchTypes.</param>
        /// <param name="exactMatch">Set to true if an exact match is required for the search data.</param>
        /// <param name="searchTerm">The term which you are searching for.</param>
        /// <param name="pageNum">The page number of the request.</param>
        /// <param name="numEntriesPerPage">The number of entries required on a page. Maximum 200.</param>
        /// <param name="historyType">Search type. Allow RETURNS or REFUNDS</param>
        /// <returns>Returns the requested list of processed orders. The columns returned can be changed through the SetColumns method.</returns>
        public GenericPagedResult<ReturnsRefundsWeb> SearchReturnsRefundsPaged(DateTime? from,DateTime? to,ReturnsRefundsSearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,Int32 pageNum,Int32 numEntriesPerPage,HistoryType historyType = HistoryType.RETURNS)
		{
			var response = GetResponse("ReturnsRefunds/SearchReturnsRefundsPaged", "from=" + JsonFormatter.ConvertToJson(from) + "&to=" + JsonFormatter.ConvertToJson(to) + "&dateType=" + dateType.ToString() + "&searchField=" + searchField + "&exactMatch=" + exactMatch + "&searchTerm=" + searchTerm + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage + "&historyType=" + historyType.ToString() + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<ReturnsRefundsWeb>>(response);
		} 
    }
}