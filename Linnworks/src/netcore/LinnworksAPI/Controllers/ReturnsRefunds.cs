using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class ReturnsRefundsController : BaseController, IReturnsRefundsController
    {
        public ReturnsRefundsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Acknowledges error responses for a given refund header 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public AcknowledgeRefundErrorsResponse AcknowledgeRefundErrors(AcknowledgeRefundErrorsRequest request)
		{
			var response = GetResponse("ReturnsRefunds/AcknowledgeRefundErrors", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AcknowledgeRefundErrorsResponse>(response);
		}

		/// <summary>
        /// Acknowledges all error responses for a given RMA header 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public AcknowledgeRMAErrorsResponse AcknowledgeRMAErrors(AcknowledgeRMAErrorsRequest request)
		{
			var response = GetResponse("ReturnsRefunds/AcknowledgeRMAErrors", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AcknowledgeRMAErrorsResponse>(response);
		}

		/// <summary>
        /// Action list of booked returns/exchange items for a given order ID. If the return is for a batched item, the batch must be booked in manually. 
        /// </summary>
        /// <param name="pkOrderId">unique ID of the order</param>
        /// <param name="bookedItems">list of returns/exchange items to be actioned</param>
        public void ActionBookedOrder(Guid pkOrderId,List<BookedReturnsExchangeItem> bookedItems)
		{
			GetResponse("ReturnsRefunds/ActionBookedOrder", "pkOrderId=" + pkOrderId + "&bookedItems=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(bookedItems)) + "");
		}

		/// <summary>
        /// Sends a refund to the channel for actioning 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public ActionRefundResponse ActionRefund(ActionRefundRequest request)
		{
			var response = GetResponse("ReturnsRefunds/ActionRefund", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<ActionRefundResponse>(response);
		}

		/// <summary>
        /// Accepts a booked return or exchange in the system 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public ActionRMABookingResponse ActionRMABooking(ActionRMABookingRequest request)
		{
			var response = GetResponse("ReturnsRefunds/ActionRMABooking", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<ActionRMABookingResponse>(response);
		}

		/// <summary>
        /// Creates a refund in the system for approval 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public CreateRefundResponse CreateRefund(CreateRefundRequest request)
		{
			var response = GetResponse("ReturnsRefunds/CreateRefund", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CreateRefundResponse>(response);
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
			var response = GetResponse("ReturnsRefunds/CreateReturnsRefundsCSV", "from=" + System.Net.WebUtility.UrlEncode(from.HasValue ? from.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "&to=" + System.Net.WebUtility.UrlEncode(to.HasValue ? to.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "&dateType=" + dateType.ToString() + "&searchField=" + System.Net.WebUtility.UrlEncode(searchField) + "&exactMatch=" + exactMatch + "&searchTerm=" + System.Net.WebUtility.UrlEncode(searchTerm) + "&sortColumn=" + System.Net.WebUtility.UrlEncode(sortColumn) + "&sortDirection=" + sortDirection + "&historyType=" + historyType.ToString() + "");
            return JsonFormatter.ConvertFromJson<String>(response);
		}

		/// <summary>
        /// Creates an RMA booking in the system 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public CreateRMABookingResponse CreateRMABooking(CreateRMABookingRequest request)
		{
			var response = GetResponse("ReturnsRefunds/CreateRMABooking", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CreateRMABookingResponse>(response);
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
        /// Deletes all lines from the given refund header that have not yet been processed, or acknowledged as errors, removing it from the "Actionable Refunds" screen. If no lines are left, the header row is deleted 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public DeleteRefundResponse DeleteRefund(DeleteRefundRequest request)
		{
			var response = GetResponse("ReturnsRefunds/DeleteRefund", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DeleteRefundResponse>(response);
		}

		/// <summary>
        /// Deletes all lines from the given RMA header that have not yet been processed, or acknowledged as errors, removing it from the "RMA Bookings" screen. If no lines are left, the header row is deleted 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public DeleteRMAResponse DeleteRMA(DeleteRMARequest request)
		{
			var response = GetResponse("ReturnsRefunds/DeleteRMA", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DeleteRMAResponse>(response);
		}

		/// <summary>
        /// Edit booked exchange/return item 
        /// </summary>
        /// <param name="pkOrderId">unique ID of the order</param>
        /// <param name="bookedReturnsExchangeItem">The updated booked return/exchange item object</param>
        public void EditBookedItemInfo(Guid pkOrderId,BookedReturnsExchangeItem bookedReturnsExchangeItem)
		{
			GetResponse("ReturnsRefunds/EditBookedItemInfo", "pkOrderId=" + pkOrderId + "&bookedReturnsExchangeItem=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(bookedReturnsExchangeItem)) + "");
		}

		/// <summary>
        /// Returns a paged list of booked refund headers 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetActionableRefundHeadersResponse GetActionableRefundHeaders(GetActionableRefundHeadersRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetActionableRefundHeaders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetActionableRefundHeadersResponse>(response);
		}

		/// <summary>
        /// Returns a paged list of booked refund headers 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetActionableRMAHeadersResponse GetActionableRMAHeaders(GetActionableRMAHeadersRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetActionableRMAHeaders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetActionableRMAHeadersResponse>(response);
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
        /// Returns a paged list of processed or acknowledged error refund headers 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetProcessedOrAckedErrorRefundHeadersResponse GetProcessedOrAckedErrorRefundHeaders(GetProcessedOrAckedErrorRefundHeadersRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetProcessedOrAckedErrorRefundHeaders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetProcessedOrAckedErrorRefundHeadersResponse>(response);
		}

		/// <summary>
        /// Returns a paged list of processed or acknowledged error RMA headers 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetProcessedOrAckedErrorRMAHeadersResponse GetProcessedOrAckedErrorRMAHeaders(GetProcessedOrAckedErrorRMAHeadersRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetProcessedOrAckedErrorRMAHeaders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetProcessedOrAckedErrorRMAHeadersResponse>(response);
		}

		/// <summary>
        /// Returns all refund headers associated with the given order ID 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetRefundHeadersByOrderIdResponse GetRefundHeadersByOrderId(GetRefundHeadersByOrderIdRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetRefundHeadersByOrderId", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetRefundHeadersByOrderIdResponse>(response);
		}

		/// <summary>
        /// Returns a refund, given its header ID 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetRefundLinesByHeaderIdResponse GetRefundLinesByHeaderId(GetRefundLinesByHeaderIdRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetRefundLinesByHeaderId", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetRefundLinesByHeaderIdResponse>(response);
		}

		/// <summary>
        /// Returns channel-specific information regarding the types of refund that can be applied to the given order 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetRefundOptionsResponse GetRefundOptions(GetRefundOptionsRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetRefundOptions", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetRefundOptionsResponse>(response);
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
        /// Returns channel-specific information regarding the types of refund that can be applied to the given order 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetReturnOptionsResponse GetReturnOptions(GetReturnOptionsRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetReturnOptions", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetReturnOptionsResponse>(response);
		}

		/// <summary>
        /// Returns all RMA headers associated with the given order ID 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public GetRMAHeadersByOrderIdResponse GetRMAHeadersByOrderId(GetRMAHeadersByOrderIdRequest request)
		{
			var response = GetResponse("ReturnsRefunds/GetRMAHeadersByOrderId", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetRMAHeadersByOrderIdResponse>(response);
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
			GetResponse("ReturnsRefunds/RefundOrder", "pkOrderId=" + pkOrderId + "&refundReference=" + System.Net.WebUtility.UrlEncode(refundReference) + "");
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
			var response = GetResponse("ReturnsRefunds/SearchReturnsRefundsPaged", "from=" + System.Net.WebUtility.UrlEncode(from.HasValue ? from.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "&to=" + System.Net.WebUtility.UrlEncode(to.HasValue ? to.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "&dateType=" + dateType.ToString() + "&searchField=" + System.Net.WebUtility.UrlEncode(searchField) + "&exactMatch=" + exactMatch + "&searchTerm=" + System.Net.WebUtility.UrlEncode(searchTerm) + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage + "&historyType=" + historyType.ToString() + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<ReturnsRefundsWeb>>(response);
		}

		/// <summary>
        /// Updates an existing refund in the system. Requires create and delete permissions 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public UpdateRefundResponse UpdateRefund(UpdateRefundRequest request)
		{
			var response = GetResponse("ReturnsRefunds/UpdateRefund", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<UpdateRefundResponse>(response);
		}

		/// <summary>
        /// Updates an RMA booking in the system. Requires create and delete permissions 
        /// </summary>
        /// <param name="request">The request class for this call</param>
        public UpdateRMABookingResponse UpdateRMABooking(UpdateRMABookingRequest request)
		{
			var response = GetResponse("ReturnsRefunds/UpdateRMABooking", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<UpdateRMABookingResponse>(response);
		} 
    }
}