using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class PurchaseOrderController : BaseController, IPurchaseOrderController
    {
        public PurchaseOrderController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Add new additional cost type 
        /// </summary>
        public Add_AdditionalCostTypesResponse Add_AdditionalCostTypes(Add_AdditionalCostTypesRequest request)
		{
			var response = GetResponse("PurchaseOrder/Add_AdditionalCostTypes", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Add_AdditionalCostTypesResponse>(response);
		}

		/// <summary>
        /// Adds extended properties to a purchase order. Property name must be unique otherwise the method throws an error. Maxium number of extended properties allowed for a single purchase order is 50. If total count of extended properties exceeds 50 an error will be thrown. 
        /// </summary>
        /// <param name="request"></param>
        public Add_PurchaseOrderExtendedPropertyResponse Add_PurchaseOrderExtendedProperty(Add_PurchaseOrderExtendedPropertyRequest request)
		{
			var response = GetResponse("PurchaseOrder/Add_PurchaseOrderExtendedProperty", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Add_PurchaseOrderExtendedPropertyResponse>(response);
		}

		/// <summary>
        /// Method adds purchase order item to an existing PENDING order. Items can only be added to PENDING purchase orders. Returns class that represents modified/recalculated purchase order header and modified purchase order item line 
        /// </summary>
        /// <param name="addItemParameter">Add purchase item parameter class</param>
        /// <returns>Returns class that represents modified/recalculated purchase order header and modified purchase order item line</returns>
        public Update_PurchaseOrderItemResponse Add_PurchaseOrderItem(Add_PurchaseOrderItemParameter addItemParameter)
		{
			var response = GetResponse("PurchaseOrder/Add_PurchaseOrderItem", "addItemParameter=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(addItemParameter)) + "");
            return JsonFormatter.ConvertFromJson<Update_PurchaseOrderItemResponse>(response);
		}

		/// <summary>
        /// Add purchase order note 
        /// </summary>
        /// <param name="pkPurchaseId">Purchase order unique identifier</param>
        /// <param name="Note">Note text, 2000 chars max (longer notes are truncated)</param>
        /// <returns>Returns the new purchase order note</returns>
        public PurchaseOrderNote Add_PurchaseOrderNote(Guid pkPurchaseId,String Note)
		{
			var response = GetResponse("PurchaseOrder/Add_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&Note=" + System.Net.WebUtility.UrlEncode(Note) + "");
            return JsonFormatter.ConvertFromJson<PurchaseOrderNote>(response);
		}

		/// <summary>
        /// Change purchase order status. Can change from:
        /// PENDING to OPEN, which will populate Due (OnOrder) values in stock levels,
        /// OPEN to DELIVERED, which will consolidate Due values in stock levels 
        /// PARTIAL to DELIVERED, which will consolidate Due values in stock levels 
        /// </summary>
        /// <param name="changeStatusParameter">Class that represents the parameters for Changing the Purchase Order Status</param>
        /// <returns>Returns the Purchase Order Header for the Purchase Order</returns>
        public PurchaseOrderHeader Change_PurchaseOrderStatus(Change_PurchaseOrderStatusParameter changeStatusParameter)
		{
			var response = GetResponse("PurchaseOrder/Change_PurchaseOrderStatus", "changeStatusParameter=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(changeStatusParameter)) + "");
            return JsonFormatter.ConvertFromJson<PurchaseOrderHeader>(response);
		}

		/// <summary>
        /// Creates initial purchase order in pending status. Once PO is created you can add stock items to it. 
        /// </summary>
        /// <param name="createParameters">pkPurchaseId</param>
        /// <returns>New Purchase Order Id</returns>
        public Guid Create_PurchaseOrder_Initial(Create_PurchaseOrder_InitialParameter createParameters)
		{
			var response = GetResponse("PurchaseOrder/Create_PurchaseOrder_Initial", "createParameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(createParameters)) + "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
		}

		/// <summary>
        /// Delete additional cost type 
        /// </summary>
        public void Delete_AdditionalCostTypes(Delete_AdditionalCostTypesRequest request)
		{
			GetResponse("PurchaseOrder/Delete_AdditionalCostTypes", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Delete a Purchase Order 
        /// </summary>
        /// <param name="pkPurchaseId">Purchase Order unique id</param>
        public void Delete_PurchaseOrder(Guid pkPurchaseId)
		{
			GetResponse("PurchaseOrder/Delete_PurchaseOrder", "pkPurchaseId=" + pkPurchaseId + "");
		}

		/// <summary>
        /// Delete extended property items by id 
        /// </summary>
        /// <param name="request"></param>
        public void Delete_PurchaseOrderExtendedProperty(Delete_PurchaseOrderExtendedPropertyRequest request)
		{
			GetResponse("PurchaseOrder/Delete_PurchaseOrderExtendedProperty", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Delete purchase order item line from PENDING order. Returns recalculated/modified purchase order header 
        /// </summary>
        /// <param name="deleteItemParameter">Delete purchase order item parameter</param>
        /// <returns>Returns recalculated/modified purchase order header</returns>
        public PurchaseOrderHeader Delete_PurchaseOrderItem(Delete_PurchaseOrderItemParameter deleteItemParameter)
		{
			var response = GetResponse("PurchaseOrder/Delete_PurchaseOrderItem", "deleteItemParameter=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(deleteItemParameter)) + "");
            return JsonFormatter.ConvertFromJson<PurchaseOrderHeader>(response);
		}

		/// <summary>
        /// Delete Note for Purchase Order 
        /// </summary>
        /// <param name="pkPurchaseId">Purchase order unique identifier</param>
        /// <param name="pkPurchaseOrderNoteId">Purchase order note unique identifier</param>
        /// <returns>Returns number of notes on the purchase order</returns>
        public Int32 Delete_PurchaseOrderNote(Guid pkPurchaseId,Guid pkPurchaseOrderNoteId)
		{
			var response = GetResponse("PurchaseOrder/Delete_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&pkPurchaseOrderNoteId=" + pkPurchaseOrderNoteId + "");
            return JsonFormatter.ConvertFromJson<Int32>(response);
		}

		/// <summary>
        /// Deliver purchase order item. This will affect current stock level according to the delivered quantity. 
        /// You can specify the total number of delivered items. If all items are delivered, the purchase order status will be changed to delivered 
        /// </summary>
        /// <param name="deliverItemParameter">Class that represents parameters for Deliver Purchase Item</param>
        /// <returns>Purchase order header and affected purchase order item records</returns>
        public Update_PurchaseOrderItemResponse Deliver_PurchaseItem(Deliver_PurchaseItemParameter deliverItemParameter)
		{
			var response = GetResponse("PurchaseOrder/Deliver_PurchaseItem", "deliverItemParameter=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(deliverItemParameter)) + "");
            return JsonFormatter.ConvertFromJson<Update_PurchaseOrderItemResponse>(response);
		}

		/// <summary>
        /// Update purchase order item, quantity, cost, pack size, pack quantity, in PENDING order only. Returns class that represents modified/recalculated purchase order header and modified purchase order item line 
        /// </summary>
        /// <param name="purchaseId">Purchase Order ID</param>
        /// <returns>Purchase order header and affected purchase order items records</returns>
        public Deliver_PurchaseOrderItemAllResponse Deliver_PurchaseItemAll(Guid purchaseId)
		{
			var response = GetResponse("PurchaseOrder/Deliver_PurchaseItemAll", "purchaseId=" + purchaseId + "");
            return JsonFormatter.ConvertFromJson<Deliver_PurchaseOrderItemAllResponse>(response);
		}

		/// <summary>
        /// Update purchase order item, quantity, cost, pack size, pack quantity, in PENDING order only. Returns class that represents modified/recalculated purchase order header and modified purchase order item line 
        /// </summary>
        /// <param name="purchaseId">Purchase Order ID</param>
        /// <returns>Purchase order header and affected purchase order items records</returns>
        public Deliver_PurchaseOrderItemAllNoBatchResponse Deliver_PurchaseItemAll_ExceptBatchItems(Guid purchaseId)
		{
			var response = GetResponse("PurchaseOrder/Deliver_PurchaseItemAll_ExceptBatchItems", "purchaseId=" + purchaseId + "");
            return JsonFormatter.ConvertFromJson<Deliver_PurchaseOrderItemAllNoBatchResponse>(response);
		}

		public void Deliver_PurchaseItems_WithQuantity(Deliver_PurchaseItems_WithQuantityRequest request)
		{
			GetResponse("PurchaseOrder/Deliver_PurchaseItems_WithQuantity", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Try to find an item by SKU of SpplierCode 
        /// </summary>
        /// <param name="request"></param>
        public FindStockItem_Response FindStockItem(FindStockItemRequest request)
		{
			var response = GetResponse("PurchaseOrder/FindStockItem", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<FindStockItem_Response>(response);
		}

		/// <summary>
        /// Get additional costs of a purchase order 
        /// </summary>
        /// <param name="request"></param>
        public Get_Additional_CostResponse Get_Additional_Cost(Get_Additional_CostRequest request)
		{
			var response = GetResponse("PurchaseOrder/Get_Additional_Cost", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Get_Additional_CostResponse>(response);
		}

		/// <summary>
        /// Get purchase order additional costs types 
        /// </summary>
        public Get_AdditionalCostTypesResponse Get_AdditionalCostTypes()
		{
			var response = GetResponse("PurchaseOrder/Get_AdditionalCostTypes", "");
            return JsonFormatter.ConvertFromJson<Get_AdditionalCostTypesResponse>(response);
		}

		/// <summary>
        /// Get delivered item records for specific PO 
        /// </summary>
        /// <param name="pkPurchaseId">PO id</param>
        public Get_DeliveredRecords_Response Get_DeliveredRecords(Guid pkPurchaseId)
		{
			var response = GetResponse("PurchaseOrder/Get_DeliveredRecords", "pkPurchaseId=" + pkPurchaseId + "");
            return JsonFormatter.ConvertFromJson<Get_DeliveredRecords_Response>(response);
		}

		/// <summary>
        /// Get the URL of the CSV file for the specific purchase order 
        /// </summary>
        /// <param name="request"></param>
        public Get_EmailCSVFileResponse Get_EmailCSVFile(Get_EmailCSVFileRequest request)
		{
			var response = GetResponse("PurchaseOrder/Get_EmailCSVFile", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Get_EmailCSVFileResponse>(response);
		}

		/// <summary>
        /// Get delivered item records for specific PO 
        /// </summary>
        /// <param name="request"></param>
        public Get_EmailsSentResponse Get_EmailsSent(Get_EmailsSentRequest request)
		{
			var response = GetResponse("PurchaseOrder/Get_EmailsSent", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Get_EmailsSentResponse>(response);
		}

		/// <summary>
        /// Get payment statements of a purchase order 
        /// </summary>
        /// <param name="request"></param>
        public Get_PaymentStatementResponse Get_Payment_Statement(Get_PaymentStatementRequest request)
		{
			var response = GetResponse("PurchaseOrder/Get_Payment_Statement", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Get_PaymentStatementResponse>(response);
		}

		/// <summary>
        /// Get purchase order header and items in one call 
        /// </summary>
        /// <param name="pkPurchaseId">Purchase Order unique identifier</param>
        /// <returns>Returns class containing purchase order header and items</returns>
        public Get_PurchaseOrderResponse Get_PurchaseOrder(Guid pkPurchaseId)
		{
			var response = GetResponse("PurchaseOrder/Get_PurchaseOrder", "pkPurchaseId=" + pkPurchaseId + "");
            return JsonFormatter.ConvertFromJson<Get_PurchaseOrderResponse>(response);
		}

		/// <summary>
        /// Get the Audit Log of a Purchase Order. Returns maxium 1000 records in descending order 
        /// </summary>
        /// <param name="auditLog">Class that represents parameters when searching the Audit Log</param>
        /// <returns>Returns the Audit Log for the Purchase Order</returns>
        public List<PurchaseOrderAudit> Get_PurchaseOrderAudit(Search_PurchaseOrder_AuditLog auditLog)
		{
			var response = GetResponse("PurchaseOrder/Get_PurchaseOrderAudit", "auditLog=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(auditLog)) + "");
            return JsonFormatter.ConvertFromJson<List<PurchaseOrderAudit>>(response);
		}

		/// <summary>
        /// Get all purchase order extended properties 
        /// </summary>
        /// <param name="request"></param>
        public Get_PurchaseOrderExtendedPropertyResponse Get_PurchaseOrderExtendedProperty(Get_PurchaseOrderExtendedPropertyRequest request)
		{
			var response = GetResponse("PurchaseOrder/Get_PurchaseOrderExtendedProperty", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Get_PurchaseOrderExtendedPropertyResponse>(response);
		}

		/// <summary>
        /// Get a list of open orders bound to a purchase order item 
        /// </summary>
        /// <param name="request"></param>
        public Get_PurchaseOrderItem_OpenOrdersResponse Get_PurchaseOrderItem_OpenOrders(Get_PurchaseOrderItem_OpenOrdersRequest request)
		{
			var response = GetResponse("PurchaseOrder/Get_PurchaseOrderItem_OpenOrders", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Get_PurchaseOrderItem_OpenOrdersResponse>(response);
		}

		/// <summary>
        /// Get purchase order notes 
        /// </summary>
        /// <param name="pkPurchaseId">Purchase order unique identifier</param>
        /// <returns>List of purchase order notes</returns>
        public List<PurchaseOrderNote> Get_PurchaseOrderNote(Guid pkPurchaseId)
		{
			var response = GetResponse("PurchaseOrder/Get_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "");
            return JsonFormatter.ConvertFromJson<List<PurchaseOrderNote>>(response);
		}

		/// <summary>
        /// Get a list of available statuses 
        /// </summary>
        /// <returns>Returns a list of available statuses</returns>
        public List<PurchaseOrderStatus> GetPurchaseOrderStatusList()
		{
			var response = GetResponse("PurchaseOrder/GetPurchaseOrderStatusList", "");
            return JsonFormatter.ConvertFromJson<List<PurchaseOrderStatus>>(response);
		}

		/// <summary>
        /// Gets a list of Purchase Order Ids that contain undelivered stock items 
        /// </summary>
        /// <param name="purchaseOrder">Purchase Order class made up of a Stock Item Id and a nullable Location Id</param>
        /// <returns>Returns a list of Purchase Order Ids with undelivered stock using the Stock Item and Location Id parameters</returns>
        public List<Guid> GetPurchaseOrdersWithStockItems(PurchaseOrderWithStockItem purchaseOrder)
		{
			var response = GetResponse("PurchaseOrder/GetPurchaseOrdersWithStockItems", "purchaseOrder=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(purchaseOrder)) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Modify purchase order additional costs. You can add new lines, update and delete existing. The method will return modified list back to you with each record identified by unique identifier. 
        /// Purchase Order header will also be returned with new total recalculated 
        /// </summary>
        /// <param name="request"></param>
        public Modify_AdditionalCostResponse Modify_AdditionalCost(Modify_AdditionalCostRequest request)
		{
			var response = GetResponse("PurchaseOrder/Modify_AdditionalCost", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Modify_AdditionalCostResponse>(response);
		}

		/// <summary>
        /// Modify additional cost allocation items 
        /// </summary>
        /// <param name="request"></param>
        public Modify_AdditionalCostAllocationResponse Modify_AdditionalCostAllocation(Modify_AdditionalCostAllocationRequest request)
		{
			var response = GetResponse("PurchaseOrder/Modify_AdditionalCostAllocation", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Modify_AdditionalCostAllocationResponse>(response);
		}

		/// <summary>
        /// Modify purchase order payment statements. You can add new lines, update and delete existing. The method will return modified list back to you with each record identified by unique identifier. 
        /// </summary>
        /// <param name="request"></param>
        public Modify_PaymentStatementResponse Modify_PaymentStatement(Modify_PaymentStatementRequest request)
		{
			var response = GetResponse("PurchaseOrder/Modify_PaymentStatement", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Modify_PaymentStatementResponse>(response);
		}

		/// <summary>
        /// Delete, add and update purchase order items and cause purchase order totals recalculation 
        /// </summary>
        /// <returns>Returns all added and modified purchase order items and purchase order header</returns>
        public Modify_PurchaseOrderItems_BulkResponse Modify_PurchaseOrderItems_Bulk(Modify_PurchaseOrderItems_BulkRequest request)
		{
			var response = GetResponse("PurchaseOrder/Modify_PurchaseOrderItems_Bulk", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Modify_PurchaseOrderItems_BulkResponse>(response);
		}

		/// <summary>
        /// Searches purchase order by a number of parameters, such as Date of Purchase, status, reference number.
        /// Returns paged result of purchase order header. 
        /// </summary>
        /// <param name="searchParameter">Search Parameter class</param>
        /// <returns>Response class which contains Result - the list of purchase order headers and paging information</returns>
        public Search_PurchaseOrdersResult Search_PurchaseOrders(Search_PurchaseOrderParameter searchParameter)
		{
			var response = GetResponse("PurchaseOrder/Search_PurchaseOrders", "searchParameter=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(searchParameter)) + "");
            return JsonFormatter.ConvertFromJson<Search_PurchaseOrdersResult>(response);
		}

		/// <summary>
        /// Searches purchase order by a number of parameters, such as Date of Purchase, status, reference number.
        /// Returns paged result of purchase order header. 
        /// </summary>
        /// <param name="request">Search Parameters</param>
        /// <returns>Response class which contains Result - the list of purchase order headers and paging information</returns>
        public Search_PurchaseOrdersResult Search_PurchaseOrders2(Search_PurchaseOrder2Request request)
		{
			var response = GetResponse("PurchaseOrder/Search_PurchaseOrders2", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Search_PurchaseOrdersResult>(response);
		}

		/// <summary>
        /// Update additional cost type 
        /// </summary>
        public Update_AdditionalCostTypesResponse Update_AdditionalCostTypes(Update_AdditionalCostTypesRequest request)
		{
			var response = GetResponse("PurchaseOrder/Update_AdditionalCostTypes", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<Update_AdditionalCostTypesResponse>(response);
		}

		/// <summary>
        /// Updates purchase order extended property by id. If supplied id doesn't exists, the routine will throw an error
        /// The routine checks for duplicated propery names and throws an error if duplicated property name. 
        /// </summary>
        /// <param name="request"></param>
        public void Update_PurchaseOrderExtendedProperty(Update_PurchaseOrderExtendedPropertyRequest request)
		{
			GetResponse("PurchaseOrder/Update_PurchaseOrderExtendedProperty", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Update purchase order header, only if status is not Delivered. Returns modified/recalculated purchase order header 
        /// </summary>
        /// <param name="updateParameter">Update purchase order header class</param>
        /// <returns>Returns modified/recalculated purchase order header</returns>
        public PurchaseOrderHeader Update_PurchaseOrderHeader(Update_PurchaseOrderHeaderParameter updateParameter)
		{
			var response = GetResponse("PurchaseOrder/Update_PurchaseOrderHeader", "updateParameter=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(updateParameter)) + "");
            return JsonFormatter.ConvertFromJson<PurchaseOrderHeader>(response);
		}

		/// <summary>
        /// Update purchase order item, quantity, cost, pack size, pack quantity, in PENDING order only. Returns class that represents modified/recalculated purchase order header and modified purchase order item line 
        /// </summary>
        /// <param name="updateItemParameter">Edit purchase order item class</param>
        /// <returns>Returns class that represents modified/recalculated purchase order header and modified purchase order item line</returns>
        public Update_PurchaseOrderItemResponse Update_PurchaseOrderItem(Update_PurchaseOrderItemParameter updateItemParameter)
		{
			var response = GetResponse("PurchaseOrder/Update_PurchaseOrderItem", "updateItemParameter=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(updateItemParameter)) + "");
            return JsonFormatter.ConvertFromJson<Update_PurchaseOrderItemResponse>(response);
		} 
    }
}