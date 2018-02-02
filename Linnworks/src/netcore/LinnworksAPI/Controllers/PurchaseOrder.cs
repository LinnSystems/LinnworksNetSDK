using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class PurchaseOrderController : BaseController, IPurchaseOrderController
    {
        public PurchaseOrderController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Adds extended properties to a purchase order. Property name must be unique otherwise the method throws an error. Maxium number of extended properties allowed for a single purchase order is 50. If total count of extended properties exceeds 50 an error will be thrown. 
        /// </summary>
        /// <param name="request"></param>
        public Add_PurchaseOrderExtendedPropertyResponse Add_PurchaseOrderExtendedProperty(Add_PurchaseOrderExtendedPropertyRequest request)
		{
			var response = GetResponse("PurchaseOrder/Add_PurchaseOrderExtendedProperty", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<Add_PurchaseOrderExtendedPropertyResponse>(response);
		}

		/// <summary>
        /// Method adds purchase order item to an existing PENDING order. Items can only be added to PENDING purchase orders. Returns class that represents modified/recalculated purchase order header and modified purchase order item line 
        /// </summary>
        /// <param name="addItemParameter">Add purchase item parameter class</param>
        /// <returns>Returns class that represents modified/recalculated purchase order header and modified purchase order item line</returns>
        public Update_PurchaseOrderItemResponse Add_PurchaseOrderItem(Add_PurchaseOrderItemParameter addItemParameter)
		{
			var response = GetResponse("PurchaseOrder/Add_PurchaseOrderItem", "addItemParameter=" + JsonFormatter.ConvertToJson(addItemParameter) + "");
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
			var response = GetResponse("PurchaseOrder/Add_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&Note=" + Note + "");
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
			var response = GetResponse("PurchaseOrder/Change_PurchaseOrderStatus", "changeStatusParameter=" + JsonFormatter.ConvertToJson(changeStatusParameter) + "");
            return JsonFormatter.ConvertFromJson<PurchaseOrderHeader>(response);
		}

		/// <summary>
        /// Creates initial purchase order in pending status. Once PO is created you can add stock items to it. 
        /// </summary>
        /// <param name="createParameters">pkPurchaseId</param>
        /// <returns>New Purchase Order Id</returns>
        public Guid Create_PurchaseOrder_Initial(Create_PurchaseOrder_InitialParameter createParameters)
		{
			var response = GetResponse("PurchaseOrder/Create_PurchaseOrder_Initial", "createParameters=" + JsonFormatter.ConvertToJson(createParameters) + "");
            return JsonFormatter.ConvertFromJson<Guid>(response);
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
			GetResponse("PurchaseOrder/Delete_PurchaseOrderExtendedProperty", "request=" + JsonFormatter.ConvertToJson(request) + "");
		}

		/// <summary>
        /// Delete purchase order item line from PENDING order. Returns recalculated/modified purchase order header 
        /// </summary>
        /// <param name="deleteItemParameter">Delete purchase order item parameter</param>
        /// <returns>Returns recalculated/modified purchase order header</returns>
        public PurchaseOrderHeader Delete_PurchaseOrderItem(Delete_PurchaseOrderItemParameter deleteItemParameter)
		{
			var response = GetResponse("PurchaseOrder/Delete_PurchaseOrderItem", "deleteItemParameter=" + JsonFormatter.ConvertToJson(deleteItemParameter) + "");
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
			var response = GetResponse("PurchaseOrder/Deliver_PurchaseItem", "deliverItemParameter=" + JsonFormatter.ConvertToJson(deliverItemParameter) + "");
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
			var response = GetResponse("PurchaseOrder/Get_PurchaseOrderAudit", "auditLog=" + JsonFormatter.ConvertToJson(auditLog) + "");
            return JsonFormatter.ConvertFromJson<List<PurchaseOrderAudit>>(response);
		}

		/// <summary>
        /// Get all purchase order extended properties 
        /// </summary>
        /// <param name="request"></param>
        public Get_PurchaseOrderExtendedPropertyResponse Get_PurchaseOrderExtendedProperty(Get_PurchaseOrderExtendedPropertyRequest request)
		{
			var response = GetResponse("PurchaseOrder/Get_PurchaseOrderExtendedProperty", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<Get_PurchaseOrderExtendedPropertyResponse>(response);
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
			var response = GetResponse("PurchaseOrder/GetPurchaseOrdersWithStockItems", "purchaseOrder=" + JsonFormatter.ConvertToJson(purchaseOrder) + "");
            return JsonFormatter.ConvertFromJson<List<Guid>>(response);
		}

		/// <summary>
        /// Searches purchase order by a number of parameters, such as Date of Purchase, status, reference number.
        /// Returns paged result of purchase order header. 
        /// </summary>
        /// <param name="searchParameter">Search Parameter class</param>
        /// <returns>Response class which contains Result - the list of purchase order headers and paging information</returns>
        public Search_PurchaseOrdersResult Search_PurchaseOrders(Search_PurchaseOrderParameter searchParameter)
		{
			var response = GetResponse("PurchaseOrder/Search_PurchaseOrders", "searchParameter=" + JsonFormatter.ConvertToJson(searchParameter) + "");
            return JsonFormatter.ConvertFromJson<Search_PurchaseOrdersResult>(response);
		}

		/// <summary>
        /// Updates purchase order extended property by id. If supplied id doesn't exists, the routine will throw an error
        /// The routine checks for duplicated propery names and throws an error if duplicated property name. 
        /// </summary>
        /// <param name="request"></param>
        public void Update_PurchaseOrderExtendedProperty(Update_PurchaseOrderExtendedPropertyRequest request)
		{
			GetResponse("PurchaseOrder/Update_PurchaseOrderExtendedProperty", "request=" + JsonFormatter.ConvertToJson(request) + "");
		}

		/// <summary>
        /// Update purchase order header, only if status is not Delivered. Returns modified/recalculated purchase order header 
        /// </summary>
        /// <param name="updateParameter">Update purchase order header class</param>
        /// <returns>Returns modified/recalculated purchase order header</returns>
        public PurchaseOrderHeader Update_PurchaseOrderHeader(Update_PurchaseOrderHeaderParameter updateParameter)
		{
			var response = GetResponse("PurchaseOrder/Update_PurchaseOrderHeader", "updateParameter=" + JsonFormatter.ConvertToJson(updateParameter) + "");
            return JsonFormatter.ConvertFromJson<PurchaseOrderHeader>(response);
		}

		/// <summary>
        /// Update purchase order item, quantity, cost, pack size, pack quantity, in PENDING order only. Returns class that represents modified/recalculated purchase order header and modified purchase order item line 
        /// </summary>
        /// <param name="updateItemParameter">Edit purchase order item class</param>
        /// <returns>Returns class that represents modified/recalculated purchase order header and modified purchase order item line</returns>
        public Update_PurchaseOrderItemResponse Update_PurchaseOrderItem(Update_PurchaseOrderItemParameter updateItemParameter)
		{
			var response = GetResponse("PurchaseOrder/Update_PurchaseOrderItem", "updateItemParameter=" + JsonFormatter.ConvertToJson(updateItemParameter) + "");
            return JsonFormatter.ConvertFromJson<Update_PurchaseOrderItemResponse>(response);
		} 
    }
}