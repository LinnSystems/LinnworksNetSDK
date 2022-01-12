using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class ProcessedOrdersController : BaseController, IProcessedOrdersController
    {
        public ProcessedOrdersController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Use this call to add a new note to an order 
        /// </summary>
        /// <param name="pkOrderID">The order id</param>
        /// <param name="noteText">The note text</param>
        /// <param name="isInternal">True if the note should be internal, False if it shouldn't</param>
        /// <returns>The id of the new note</returns>
        public Guid AddOrderNote(Guid pkOrderID,String noteText,Boolean isInternal)
		{
			var response = GetResponse("ProcessedOrders/AddOrderNote", "pkOrderID=" + pkOrderID + "&noteText=" + System.Net.WebUtility.UrlEncode(noteText) + "&isInternal=" + isInternal + "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Use this call to add a new return category. 
        /// </summary>
        /// <param name="categoryName">The name of the category to add.</param>
        /// <returns>A return category object containing details of the new category.</returns>
        public OrderReturnCategory AddReturnCategory(String categoryName)
		{
			var response = GetResponse("ProcessedOrders/AddReturnCategory", "categoryName=" + System.Net.WebUtility.UrlEncode(categoryName) + "");
            return JsonFormatter.ConvertFromJson<OrderReturnCategory>(response);
		}

		/// <summary>
        /// Edit an existing order note 
        /// </summary>
        /// <param name="pkOrderNoteId">Primary key for order note</param>
        /// <param name="noteText">New note message</param>
        /// <param name="isInternal">Whether the note is an internal note</param>
        /// <param name="noteTypeId">Set the type of note</param>
        public void ChangeOrderNote(Guid pkOrderNoteId,String noteText,Boolean isInternal,Byte? noteTypeId = null)
		{
			GetResponse("ProcessedOrders/ChangeOrderNote", "pkOrderNoteId=" + pkOrderNoteId + "&noteText=" + System.Net.WebUtility.UrlEncode(noteText) + "&isInternal=" + isInternal + "&noteTypeId=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(noteTypeId)) + "");
		}

		/// <summary>
        /// Checks if order was fully returned 
        /// </summary>
        /// <param name="pkOrderId">Primary key for an order</param>
        public Boolean CheckOrderFullyReturned(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/CheckOrderFullyReturned", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <param name="pkOrderId">The order id</param>
        /// <param name="exchangeItems">A list of items to be exchanged, including quantity, scrap, refund, etc.</param>
        /// <param name="despatchLocation">The id of the location to despatch replacement items from</param>
        /// <param name="returnLocation">The id of the location to return stock to</param>
        /// <param name="channelReason">Channel reason - required if a refund on the channel is required</param>
        /// <param name="channelSubReason">Channel subreason - required if a refund on the channel is required.</param>
        /// <param name="category">The refund category</param>
        /// <param name="reason">The reason for the reason</param>
        /// <param name="isBooking">True if it is a exchange booking, False if it is a new exchange</param>
        /// <param name="ignoredValidation">True if failed validation has been ignored (see IsRefundValid). Otherwise, false. When set to true, refunds will not be automatically actioned on the channel. Ignored if creating a booking as a refund is not created at this stage.</param>
        /// <returns>Returns information about the new exchanges</returns>
        public List<ReturnInfo> CreateExchange(Guid pkOrderId,List<RowQty> exchangeItems,Guid despatchLocation,Guid returnLocation,String channelReason,String channelSubReason,String category,String reason,Boolean isBooking,Boolean ignoredValidation)
		{
			var response = GetResponse("ProcessedOrders/CreateExchange", "pkOrderId=" + pkOrderId + "&exchangeItems=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(exchangeItems)) + "&despatchLocation=" + despatchLocation + "&returnLocation=" + returnLocation + "&channelReason=" + System.Net.WebUtility.UrlEncode(channelReason) + "&channelSubReason=" + System.Net.WebUtility.UrlEncode(channelSubReason) + "&category=" + System.Net.WebUtility.UrlEncode(category) + "&reason=" + System.Net.WebUtility.UrlEncode(reason) + "&isBooking=" + isBooking + "&ignoredValidation=" + ignoredValidation + "");
            return JsonFormatter.ConvertFromJson<List<ReturnInfo>>(response);
		}

		public List<ReturnInfo> CreateFullResend(Guid pkOrderId,Guid despatchLocation,String category,String reason,Double additionalCost)
		{
			var response = GetResponse("ProcessedOrders/CreateFullResend", "pkOrderId=" + pkOrderId + "&despatchLocation=" + despatchLocation + "&category=" + System.Net.WebUtility.UrlEncode(category) + "&reason=" + System.Net.WebUtility.UrlEncode(reason) + "&additionalCost=" + additionalCost + "");
            return JsonFormatter.ConvertFromJson<List<ReturnInfo>>(response);
		}

		/// <summary>
        /// Creates a resend 
        /// </summary>
        /// <param name="pkOrderId">Order ID that needs to be resend</param>
        /// <param name="resendItems">Resend items information</param>
        /// <param name="despatchLocation">Location ID where from resend be despatched</param>
        /// <param name="category">Category</param>
        /// <param name="reason">Resond reason</param>
        /// <param name="additionalCost">Order-level additional cost</param>
        public List<ReturnInfo> CreateResend(Guid pkOrderId,List<RowQty> resendItems,Guid despatchLocation,String category,String reason,Double additionalCost)
		{
			var response = GetResponse("ProcessedOrders/CreateResend", "pkOrderId=" + pkOrderId + "&resendItems=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(resendItems)) + "&despatchLocation=" + despatchLocation + "&category=" + System.Net.WebUtility.UrlEncode(category) + "&reason=" + System.Net.WebUtility.UrlEncode(reason) + "&additionalCost=" + additionalCost + "");
            return JsonFormatter.ConvertFromJson<List<ReturnInfo>>(response);
		}

		/// <summary>
        /// Use this call to create a new return 
        /// </summary>
        /// <param name="pkOrderId">The order id</param>
        /// <param name="returnitems">A list of items to be returned, including quantity, scrap, refund, etc.</param>
        /// <param name="returnLocation">The id of the location to return stock to</param>
        /// <param name="channelReason">Channel reason - required if a refund on the channel is required</param>
        /// <param name="channelSubReason">Channel subreason - required if a refund on the channel is required.</param>
        /// <param name="category">The refund category</param>
        /// <param name="reason">The reason for the reason</param>
        /// <param name="isReturnBooking">True if it is a return booking, False if it is a new return</param>
        /// <param name="ignoredValidation">True if failed validation has been ignored (see IsRefundValid). Otherwise, false. When set to true, refunds will not be automatically actioned on the channel. Ignored if creating a booking as a refund is not created at this stage.</param>
        /// <returns>Returns information about the new returns</returns>
        public List<ReturnInfo> CreateReturn(Guid pkOrderId,List<RowQty> returnitems,Guid returnLocation,String channelReason,String channelSubReason,String category,String reason,Boolean isReturnBooking,Boolean ignoredValidation)
		{
			var response = GetResponse("ProcessedOrders/CreateReturn", "pkOrderId=" + pkOrderId + "&returnitems=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(returnitems)) + "&returnLocation=" + returnLocation + "&channelReason=" + System.Net.WebUtility.UrlEncode(channelReason) + "&channelSubReason=" + System.Net.WebUtility.UrlEncode(channelSubReason) + "&category=" + System.Net.WebUtility.UrlEncode(category) + "&reason=" + System.Net.WebUtility.UrlEncode(reason) + "&isReturnBooking=" + isReturnBooking + "&ignoredValidation=" + ignoredValidation + "");
            return JsonFormatter.ConvertFromJson<List<ReturnInfo>>(response);
		}

		/// <summary>
        /// Delete an existing order note 
        /// </summary>
        /// <param name="pkOrderNoteId">Primary key for order note</param>
        public void DeleteOrderNote(Guid pkOrderNoteId)
		{
			GetResponse("ProcessedOrders/DeleteOrderNote", "pkOrderNoteId=" + pkOrderNoteId + "");
		}

		/// <summary>
        /// Use this call to delete an existing return category. 
        /// </summary>
        /// <param name="pkItemId">The id of the category to delete.</param>
        public void DeleteReturnCategory(Int32 pkItemId)
		{
			GetResponse("ProcessedOrders/DeleteReturnCategory", "pkItemId=" + pkItemId + "");
		}

		/// <summary>
        /// Download Processed Orders to CSV 
        /// </summary>
        /// <param name="request">Request parameter populated with search critera for the file download</param>
        /// <param name="cancellationToken">Request parameter populated with search critera for the file download</param>
        public DownloadOrdersToCSVResponse DownloadOrdersToCSV(DownloadOrdersToCSVRequest request)
		{
			var response = GetResponse("ProcessedOrders/DownloadOrdersToCSV", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DownloadOrdersToCSVResponse>(response);
		}

		/// <summary>
        /// Use this call to get a list of valid channel refund reasons for a given order. These are needed for channel refunds. 
        /// </summary>
        /// <param name="pkOrderId">The order id to get reasons for</param>
        /// <returns>A list of reasons and subreasons. Null if channel refunds have not been implemented for the order's channel.</returns>
        public List<ChannelRefundReason> GetChannelRefundReasons(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetChannelRefundReasons", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<ChannelRefundReason>>(response);
		}

		/// <summary>
        /// Use this call to retrieve detailed information about a processed order (header level). 
        /// </summary>
        /// <param name="pkOrderId">The id of the order.</param>
        /// <returns>Detailed order information</returns>
        public ProcessedOrderWeb GetOrderInfo(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetOrderInfo", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<ProcessedOrderWeb>(response);
		}

		/// <summary>
        /// Use this call to retrieve detailed TrackingURL for orders Vendor and TrackingNumber. 
        /// </summary>
        /// <param name="request">The request for TrackingURL.</param>
        /// <returns>Tracking information</returns>
        public GetOrderTrackingURLsResponse GetOrderTrackingURLs(GetOrderTrackingURLsRequest request)
		{
			var response = GetResponse("ProcessedOrders/GetOrderTrackingURLs", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetOrderTrackingURLsResponse>(response);
		}

		/// <summary>
        /// Use this call to get split packaging information for an order 
        /// </summary>
        /// <param name="pkOrderId">The order id</param>
        /// <returns>A list of items and their corresponding bins</returns>
        public List<SplitPackaging> GetPackageSplit(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetPackageSplit", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<SplitPackaging>>(response);
		}

		/// <summary>
        /// Use this call to get an order's audit trail information 
        /// </summary>
        /// <param name="pkOrderId">The order id</param>
        /// <returns>A list of audit entries</returns>
        public List<AuditEntry> GetProcessedAuditTrail(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetProcessedAuditTrail", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<AuditEntry>>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of order-level extended properties. 
        /// </summary>
        /// <param name="pkOrderId">The order id</param>
        /// <returns>A list of extended properties and their values</returns>
        public List<OrderExtendedProperty> GetProcessedOrderExtendedProperties(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetProcessedOrderExtendedProperties", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<OrderExtendedProperty>>(response);
		}

		/// <summary>
        /// Use this call to get a list of order notes for a given order 
        /// </summary>
        /// <param name="pkOrderId">The order id</param>
        /// <returns>List of order notes</returns>
        public List<ProcessedOrderNote> GetProcessedOrderNotes(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetProcessedOrderNotes", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<ProcessedOrderNote>>(response);
		}

		/// <summary>
        /// Use this call to get a list of related orders. 
        /// </summary>
        /// <param name="pkOrderId">The order id</param>
        /// <returns>A list of related orders</returns>
        public List<ProcessedOrderRelation> GetProcessedRelatives(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetProcessedRelatives", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<ProcessedOrderRelation>>(response);
		}

		/// <summary>
        /// Use this call to get a list of service items which can be refunded. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order which the service items belong to.</param>
        /// <returns>A list of service items which can be refunded</returns>
        public List<ServiceItem> GetRefundableServiceItems(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetRefundableServiceItems", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<ServiceItem>>(response);
		}

		/// <summary>
        /// Gets all refund order items for an order 
        /// </summary>
        /// <param name="pkOrderId">Primary key for order</param>
        /// <returns>List of refund order items</returns>
        public List<RefundInfo> GetRefunds(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetRefunds", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<RefundInfo>>(response);
		}

		/// <summary>
        /// Use this call to get information about manual/automated refunds (which kinds of refunds are possible) for a given order. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order</param>
        /// <returns>Refund information</returns>
        public RefundScreenOptions GetRefundsOptions(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetRefundsOptions", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<RefundScreenOptions>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of return categories. Used for refunds, resends and exchanges. 
        /// </summary>
        /// <returns>A list of return categories.</returns>
        public List<OrderReturnCategory> GetReturnCategories()
		{
			var response = GetResponse("ProcessedOrders/GetReturnCategories", "");
            return JsonFormatter.ConvertFromJson<List<OrderReturnCategory>>(response);
		}

		/// <summary>
        /// Use this call to get a list of all items on an order, including return quantities and resend quantities. The information can be used to calculate how many items has already been returned. 
        /// </summary>
        /// <param name="pkOrderId">The order id to get the returns for</param>
        /// <returns>A list of items including returns/resends</returns>
        public List<OrderItemReturnInfo> GetReturnItemsInfo(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetReturnItemsInfo", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<OrderItemReturnInfo>>(response);
		}

		/// <summary>
        /// Use this call to get basic information about a processed order (e.g. source, subsource, address) as seen on the Returns/Refunds screens. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order.</param>
        /// <param name="includeRefundLink">Is a refund link required (not available for all channels).</param>
        /// <returns>Basic order information</returns>
        public ReturnOrderHeader GetReturnOrderInfo(Guid pkOrderId,Boolean includeRefundLink)
		{
			var response = GetResponse("ProcessedOrders/GetReturnOrderInfo", "pkOrderId=" + pkOrderId + "&includeRefundLink=" + includeRefundLink + "");
            return JsonFormatter.ConvertFromJson<ReturnOrderHeader>(response);
		}

		/// <summary>
        /// Use this call to get a basic list of returns, exchanges and resends for an order. 
        /// </summary>
        /// <param name="pkOrderId">The order id to get the returns for</param>
        /// <returns>A list of returns</returns>
        public List<ReturnInfo> GetReturnsExchanges(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/GetReturnsExchanges", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<ReturnInfo>>(response);
		}

		/// <summary>
        /// Use this call to retrieve the total value of refunds against an order. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order</param>
        /// <param name="includeBookings">If true, pending refunds against return bookings and exchange bookings will be included. (Optional, default is false.)</param>
        /// <returns>Returns the total refund amount as retrieved based on the parameters.</returns>
        public ExistingRefundTotal GetTotalRefunds(Guid pkOrderId,Boolean? includeBookings = null)
		{
			var response = GetResponse("ProcessedOrders/GetTotalRefunds", "pkOrderId=" + pkOrderId + "&includeBookings=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(includeBookings)) + "");
            return JsonFormatter.ConvertFromJson<ExistingRefundTotal>(response);
		}

		/// <summary>
        /// Use this call to determine if the refunds in a given return set are valid. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order to validate the refund with</param>
        /// <param name="refundItems">The refund rows</param>
        /// <returns>The validation result and, if provided, additional information</returns>
        public ValidationResult IsRefundValid(Guid pkOrderId,List<RefundItem> refundItems)
		{
			var response = GetResponse("ProcessedOrders/IsRefundValid", "pkOrderId=" + pkOrderId + "&refundItems=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(refundItems)) + "");
            return JsonFormatter.ConvertFromJson<ValidationResult>(response);
		}

		/// <summary>
        /// Use this call to determine if validation of refunds or returns/exchanges with refund components is required for a given order. 
        /// </summary>
        /// <param name="pkOrderId">The order id of the order which requires validation</param>
        /// <returns>True if validation is required, false if it is not.</returns>
        public Boolean IsRefundValidationRequiredByOrderId(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/IsRefundValidationRequiredByOrderId", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <summary>
        /// Use this call to update pending manual refunds to the actioned state. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order to action refunds on.</param>
        public void MarkManualRefundsAsActioned(Guid pkOrderId)
		{
			GetResponse("ProcessedOrders/MarkManualRefundsAsActioned", "pkOrderId=" + pkOrderId + "");
		}

		/// <summary>
        /// Use this call to add or update a free text refund. This method can also be used to change the refund amount for any pending manual refund. Please check any automated refunds are valid prior to calling this method. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order to add/update refunds for</param>
        /// <param name="refundItems">The new/altered refund items</param>
        /// <returns>Any new/modified refund rows</returns>
        public List<RefundInfo> RefundFreeText(Guid pkOrderId,List<RefundItem> refundItems)
		{
			var response = GetResponse("ProcessedOrders/RefundFreeText", "pkOrderId=" + pkOrderId + "&refundItems=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(refundItems)) + "");
            return JsonFormatter.ConvertFromJson<List<RefundInfo>>(response);
		}

		/// <summary>
        /// Use this call to refund one or more services on an order. Please check that any automated refunds are valid prior to calling this method. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order to refund services for.</param>
        /// <param name="refundItems">Refunds for service items</param>
        /// <returns>A list of new refunds</returns>
        public List<RefundInfo> RefundServices(Guid pkOrderId,List<RefundItem> refundItems)
		{
			var response = GetResponse("ProcessedOrders/RefundServices", "pkOrderId=" + pkOrderId + "&refundItems=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(refundItems)) + "");
            return JsonFormatter.ConvertFromJson<List<RefundInfo>>(response);
		}

		/// <summary>
        /// Use this call to refund shipping for an order. Please check the refund options to ensure that a shipping refund is possible. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order whose shipping needs to be refunded</param>
        /// <returns>The new refund row</returns>
        public List<RefundInfo> RefundShipping(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/RefundShipping", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<List<RefundInfo>>(response);
		}

		/// <summary>
        /// Use this call to rename an existing return category. 
        /// </summary>
        /// <param name="pkItemId">The id of the category to be renamed.</param>
        /// <param name="newName">The new name for the category.</param>
        public void RenameReturnCategory(Int32 pkItemId,String newName)
		{
			GetResponse("ProcessedOrders/RenameReturnCategory", "pkItemId=" + pkItemId + "&newName=" + System.Net.WebUtility.UrlEncode(newName) + "");
		}

		/// <summary>
        /// Search Processed Orders 
        /// </summary>
        /// <param name="request">Search parameters consisting of keyword, dates, filters and sorting.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Paged list of processed orders.</returns>
        public SearchProcessedOrdersResponse SearchProcessedOrders(SearchProcessedOrdersRequest request)
		{
			var response = GetResponse("ProcessedOrders/SearchProcessedOrders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<SearchProcessedOrdersResponse>(response);
		}

		/// <summary>
        /// Use this call to search for processed orders. 
        /// </summary>
        /// <param name="from">The lower end of the date range to search. Can be null if searching for 'all dates'. Maximum range is 3 months.</param>
        /// <param name="to">The upper end of the date range to search. Can be null if searching for 'all dates'. Maximum range is 3 months.</param>
        /// <param name="dateType">The search type (e.g. ALLDATES)</param>
        /// <param name="searchField">The field to search by. Can be found by calling GetSearchTypes.</param>
        /// <param name="exactMatch">Set to true if an exact match is required for the search data.</param>
        /// <param name="searchTerm">The term which you are searching for.</param>
        /// <param name="pageNum">The page number of the request.</param>
        /// <param name="numEntriesPerPage">The number of entries required on a page. Maximum 200.</param>
        /// <returns>Returns the requested list of processed orders. The columns returned can be changed through the SetColumns method.</returns>
        public GenericPagedResult<ProcessedOrderWeb> SearchProcessedOrdersPaged(DateTime? from,DateTime? to,SearchDateType dateType,String searchField,Boolean exactMatch,String searchTerm,Int32 pageNum,Int32 numEntriesPerPage)
		{
			var response = GetResponse("ProcessedOrders/SearchProcessedOrdersPaged", "from=" + System.Net.WebUtility.UrlEncode(from.HasValue ? from.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "&to=" + System.Net.WebUtility.UrlEncode(to.HasValue ? to.Value.ToString("yyyy-MM-dd HH:mm:ss") : "null") + "&dateType=" + dateType.ToString() + "&searchField=" + System.Net.WebUtility.UrlEncode(searchField) + "&exactMatch=" + exactMatch + "&searchTerm=" + System.Net.WebUtility.UrlEncode(searchTerm) + "&pageNum=" + pageNum + "&numEntriesPerPage=" + numEntriesPerPage + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<ProcessedOrderWeb>>(response);
		}

		/// <summary>
        /// Use this call to check if it is possible to do an automated full-order refund. 
        /// </summary>
        /// <param name="pkOrderId">The id of the order</param>
        /// <returns>A result indicating if an automated full-order refund is possible.</returns>
        public ValidationResult ValidateCompleteOrderRefund(Guid pkOrderId)
		{
			var response = GetResponse("ProcessedOrders/ValidateCompleteOrderRefund", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<ValidationResult>(response);
		} 
    }
}