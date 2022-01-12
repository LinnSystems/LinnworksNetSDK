using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class OrdersController : BaseController, IOrdersController
    {
        public OrdersController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Add a coupon to a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="barcode">Coupon barcode</param>
        /// <param name="couponData">Coupon data</param>
        /// <param name="fulfilmentCenter">Current fulfilment center</param>
        /// <returns>New coupon item created</returns>
        public UpdateOrderItemResult AddCoupon(Guid orderId,String barcode,CouponValidationResult couponData,Guid fulfilmentCenter)
		{
			var response = GetResponse("Orders/AddCoupon", "orderId=" + orderId + "&barcode=" + System.Net.WebUtility.UrlEncode(barcode) + "&couponData=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(couponData)) + "&fulfilmentCenter=" + fulfilmentCenter + "");
            return JsonFormatter.ConvertFromJson<UpdateOrderItemResult>(response);
		}

		/// <summary>
        /// Adds extended properties to a Linnworks orders.
        /// This will NOT update properties that match on property name / value 
        /// </summary>
        /// <param name="request">Request with OrderId and BasicExtendedProperties as fields</param>
        public AddExtendedPropertiesResponse AddExtendedProperties(AddExtendedPropertiesRequest request)
		{
			var response = GetResponse("Orders/AddExtendedProperties", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AddExtendedPropertiesResponse>(response);
		}

		/// <summary>
        /// Add an item to a specific order.
        /// Line pricing is optional with the default values being
        /// - PricePerUnit: Stock item retail price
        /// - DiscountPercentage: 0
        /// - TaxRatePercentage: Stock item tax rate.
        /// - TaxInclusive: true 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="itemId">Item id to be added</param>
        /// <param name="channelSKU">Channel SKU of the item</param>
        /// <param name="fulfilmentCenter">Current fulfilment center</param>
        /// <param name="quantity">Item quantity</param>
        /// <param name="linePricing">Item pricing data</param>
        /// <returns>The item added</returns>
        public UpdateOrderItemResult AddOrderItem(Guid orderId,Guid itemId,String channelSKU,Guid fulfilmentCenter,Int32 quantity,LinePricingRequest linePricing)
		{
			var response = GetResponse("Orders/AddOrderItem", "orderId=" + orderId + "&itemId=" + itemId + "&channelSKU=" + System.Net.WebUtility.UrlEncode(channelSKU) + "&fulfilmentCenter=" + fulfilmentCenter + "&quantity=" + quantity + "&linePricing=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(linePricing)) + "");
            return JsonFormatter.ConvertFromJson<UpdateOrderItemResult>(response);
		}

		/// <summary>
        /// Add a service to an order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="service">Service</param>
        /// <param name="cost">Cost</param>
        /// <param name="taxRate">Tax rate</param>
        /// <param name="fulfilmentCenter">Current fulfilment center</param>
        /// <returns>The service item added</returns>
        public UpdateOrderItemResult AddOrderService(Guid orderId,String service,Double cost,Double taxRate,Guid fulfilmentCenter)
		{
			var response = GetResponse("Orders/AddOrderService", "orderId=" + orderId + "&service=" + System.Net.WebUtility.UrlEncode(service) + "&cost=" + cost + "&taxRate=" + taxRate + "&fulfilmentCenter=" + fulfilmentCenter + "");
            return JsonFormatter.ConvertFromJson<UpdateOrderItemResult>(response);
		}

		public void AssignOrderItemBatches(AssignOrderItemBatches request)
		{
			GetResponse("Orders/AssignOrderItemBatches", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		public List<OrderItemBatch> AssignStockToOrder(AssignStockToOrderRequest request)
		{
			var response = GetResponse("Orders/AssignStockToOrder", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<List<OrderItemBatch>>(response);
		}

		/// <summary>
        /// Assign a list of orders to a specific folder 
        /// </summary>
        /// <param name="orderIds">list of order ids to be assigned</param>
        /// <param name="folder">folder to be assigned</param>
        public List<Guid> AssignToFolder(List<Guid> orderIds,String folder)
		{
			var response = GetResponse("Orders/AssignToFolder", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&folder=" + System.Net.WebUtility.UrlEncode(folder) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Cancel a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="fulfilmentCenter">Current fulfilment center</param>
        /// <param name="refund">Refund quantity</param>
        /// <param name="note">Note a attach</param>
        /// <returns>Possible error. null if everything has gone fine</returns>
        public String CancelOrder(Guid orderId,Guid fulfilmentCenter,Double refund,String note)
		{
			var response = GetResponse("Orders/CancelOrder", "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "&refund=" + refund + "&note=" + System.Net.WebUtility.UrlEncode(note) + "");
            return JsonFormatter.ConvertFromJson<String>(response);
		}

		/// <summary>
        /// Change the tag for the specific order list. Tags can be 1-6 for custom tags, or 7 to initialize a 'parked' status on the order. 
        /// </summary>
        /// <param name="orderIds">Orders to change the tag</param>
        /// <param name="tag">new tag. null to remove the tag</param>
        public List<Guid> ChangeOrderTag(List<Guid> orderIds,Int32? tag)
		{
			var response = GetResponse("Orders/ChangeOrderTag", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&tag=" + tag + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Change the shipping method to a list of orders 
        /// </summary>
        /// <param name="orderIds">Order id's</param>
        /// <param name="shippingMethod">New shipping method</param>
        public List<Guid> ChangeShippingMethod(List<Guid> orderIds,String shippingMethod)
		{
			var response = GetResponse("Orders/ChangeShippingMethod", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&shippingMethod=" + System.Net.WebUtility.UrlEncode(shippingMethod) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Change the status to a list of orders
        /// 0 = 'UNPAID'
        /// 1 = 'PAID'
        /// 2 = 'RETURN'
        /// 3 = 'PENDING'
        /// 4 = 'RESEND' 
        /// </summary>
        /// <param name="orderIds">Order id's</param>
        /// <param name="status">New status</param>
        public List<Guid> ChangeStatus(List<Guid> orderIds,Int32 status)
		{
			var response = GetResponse("Orders/ChangeStatus", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&status=" + status + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Clear invoice printed flag for a list of orders 
        /// </summary>
        /// <param name="orderIds">List of orders</param>
        public List<Guid> ClearInvoicePrinted(List<Guid> orderIds)
		{
			var response = GetResponse("Orders/ClearInvoicePrinted", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Clear invoice printed flag for a list of orders 
        /// </summary>
        /// <param name="orderIds">List of orders</param>
        public List<Guid> ClearPickListPrinted(List<Guid> orderIds)
		{
			var response = GetResponse("Orders/ClearPickListPrinted", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Clear the shipping label info to a list of orders 
        /// </summary>
        /// <param name="orderIds">Order ids</param>
        /// <param name="withoutConfirmation">skip any confirmation message</param>
        /// <returns>Confirmation message list (Key = order Id, Value = Message)</returns>
        public List<KeyValuePair<Guid,String>> ClearShippingLabelInfo(List<Guid> orderIds,Boolean withoutConfirmation)
		{
			var response = GetResponse("Orders/ClearShippingLabelInfo", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&withoutConfirmation=" + withoutConfirmation + "");
            return JsonFormatter.ConvertFromJson<List<KeyValuePair<Guid,String>>>(response);
		}

		/// <summary>
        /// Complete a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <returns>Generated reference number for the order</returns>
        public String CompleteOrder(Guid orderId)
		{
			var response = GetResponse("Orders/CompleteOrder", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<String>(response);
		}

		/// <summary>
        /// Create a new item and link it to a specific stock item 
        /// </summary>
        /// <param name="pkStockItemId">Stock item id</param>
        /// <param name="itemTitle">Title</param>
        /// <param name="source">Source</param>
        /// <param name="subSource">Subsource</param>
        /// <param name="channelSKU">Channel SKU</param>
        /// <param name="locationId">User location</param>
        /// <param name="initialQuantity">Initial quantity once the inventory item has been created</param>
        /// <returns>Item id if has been created, null if not</returns>
        public Guid? CreateNewItemAndLink(Guid pkStockItemId,String itemTitle,String source,String subSource,String channelSKU,Guid? locationId,Int32? initialQuantity)
		{
			var response = GetResponse("Orders/CreateNewItemAndLink", "pkStockItemId=" + pkStockItemId + "&itemTitle=" + System.Net.WebUtility.UrlEncode(itemTitle) + "&source=" + System.Net.WebUtility.UrlEncode(source) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "&channelSKU=" + System.Net.WebUtility.UrlEncode(channelSKU) + "&locationId=" + locationId + "&initialQuantity=" + initialQuantity + "");
            return JsonFormatter.ConvertFromJson<Guid?>(response);
		}

		/// <summary>
        /// Create an empty draft order. (Please see CreateOrders call) 
        /// </summary>
        /// <param name="fulfilmentCenter">Fulfilment center to be associated</param>
        /// <param name="createAsDraft"></param>
        /// <returns>Order created</returns>
        public OpenOrder CreateNewOrder(Guid fulfilmentCenter,Boolean createAsDraft = true)
		{
			var response = GetResponse("Orders/CreateNewOrder", "fulfilmentCenter=" + fulfilmentCenter + "&createAsDraft=" + createAsDraft + "");
            return JsonFormatter.ConvertFromJson<OpenOrder>(response);
		}

		/// <summary>
        /// Creates new orders, once an order is paid it will be skipped on save. Returns list of pkOrderId's that were saved. 
        /// </summary>
        /// <param name="orders">List of orders to create</param>
        /// <param name="location">Location to create the order</param>
        public List<Guid> CreateOrders(List<ChannelOrder> orders,String location)
		{
			var response = GetResponse("Orders/CreateOrders", "orders=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orders)) + "&location=" + System.Net.WebUtility.UrlEncode(location) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Get a list of possible addresses based on a search 
        /// </summary>
        /// <param name="field">Field to search by</param>
        /// <param name="txt">Text to find</param>
        /// <returns>List of possible addresses</returns>
        public List<CustomerAddress> CustomerLookUp(String field,String txt)
		{
			var response = GetResponse("Orders/CustomerLookUp", "field=" + System.Net.WebUtility.UrlEncode(field) + "&txt=" + System.Net.WebUtility.UrlEncode(txt) + "");
            return JsonFormatter.ConvertFromJson<List<CustomerAddress>>(response);
		}

		/// <summary>
        /// Delete a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        public void DeleteOrder(Guid orderId)
		{
			GetResponse("Orders/DeleteOrder", "orderId=" + orderId + "");
		}

		/// <summary>
        /// Get a basic info of open orders, from a list of open order items 
        /// </summary>
        /// <param name="request"></param>
        public Get_OpenOrderBasicInfoFromItemsResponse Get_OpenOrderBasicInfoFromItems(Get_OpenOrderBasicInfoFromItemsRequest request)
		{
			var response = GetResponse("Orders/Get_OpenOrderBasicInfoFromItems", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Get_OpenOrderBasicInfoFromItemsResponse>(response);
		}

		/// <summary>
        /// Get a list of available batchs for each order item for the specified order 
        /// </summary>
        /// <param name="parameters">Made up of pkOrderId</param>
        public List<StockItemBatch> GetAllAvailableOrderItemBatchsByOrderId(AvailableOrderItemBatchsInfo parameters)
		{
			var response = GetResponse("Orders/GetAllAvailableOrderItemBatchsByOrderId", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemBatch>>(response);
		}

		/// <summary>
        /// Get the list of Id's of all open orders (without pagination) 
        /// </summary>
        /// <param name="filters">Filters to apply</param>
        /// <param name="sorting">Sorting to apply</param>
        /// <param name="fulfilmentCenter">Location to get the orders for</param>
        /// <param name="additionalFilter">Additional filter</param>
        /// <param name="exactMatch">Whether we should use</param>
        /// <returns>List of id's</returns>
        public List<Guid> GetAllOpenOrders(FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter,Boolean exactMatch = false)
		{
			var response = GetResponse("Orders/GetAllOpenOrders", "filters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(filters)) + "&sorting=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(sorting)) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + System.Net.WebUtility.UrlEncode(additionalFilter) + "&exactMatch=" + exactMatch + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Get the list of open order id's between two index with the current filters and sorting 
        /// </summary>
        /// <param name="fromIndex">From index</param>
        /// <param name="toIndex">To index</param>
        /// <param name="filters">Filters to apply</param>
        /// <param name="sorting">Sorting to apply</param>
        /// <param name="fulfilmentCenter">Location to get the orders for</param>
        /// <param name="additionalFilter">Additional filter</param>
        /// <returns>List of Id's</returns>
        public List<Guid> GetAllOpenOrdersBetweenIndex(Int32 fromIndex,Int32 toIndex,FieldsFilter filters,List<FieldSorting> sorting,Guid fulfilmentCenter,String additionalFilter)
		{
			var response = GetResponse("Orders/GetAllOpenOrdersBetweenIndex", "fromIndex=" + fromIndex + "&toIndex=" + toIndex + "&filters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(filters)) + "&sorting=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(sorting)) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + System.Net.WebUtility.UrlEncode(additionalFilter) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		public List<OrderItemBatch> GetAssignedOrderItemBatches(GetAssignedOrderItemBatchesRequest request)
		{
			var response = GetResponse("Orders/GetAssignedOrderItemBatches", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<List<OrderItemBatch>>(response);
		}

		/// <summary>
        /// Get list of available folders that orders can be assigned to 
        /// </summary>
        /// <returns>list of folders</returns>
        public List<OrderFolder> GetAvailableFolders()
		{
			var response = GetResponse("Orders/GetAvailableFolders", "");
            return JsonFormatter.ConvertFromJson<List<OrderFolder>>(response);
		}

		/// <summary>
        /// Get the list of available batch pilots 
        /// </summary>
        /// <returns>List of batch pilots (Key = Id, Value = Name)</returns>
        public List<KeyValuePair<Guid,String>> GetBatchPilots()
		{
			var response = GetResponse("Orders/GetBatchPilots", "");
            return JsonFormatter.ConvertFromJson<List<KeyValuePair<Guid,String>>>(response);
		}

		/// <summary>
        /// Get list of available countries 
        /// </summary>
        /// <returns>List of countries</returns>
        public List<OrderCountry> GetCountries()
		{
			var response = GetResponse("Orders/GetCountries", "");
            return JsonFormatter.ConvertFromJson<List<OrderCountry>>(response);
		}

		/// <summary>
        /// Get the default payment method for new direct orders 
        /// </summary>
        /// <returns>Id of the payment method</returns>
        public Guid GetDefaultPaymentMethodIdForNewOrder()
		{
			var response = GetResponse("Orders/GetDefaultPaymentMethodIdForNewOrder", "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Get list of draft orders 
        /// </summary>
        /// <returns>List of orders</returns>
        public List<Guid> GetDraftOrders()
		{
			var response = GetResponse("Orders/GetDraftOrders", "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Get the extended properties for a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <returns>List of extended properties</returns>
        public List<ExtendedProperty> GetExtendedProperties(Guid orderId)
		{
			var response = GetResponse("Orders/GetExtendedProperties", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<List<ExtendedProperty>>(response);
		}

		/// <summary>
        /// Get the available types of extended properties 
        /// </summary>
        /// <returns>List of types</returns>
        public List<String> GetExtendedPropertyNames()
		{
			var response = GetResponse("Orders/GetExtendedPropertyNames", "");
            return JsonFormatter.ConvertFromJson<List<String>>(response);
		}

		/// <summary>
        /// Get the available types of extended properties 
        /// </summary>
        /// <returns>List of types</returns>
        public List<String> GetExtendedPropertyTypes()
		{
			var response = GetResponse("Orders/GetExtendedPropertyTypes", "");
            return JsonFormatter.ConvertFromJson<List<String>>(response);
		}

		/// <summary>
        /// Get linked items to another one 
        /// </summary>
        /// <param name="itemId">Item id (pkStockItemId)</param>
        /// <returns>Linked otems</returns>
        public List<LinkedItem> GetLinkedItems(Guid itemId)
		{
			var response = GetResponse("Orders/GetLinkedItems", "itemId=" + itemId + "");
            return JsonFormatter.ConvertFromJson<List<LinkedItem>>(response);
		}

		/// <summary>
        /// Get an order by reference number or order number 
        /// </summary>
        /// <param name="orderOrReferenceId">reference number or order number</param>
        /// <param name="filters">Filters to apply</param>
        /// <param name="locationId">User location</param>
        /// <returns>Order id, or null if not found</returns>
        public Guid? GetOpenOrderIdByOrderOrReferenceId(String orderOrReferenceId,FieldsFilter filters,Guid? locationId)
		{
			var response = GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceId", "orderOrReferenceId=" + System.Net.WebUtility.UrlEncode(orderOrReferenceId) + "&filters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(filters)) + "&locationId=" + locationId + "");
            return JsonFormatter.ConvertFromJson<Guid?>(response);
		}

		/// <summary>
        /// Get items suppliers list for a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <returns>Suppliers list (Key = Stock item id, Value = Supplier id)</returns>
        public List<KeyValuePair<Guid,Guid>> GetOpenOrderItemsSuppliers(Guid orderId)
		{
			var response = GetResponse("Orders/GetOpenOrderItemsSuppliers", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<List<KeyValuePair<Guid,Guid>>>(response);
		}

		/// <summary>
        /// Get a paged list of open orders 
        /// </summary>
        /// <param name="entriesPerPage">Entries per page</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filters">Filters to apply</param>
        /// <param name="sorting">Sorting to apply</param>
        /// <param name="fulfilmentCenter">Location to get the orders for</param>
        /// <param name="additionalFilter">Additional filter</param>
        /// <returns>List of open orders for this page and total orders. The orders don't have the Billing Address information; to get this information use GetOrder</returns>
        public GenericPagedResult<OpenOrder> GetOpenOrders(Int32 entriesPerPage,Int32 pageNumber,FieldsFilter filters,List<FieldSorting> sorting,Guid? fulfilmentCenter,String additionalFilter)
		{
			var response = GetResponse("Orders/GetOpenOrders", "entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&filters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(filters)) + "&sorting=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(sorting)) + "&fulfilmentCenter=" + fulfilmentCenter + "&additionalFilter=" + System.Net.WebUtility.UrlEncode(additionalFilter) + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<OpenOrder>>(response);
		}

		/// <summary>
        /// Get orders by order item barcode 
        /// </summary>
        /// <param name="productBarcode">Item barcode</param>
        /// <param name="filters">Filters to apply</param>
        /// <param name="locationId">User location</param>
        /// <returns>A list of order summary and posible errors</returns>
        public KeyValuePair<List<OrderSummary>,String> GetOpenOrdersByItemBarcode(String productBarcode,FieldsFilter filters,Guid? locationId)
		{
			var response = GetResponse("Orders/GetOpenOrdersByItemBarcode", "productBarcode=" + System.Net.WebUtility.UrlEncode(productBarcode) + "&filters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(filters)) + "&locationId=" + locationId + "");
            return JsonFormatter.ConvertFromJson<KeyValuePair<List<OrderSummary>,String>>(response);
		}

		/// <summary>
        /// Get a specific open order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="fulfilmentLocationId">Current fulfilment center</param>
        /// <param name="loadItems">Load or not the order items information</param>
        /// <param name="loadAdditionalInfo">Load or not the order additional info</param>
        /// <returns>Order</returns>
        public OpenOrder GetOrder(Guid orderId,Guid? fulfilmentLocationId,Boolean loadItems,Boolean loadAdditionalInfo)
		{
			var response = GetResponse("Orders/GetOrder", "orderId=" + orderId + "&fulfilmentLocationId=" + fulfilmentLocationId + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo + "");
            return JsonFormatter.ConvertFromJson<OpenOrder>(response);
		}

		/// <summary>
        /// Get order audit trail 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <returns>Audit trail list</returns>
        public List<OrderAuditTrail> GetOrderAuditTrail(Guid orderId)
		{
			var response = GetResponse("Orders/GetOrderAuditTrail", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<List<OrderAuditTrail>>(response);
		}

		/// <summary>
        /// Returns a list of audit trails for the provided order ids 
        /// </summary>
        /// <param name="request"></param>
        public GetOrderAuditTrailsByIdsResponse GetOrderAuditTrailsByIds(GetOrderAuditTrailsByIdsRequest request)
		{
			var response = GetResponse("Orders/GetOrderAuditTrailsByIds", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetOrderAuditTrailsByIdsResponse>(response);
		}

		/// <summary>
        /// Retrieves the order detail for a unique system order id identifier (pkOrderId)
        /// For working with open orders recommended to use OpenOrders/GetOpenOrdersDetails 
        /// </summary>
        /// <param name="pkOrderId">pkOrderId</param>
        /// <returns>Order detail class. Stock levels for the order items are not available in this call</returns>
        public OrderDetails GetOrderById(Guid pkOrderId)
		{
			var response = GetResponse("Orders/GetOrderById", "pkOrderId=" + pkOrderId + "");
            return JsonFormatter.ConvertFromJson<OrderDetails>(response);
		}

		/// <summary>
        /// Retrieves the order detail for a given order numeric id. If not found  empty class is returned.  
        /// For working with open orders recommended to use OpenOrders/GetOpenOrdersDetails 
        /// </summary>
        /// <param name="OrderId">Order Id (numeric)</param>
        /// <returns>Order detail class. Stock levels for the order items are not available in this call</returns>
        public OrderDetails GetOrderDetailsByNumOrderId(Int32 OrderId)
		{
			var response = GetResponse("Orders/GetOrderDetailsByNumOrderId", "OrderId=" + OrderId + "");
            return JsonFormatter.ConvertFromJson<OrderDetails>(response);
		}

		/// <summary>
        /// Retrieves a list of order details for a given order reference number, returns maximum of 50 orders.
        /// For eBay orders, if Sellling Manager Pro sales number is available the order can be retrived by this number 
        /// </summary>
        /// <param name="ReferenceId">Order reference id, or SecondaryReferenceNumber</param>
        /// <returns>List of order details. Stock levels for the order items are not available in this call</returns>
        public List<OrderDetails> GetOrderDetailsByReferenceId(String ReferenceId)
		{
			var response = GetResponse("Orders/GetOrderDetailsByReferenceId", "ReferenceId=" + System.Net.WebUtility.UrlEncode(ReferenceId) + "");
            return JsonFormatter.ConvertFromJson<List<OrderDetails>>(response);
		}

		/// <summary>
        /// Get a list of order item batch information for the specified orders 
        /// </summary>
        /// <param name="request">Made up of list of pkOrderIds</param>
        public GetOrderItemBatchesByOrderIdsResponse GetOrderItemBatchesByOrderIds(GetOrderItemBatchesByOrderIdsRequest request)
		{
			var response = GetResponse("Orders/GetOrderItemBatchesByOrderIds", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetOrderItemBatchesByOrderIdsResponse>(response);
		}

		/// <summary>
        /// Get a list of order item batch information for the specified order 
        /// </summary>
        /// <param name="parameters">Made up of pkOrderId</param>
        public List<OrderItemBatch> GetOrderItemBatchsByOrderId(OrderItemBatchInfo parameters)
		{
			var response = GetResponse("Orders/GetOrderItemBatchsByOrderId", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
            return JsonFormatter.ConvertFromJson<List<OrderItemBatch>>(response);
		}

		/// <summary>
        /// Get the detail (composition) of a specific order item 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="stockItemId">Stock item id</param>
        /// <param name="fulfilmentCenter">Location to get the order item composition for</param>
        /// <returns>Order item</returns>
        public OrderItem GetOrderItemComposition(Guid orderId,Guid stockItemId,Guid fulfilmentCenter)
		{
			var response = GetResponse("Orders/GetOrderItemComposition", "orderId=" + orderId + "&stockItemId=" + stockItemId + "&fulfilmentCenter=" + fulfilmentCenter + "");
            return JsonFormatter.ConvertFromJson<OrderItem>(response);
		}

		/// <summary>
        /// Get order items 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="fulfilmentCenter">Current fulfilment center</param>
        /// <returns>List of items</returns>
        public List<OrderItem> GetOrderItems(Guid orderId,Guid fulfilmentCenter)
		{
			var response = GetResponse("Orders/GetOrderItems", "orderId=" + orderId + "&fulfilmentCenter=" + fulfilmentCenter + "");
            return JsonFormatter.ConvertFromJson<List<OrderItem>>(response);
		}

		/// <summary>
        /// Get the order notes 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <returns>List of notes</returns>
        public List<OrderNote> GetOrderNotes(Guid orderId)
		{
			var response = GetResponse("Orders/GetOrderNotes", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<List<OrderNote>>(response);
		}

		public List<OrderNoteType> GetOrderNoteTypes()
		{
			var response = GetResponse("Orders/GetOrderNoteTypes", "", "GET");
            return JsonFormatter.ConvertFromJson<List<OrderNoteType>>(response);
		}

		/// <summary>
        /// Retrieves order packaging, weight and dimension information with split packaging. The method can perform ad hoc recalculation and saving of any changes. 
        /// </summary>
        /// <param name="request">Orders to get packaging calculations for</param>
        public List<CalcOrderHeader> GetOrderPackagingCalculation(GetOrderPackagingCalculationRequest request)
		{
			var response = GetResponse("Orders/GetOrderPackagingCalculation", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<List<CalcOrderHeader>>(response);
		}

		/// <summary>
        /// Get a possible order split by packaging 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="openOrdersOnly">Whether to search open orders only, or all orders</param>
        /// <returns>Split result</returns>
        public List<OrderPackagingSplit> GetOrderPackagingSplit(Guid orderId,Boolean openOrdersOnly)
		{
			var response = GetResponse("Orders/GetOrderPackagingSplit", "orderId=" + orderId + "&openOrdersOnly=" + openOrdersOnly + "");
            return JsonFormatter.ConvertFromJson<List<OrderPackagingSplit>>(response);
		}

		/// <summary>
        /// Get order relations 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <returns>List of relations</returns>
        public List<OrderRelation> GetOrderRelations(Guid orderId)
		{
			var response = GetResponse("Orders/GetOrderRelations", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<List<OrderRelation>>(response);
		}

		/// <summary>
        /// Get list of open orders 
        /// </summary>
        /// <param name="ordersIds">Orders ids</param>
        /// <param name="fulfilmentLocationId">Current fulfilment center</param>
        /// <param name="loadItems">Load or not the orders items information</param>
        /// <param name="loadAdditionalInfo">Load or not the orders additional info</param>
        /// <returns>Order</returns>
        public List<OpenOrder> GetOrders(List<Guid> ordersIds,Guid? fulfilmentLocationId,Boolean loadItems,Boolean loadAdditionalInfo)
		{
			var response = GetResponse("Orders/GetOrders", "ordersIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(ordersIds)) + "&fulfilmentLocationId=" + fulfilmentLocationId + "&loadItems=" + loadItems + "&loadAdditionalInfo=" + loadAdditionalInfo + "");
            return JsonFormatter.ConvertFromJson<List<OpenOrder>>(response);
		}

		/// <summary>
        /// Retrieves the order detail list for a list of order id identifiers (pkOrderId)
        /// For working with open orders recommended to use OpenOrders/GetOpenOrdersDetails 
        /// </summary>
        /// <param name="pkOrderIds">List of order ids (pkOrderId)</param>
        /// <returns>List of order detail class. Stock levels for the order items are not available in this call</returns>
        public List<OrderDetails> GetOrdersById(List<Guid> pkOrderIds)
		{
			var response = GetResponse("Orders/GetOrdersById", "pkOrderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(pkOrderIds)) + "");
            return JsonFormatter.ConvertFromJson<List<OrderDetails>>(response);
		}

		public Dictionary<Guid,List<OrderNote>> GetOrdersNotes(List<Guid> orderIds)
		{
			var response = GetResponse("Orders/GetOrdersNotes", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "");
            return JsonFormatter.ConvertFromJson<Dictionary<Guid,List<OrderNote>>>(response);
		}

		/// <summary>
        /// Get order relations for a list of orders. 
        /// </summary>
        /// <param name="orderIds">List of order Ids</param>
        /// <returns>Dictionary: OrderId / List of relations</returns>
        public Dictionary<Guid,List<OrderRelation>> GetOrdersRelations(List<Guid> orderIds)
		{
			var response = GetResponse("Orders/GetOrdersRelations", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "");
            return JsonFormatter.ConvertFromJson<Dictionary<Guid,List<OrderRelation>>>(response);
		}

		/// <summary>
        /// Get a specific open order view 
        /// </summary>
        /// <param name="pkViewId">View id</param>
        /// <param name="markAsLatestViewed">Mark it in the database as latest viewer</param>
        /// <returns>View with its detail</returns>
        public UserOrderView GetOrderView(Int32 pkViewId,Boolean markAsLatestViewed)
		{
			var response = GetResponse("Orders/GetOrderView", "pkViewId=" + pkViewId + "&markAsLatestViewed=" + markAsLatestViewed + "");
            return JsonFormatter.ConvertFromJson<UserOrderView>(response);
		}

		/// <summary>
        /// Get open order views 
        /// </summary>
        /// <returns>List of available views</returns>
        public List<UserOrderView> GetOrderViews()
		{
			var response = GetResponse("Orders/GetOrderViews", "");
            return JsonFormatter.ConvertFromJson<List<UserOrderView>>(response);
		}

		/// <summary>
        /// Get order XML received from channel 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <returns>XML or null if the XML file doesn't exist</returns>
        public List<OrderXML> GetOrderXml(Guid orderId)
		{
			var response = GetResponse("Orders/GetOrderXml", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<List<OrderXML>>(response);
		}

		/// <summary>
        /// Get order XML received from channel 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <returns>XML or null if the XML file doesn't exist</returns>
        public String GetOrderXmlJSTree(Guid orderId)
		{
			var response = GetResponse("Orders/GetOrderXmlJSTree", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<String>(response);
		}

		/// <summary>
        /// Get available packaging groups 
        /// </summary>
        /// <returns>List of packaging groups</returns>
        public List<PackageGroup> GetPackagingGroups()
		{
			var response = GetResponse("Orders/GetPackagingGroups", "");
            return JsonFormatter.ConvertFromJson<List<PackageGroup>>(response);
		}

		/// <summary>
        /// Get the available payment methods 
        /// </summary>
        /// <returns>List of payment methods</returns>
        public List<PaymentMethod> GetPaymentMethods()
		{
			var response = GetResponse("Orders/GetPaymentMethods", "");
            return JsonFormatter.ConvertFromJson<List<PaymentMethod>>(response);
		}

		/// <summary>
        /// Get available shipping methods 
        /// </summary>
        /// <returns>List of shipping methods</returns>
        public List<ShippingMethod> GetShippingMethods()
		{
			var response = GetResponse("Orders/GetShippingMethods", "");
            return JsonFormatter.ConvertFromJson<List<ShippingMethod>>(response);
		}

		/// <summary>
        /// Get the user location from settings 
        /// </summary>
        /// <returns>User location Id</returns>
        public Guid GetUserLocationId()
		{
			var response = GetResponse("Orders/GetUserLocationId", "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Lock a list of orders 
        /// </summary>
        /// <param name="orderIds">Order id's</param>
        /// <param name="lockOrder">Lock or unlock the orders</param>
        public void LockOrder(List<Guid> orderIds,Boolean lockOrder)
		{
			GetResponse("Orders/LockOrder", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&lockOrder=" + lockOrder + "");
		}

		/// <summary>
        /// Merge a list of orders into a new one 
        /// </summary>
        /// <param name="ordersToMerge">Orders to merge</param>
        /// <param name="fulfilmentCenter">Current fulfilment center</param>
        /// <param name="pkPostalServiceId">Postal service id</param>
        /// <returns>Order created</returns>
        public OpenOrder MergeOrders(List<Guid> ordersToMerge,Guid fulfilmentCenter,Guid pkPostalServiceId)
		{
			var response = GetResponse("Orders/MergeOrders", "ordersToMerge=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(ordersToMerge)) + "&fulfilmentCenter=" + fulfilmentCenter + "&pkPostalServiceId=" + pkPostalServiceId + "");
            return JsonFormatter.ConvertFromJson<OpenOrder>(response);
		}

		/// <summary>
        /// Move a lis of orders to a specific fulfilment center 
        /// </summary>
        /// <param name="orderIds">Order ids</param>
        /// <param name="fulfilmentCenterId">Fulfilment center id</param>
        /// <returns>List of errors. Empty list if everything has gone fine</returns>
        public MoveToFulfilmentCenterResult MoveToFulfilmentCenter(List<Guid> orderIds,Guid fulfilmentCenterId)
		{
			var response = GetResponse("Orders/MoveToFulfilmentCenter", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&fulfilmentCenterId=" + fulfilmentCenterId + "");
            return JsonFormatter.ConvertFromJson<MoveToFulfilmentCenterResult>(response);
		}

		/// <summary>
        /// Move a list of orders to a specific location 
        /// </summary>
        /// <param name="orderIds">Orders to be moved</param>
        /// <param name="pkStockLocationId">Location where to move orders</param>
        /// <returns>MoveToLocationResult with list of order ids moved and errors if they exist.</returns>
        public MoveToLocationResult MoveToLocation(List<Guid> orderIds,Guid pkStockLocationId)
		{
			var response = GetResponse("Orders/MoveToLocation", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&pkStockLocationId=" + pkStockLocationId + "");
            return JsonFormatter.ConvertFromJson<MoveToLocationResult>(response);
		}

		/// <summary>
        /// Process Orders associated with a Fulfilment Centre 
        /// </summary>
        /// <param name="orderId">pkOrderID</param>
        public ProcessOrderResult ProcessFulfilmentCentreOrder(Guid orderId)
		{
			var response = GetResponse("Orders/ProcessFulfilmentCentreOrder", "orderId=" + orderId + "");
            return JsonFormatter.ConvertFromJson<ProcessOrderResult>(response);
		}

		/// <summary>
        /// Process a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="scanPerformed">Indicate if the scan has been performed</param>
        /// <param name="locationId">User location</param>
        /// <param name="context">Information about where the call came from</param>
        /// <returns>Return a boolean meaning if has been processed, and a possible error</returns>
        public ProcessOrderResult ProcessOrder(Guid orderId,Boolean scanPerformed,Guid? locationId,ClientContext context = null)
		{
			var response = GetResponse("Orders/ProcessOrder", "orderId=" + orderId + "&scanPerformed=" + scanPerformed + "&locationId=" + locationId + "&context=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(context)) + "");
            return JsonFormatter.ConvertFromJson<ProcessOrderResult>(response);
		}

		/// <summary>
        /// Update the order with the batch numbers scanned during process order (i.e. those items with dbo.StockItem.BatchNumberScanRequired set)
        /// batches must be provided for all items in the order which require batch number scanning (including composite children)
        /// Overwrites any existing batch assignment for the required items 
        /// </summary>
        /// <param name="BatchAssignment">Batch information to be added</param>
        public void ProcessOrder_RequiredBatchScans(BatchAssignmentForOrderItems BatchAssignment)
		{
			GetResponse("Orders/ProcessOrder_RequiredBatchScans", "BatchAssignment=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(BatchAssignment)) + "");
		}

		public ProcessOrderByOrderIdOrReferenceResponse ProcessOrderByOrderOrReferenceId(ProcessOrderByOrderIdOrReferenceRequest request)
		{
			var response = GetResponse("Orders/ProcessOrderByOrderOrReferenceId", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<ProcessOrderByOrderIdOrReferenceResponse>(response);
		}

		/// <summary>
        /// Process a list of orders 
        /// </summary>
        /// <param name="ordersIds">List of orders ids</param>
        /// <param name="locationId">User location</param>
        /// <param name="context">Information about where the call came from</param>
        /// <returns>Return a list of possible errors</returns>
        public List<ProcessOrderResult> ProcessOrdersInBatch(List<Guid> ordersIds,Guid? locationId,ClientContext context = null)
		{
			var response = GetResponse("Orders/ProcessOrdersInBatch", "ordersIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(ordersIds)) + "&locationId=" + locationId + "&context=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(context)) + "");
            return JsonFormatter.ConvertFromJson<List<ProcessOrderResult>>(response);
		}

		/// <summary>
        /// Designed to recalculate order packaging totals based on the object provided 
        /// </summary>
        /// <param name="request">Request object with data needed</param>
        /// <param name="cancellationToken"></param>
        public CalcOrderHeader RecalculateSingleOrderPackaging(CalcOrderHeader request)
		{
			var response = GetResponse("Orders/RecalculateSingleOrderPackaging", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CalcOrderHeader>(response);
		}

		/// <summary>
        /// Remove item from an order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="rowid">Row id of the item</param>
        /// <param name="fulfilmentCenter">Fulfilment center id</param>
        /// <returns>Result of the operation</returns>
        public UpdateOrderItemResult RemoveOrderItem(Guid orderId,Guid rowid,Guid fulfilmentCenter)
		{
			var response = GetResponse("Orders/RemoveOrderItem", "orderId=" + orderId + "&rowid=" + rowid + "&fulfilmentCenter=" + fulfilmentCenter + "");
            return JsonFormatter.ConvertFromJson<UpdateOrderItemResult>(response);
		}

		/// <summary>
        /// Run Rules Engine on Open Orders 
        /// </summary>
        /// <param name="orderIds">List of order IDs to run rules on</param>
        /// <param name="ruleId">Id of Rule to run. Null if all rules should be run</param>
        public List<Guid> RunRulesEngine(Guid[] orderIds,Int32? ruleId = null)
		{
			var response = GetResponse("Orders/RunRulesEngine", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&ruleId=" + ruleId + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Update a open order view 
        /// </summary>
        /// <param name="pkViewId">View id</param>
        /// <param name="viewName">View name</param>
        /// <param name="OrderViewDetailJSON">Detail serialized in JSON</param>
        public void SaveOrderView(Int32 pkViewId,String viewName,String OrderViewDetailJSON)
		{
			GetResponse("Orders/SaveOrderView", "pkViewId=" + pkViewId + "&viewName=" + System.Net.WebUtility.UrlEncode(viewName) + "&OrderViewDetailJSON=" + System.Net.WebUtility.UrlEncode(OrderViewDetailJSON) + "");
		}

		/// <summary>
        /// Overwrites the existing order item additional info 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="rowId">Item row id</param>
        /// <param name="additionalInfo">Additional info to set</param>
        public void SetAdditionalInfo(Guid orderId,Guid rowId,OrderItemOption[] additionalInfo)
		{
			GetResponse("Orders/SetAdditionalInfo", "orderId=" + orderId + "&rowId=" + rowId + "&additionalInfo=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(additionalInfo)) + "");
		}

		/// <summary>
        /// Set the list of available folders that orders can be assigned to 
        /// </summary>
        /// <param name="folders">folders list</param>
        public List<OrderFolder> SetAvailableFolders(List<OrderFolder> folders)
		{
			var response = GetResponse("Orders/SetAvailableFolders", "folders=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(folders)) + "");
            return JsonFormatter.ConvertFromJson<List<OrderFolder>>(response);
		}

		/// <summary>
        /// Set the default payment method for new direct orders 
        /// </summary>
        /// <param name="paymentMethod">Id of the payment method</param>
        public void SetDefaultPaymentMethodIdForNewOrder(Guid paymentMethod)
		{
			GetResponse("Orders/SetDefaultPaymentMethodIdForNewOrder", "paymentMethod=" + paymentMethod + "");
		}

		/// <summary>
        /// Set the extended properties for a specific order 
        /// </summary>
        /// <param name="orderId">Order id (pkOrderID)</param>
        /// <param name="extendedProperties">Extended property information</param>
        /// <returns>The extended properties, updated with new ids</returns>
        public List<ExtendedProperty> SetExtendedProperties(Guid orderId,ExtendedProperty[] extendedProperties)
		{
			var response = GetResponse("Orders/SetExtendedProperties", "orderId=" + orderId + "&extendedProperties=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(extendedProperties)) + "");
            return JsonFormatter.ConvertFromJson<List<ExtendedProperty>>(response);
		}

		/// <summary>
        /// Mark a list of orders as invoice printed 
        /// </summary>
        /// <param name="orderIds">List of orders to mark as label printed</param>
        /// <returns>Returns the list of orders that have changed invoice printed status</returns>
        public List<Guid> SetInvoicesPrinted(List<Guid> orderIds)
		{
			var response = GetResponse("Orders/SetInvoicesPrinted", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Mark a list of orders as label printed 
        /// </summary>
        /// <param name="orderIds">List of orders to mark as label printed</param>
        /// <returns>Returns the list of orders that have changed label printed status</returns>
        public List<Guid> SetLabelsPrinted(List<Guid> orderIds)
		{
			var response = GetResponse("Orders/SetLabelsPrinted", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Update the customer info of a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="info">Customer info</param>
        /// <param name="saveToCrm">Whether to save the shipping address into CRM, default = false</param>
        /// <returns>OrderTotalsInfo object with totals updated. If the country has changed, tax rate could have changed as well.</returns>
        public OrderTotalsInfo SetOrderCustomerInfo(Guid orderId,OrderCustomerInfo info,Boolean? saveToCrm)
		{
			var response = GetResponse("Orders/SetOrderCustomerInfo", "orderId=" + orderId + "&info=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(info)) + "&saveToCrm=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(saveToCrm)) + "");
            return JsonFormatter.ConvertFromJson<OrderTotalsInfo>(response);
		}

		/// <summary>
        /// Update the general info of a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="info">General info</param>
        /// <param name="wasDraft">Indicate if the order was a draft before this operation</param>
        public void SetOrderGeneralInfo(Guid orderId,OrderGeneralInfo info,Boolean wasDraft)
		{
			GetResponse("Orders/SetOrderGeneralInfo", "orderId=" + orderId + "&info=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(info)) + "&wasDraft=" + wasDraft + "");
		}

		/// <summary>
        /// Set the order notes for a specific order
        /// SetOrderNotes overwrites the existing order notes with those in the list provided. 
        /// Any existing notes should be retrieved using GetOrderNotes and added to this list, so that they are not lost/overwritten. 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="orderNotes">Notes</param>
        public void SetOrderNotes(Guid orderId,List<OrderNote> orderNotes)
		{
			GetResponse("Orders/SetOrderNotes", "orderId=" + orderId + "&orderNotes=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderNotes)) + "");
		}

		/// <summary>
        /// Designed to save order packaging when it has already been calculated but not saved or is a manual edit. 
        /// </summary>
        /// <param name="request">Request object with data to be saved in the database</param>
        public CalcOrderHeader SetOrderPackaging(SetOrderPackagingRequest request)
		{
			var response = GetResponse("Orders/SetOrderPackaging", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CalcOrderHeader>(response);
		}

		/// <summary>
        /// Split an order by packaging 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="packagingSplit">Order split</param>
        public UpdateTotalsResult SetOrderPackagingSplit(Guid orderId,List<OrderPackagingSplit> packagingSplit)
		{
			var response = GetResponse("Orders/SetOrderPackagingSplit", "orderId=" + orderId + "&packagingSplit=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(packagingSplit)) + "");
            return JsonFormatter.ConvertFromJson<UpdateTotalsResult>(response);
		}

		/// <summary>
        /// Update the shipping info of a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="info">Shipping info</param>
        public UpdateTotalsResult SetOrderShippingInfo(Guid orderId,UpdateOrderShippingInfoRequest info)
		{
			var response = GetResponse("Orders/SetOrderShippingInfo", "orderId=" + orderId + "&info=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(info)) + "");
            return JsonFormatter.ConvertFromJson<UpdateTotalsResult>(response);
		}

		/// <summary>
        /// Designed to save order split packaging after a manual override 
        /// </summary>
        /// <param name="request">Request object with data to be saved in the database</param>
        public CalcOrderHeader SetOrderSplitPackagingManualOverwrite(CalcOrderHeader request)
		{
			var response = GetResponse("Orders/SetOrderSplitPackagingManualOverwrite", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CalcOrderHeader>(response);
		}

		/// <summary>
        /// Update totals info of a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="info">Totals info</param>
        public void SetOrderTotalsInfo(Guid orderId,OrderTotalsInfo info)
		{
			GetResponse("Orders/SetOrderTotalsInfo", "orderId=" + orderId + "&info=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(info)) + "");
		}

		/// <summary>
        /// Set the available payment methods 
        /// </summary>
        /// <param name="paymentMethods">List of payment methods</param>
        /// <returns>List of payment methods with new ids updated</returns>
        public List<PaymentMethod> SetPaymentMethods(PaymentMethod[] paymentMethods)
		{
			var response = GetResponse("Orders/SetPaymentMethods", "paymentMethods=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(paymentMethods)) + "");
            return JsonFormatter.ConvertFromJson<List<PaymentMethod>>(response);
		}

		/// <summary>
        /// Sets the print flag for the given orders 
        /// </summary>
        /// <param name="Request"></param>
        public void SetPickListPrinted(SetPickListPrintedRequest Request)
		{
			GetResponse("Orders/SetPickListPrinted", "Request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(Request)) + "");
		}

		/// <summary>
        /// Split a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="newOrders">New orders</param>
        /// <param name="type">Split type</param>
        /// <param name="fulfilmentLocationId">Current fulfilment center</param>
        /// <returns>List of orders created</returns>
        public List<OpenOrder> SplitOrder(Guid orderId,OrderSplit[] newOrders,String type,Guid fulfilmentLocationId,Boolean recalcPackaging = false)
		{
			var response = GetResponse("Orders/SplitOrder", "orderId=" + orderId + "&newOrders=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(newOrders)) + "&type=" + System.Net.WebUtility.UrlEncode(type) + "&fulfilmentLocationId=" + fulfilmentLocationId + "&recalcPackaging=" + recalcPackaging + "");
            return JsonFormatter.ConvertFromJson<List<OpenOrder>>(response);
		}

		/// <summary>
        /// Unassign a list of orders to a specific folder 
        /// </summary>
        /// <param name="orderIds">list of order ids to be assigned</param>
        /// <param name="folder">folder to be unassigned</param>
        public List<Guid> UnassignToFolder(List<Guid> orderIds,String folder)
		{
			var response = GetResponse("Orders/UnassignToFolder", "orderIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderIds)) + "&folder=" + System.Net.WebUtility.UrlEncode(folder) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Updates additional info of a specific item 
        /// </summary>
        /// <param name="request"></param>
        public void UpdateAdditionalInfo(UpdateAdditionalInfoRequest request)
		{
			GetResponse("Orders/UpdateAdditionalInfo", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Update the billing address of a specific order 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="billingAddress">Billing address</param>
        public void UpdateBillingAddress(Guid orderId,CustomerAddress billingAddress)
		{
			GetResponse("Orders/UpdateBillingAddress", "orderId=" + orderId + "&billingAddress=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(billingAddress)) + "");
		}

		/// <summary>
        /// Update linked item 
        /// </summary>
        /// <param name="pkStockId">Stock id</param>
        /// <param name="pkStockItemId">Stock item id</param>
        /// <param name="source">Source</param>
        /// <param name="subSource">Subsource</param>
        /// <param name="channelSKU">Channel SKU</param>
        public void UpdateLinkItem(Guid pkStockId,Guid pkStockItemId,String source,String subSource,String channelSKU)
		{
			GetResponse("Orders/UpdateLinkItem", "pkStockId=" + pkStockId + "&pkStockItemId=" + pkStockItemId + "&source=" + System.Net.WebUtility.UrlEncode(source) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "&channelSKU=" + System.Net.WebUtility.UrlEncode(channelSKU) + "");
		}

		/// <summary>
        /// Update an order item 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="orderItem">The order item to be updated</param>
        /// <param name="fulfilmentCenter">Current fulfilment center</param>
        /// <param name="source">Source</param>
        /// <param name="subSource"></param>
        /// <returns>Result of the update with new order totals</returns>
        public UpdateOrderItemResult UpdateOrderItem(Guid orderId,OrderItem orderItem,Guid fulfilmentCenter,String source,String subSource)
		{
			var response = GetResponse("Orders/UpdateOrderItem", "orderId=" + orderId + "&orderItem=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderItem)) + "&fulfilmentCenter=" + fulfilmentCenter + "&source=" + System.Net.WebUtility.UrlEncode(source) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "");
            return JsonFormatter.ConvertFromJson<UpdateOrderItemResult>(response);
		}

		/// <summary>
        /// Validate a coupon 
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="barcode">Coupon barcode</param>
        /// <returns>Coupon validation</returns>
        public CouponValidationResult ValidateCoupon(Guid orderId,String barcode)
		{
			var response = GetResponse("Orders/ValidateCoupon", "orderId=" + orderId + "&barcode=" + System.Net.WebUtility.UrlEncode(barcode) + "");
            return JsonFormatter.ConvertFromJson<CouponValidationResult>(response);
		} 
    }
}