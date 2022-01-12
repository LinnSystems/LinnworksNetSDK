using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class OpenOrdersController : BaseController, IOpenOrdersController
    {
        public OpenOrdersController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Add an identifier to an order 
        /// </summary>
        public AssignResult AssignOrderIdentifier(ChangeOrderIdentifierRequest request)
		{
			var response = GetResponse("OpenOrders/AssignOrderIdentifier", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AssignResult>(response);
		}

		/// <summary>
        /// Assign Stock to Orders 
        /// </summary>
        public AssignStockToOrdersResponse<OrderItemBatchExtended,Guid> AssignStockToOrders(AssignStockToOrdersRequest request)
		{
			var response = GetResponse("OpenOrders/AssignStockToOrders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AssignStockToOrdersResponse<OrderItemBatchExtended,Guid>>(response);
		}

		public AssignStockToOrdersResponse<Int32,Int32> DeleteAssignedStock(ClearStockAssignmentRequest request)
		{
			var response = GetResponse("OpenOrders/DeleteAssignedStock", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AssignStockToOrdersResponse<Int32,Int32>>(response);
		}

		/// <summary>
        /// Delete an identifier. This will also remove the identifier from all orders that it's assigned to 
        /// </summary>
        public void DeleteIdentifier(DeleteIdentifiersRequest request)
		{
			GetResponse("OpenOrders/DeleteIdentifier", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		public GetAvailableChannelsResponse GetAvailableChannels()
		{
			var response = GetResponse("OpenOrders/GetAvailableChannels", "", "GET");
            return JsonFormatter.ConvertFromJson<GetAvailableChannelsResponse>(response);
		}

		/// <summary>
        /// Get all identifiers that are available to add to an order 
        /// </summary>
        public List<Identifier> GetIdentifiers()
		{
			var response = GetResponse("OpenOrders/GetIdentifiers", "", "GET");
            return JsonFormatter.ConvertFromJson<List<Identifier>>(response);
		}

		/// <summary>
        /// Get all identifiers for a list of orderIds 
        /// </summary>
        public List<OrderIdentifier> GetIdentifiersByOrderIds(GetOrderIdentifierRequest request)
		{
			var response = GetResponse("OpenOrders/GetIdentifiersByOrderIds", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<List<OrderIdentifier>>(response);
		}

		public GenericPagedResult<Guid> GetOpenOrderIds(GetOpenOrdersRequest request)
		{
			var response = GetResponse("OpenOrders/GetOpenOrderIds", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<Guid>>(response);
		}

		/// <summary>
        /// Open order details by order ids. Not limited by the number of orders you can retrieve. This call is designed to return ONLY open orders, 
        /// it is much faster than GetOrderDetail call 
        /// </summary>
        public GetOpenOrdersDetailsResponse GetOpenOrdersDetails(GetOpenOrdersDetailsRequest request)
		{
			var response = GetResponse("OpenOrders/GetOpenOrdersDetails", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetOpenOrdersDetailsResponse>(response);
		}

		public GetOrderItemIndicatorResponse GetOrderItemIndicators(GetOrderItemIndicatorRequest request)
		{
			var response = GetResponse("OpenOrders/GetOrderItemIndicators", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetOrderItemIndicatorResponse>(response);
		}

		public List<OrderViewStats> GetViewStats(GetViewStatsRequest request)
		{
			var response = GetResponse("OpenOrders/GetViewStats", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "", "GET");
            return JsonFormatter.ConvertFromJson<List<OrderViewStats>>(response);
		}

		/// <summary>
        /// Create or update an order identifier 
        /// </summary>
        /// <param name="request"></param>
        public Identifier SaveIdentifier(SaveIdentifiersRequest request)
		{
			var response = GetResponse("OpenOrders/SaveIdentifier", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Identifier>(response);
		}

		public SearchOrdersResponse SearchOrders(SearchOrdersRequest request)
		{
			var response = GetResponse("OpenOrders/SearchOrders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "", "GET");
            return JsonFormatter.ConvertFromJson<SearchOrdersResponse>(response);
		}

		/// <summary>
        /// Remove an identifier from an order 
        /// </summary>
        public AssignResult UnassignOrderIdentifier(ChangeOrderIdentifierRequest request)
		{
			var response = GetResponse("OpenOrders/UnassignOrderIdentifier", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AssignResult>(response);
		} 
    }
}