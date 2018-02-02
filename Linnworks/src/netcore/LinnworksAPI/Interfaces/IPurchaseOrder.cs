using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IPurchaseOrderController
	{
		Add_PurchaseOrderExtendedPropertyResponse Add_PurchaseOrderExtendedProperty(Add_PurchaseOrderExtendedPropertyRequest request);
		Update_PurchaseOrderItemResponse Add_PurchaseOrderItem(Add_PurchaseOrderItemParameter addItemParameter);
		PurchaseOrderNote Add_PurchaseOrderNote(Guid pkPurchaseId,String Note);
		PurchaseOrderHeader Change_PurchaseOrderStatus(Change_PurchaseOrderStatusParameter changeStatusParameter);
		Guid Create_PurchaseOrder_Initial(Create_PurchaseOrder_InitialParameter createParameters);
		void Delete_PurchaseOrder(Guid pkPurchaseId);
		void Delete_PurchaseOrderExtendedProperty(Delete_PurchaseOrderExtendedPropertyRequest request);
		PurchaseOrderHeader Delete_PurchaseOrderItem(Delete_PurchaseOrderItemParameter deleteItemParameter);
		Int32 Delete_PurchaseOrderNote(Guid pkPurchaseId,Guid pkPurchaseOrderNoteId);
		Update_PurchaseOrderItemResponse Deliver_PurchaseItem(Deliver_PurchaseItemParameter deliverItemParameter);
		Deliver_PurchaseOrderItemAllResponse Deliver_PurchaseItemAll(Guid purchaseId);
		Deliver_PurchaseOrderItemAllNoBatchResponse Deliver_PurchaseItemAll_ExceptBatchItems(Guid purchaseId);
		Get_PurchaseOrderResponse Get_PurchaseOrder(Guid pkPurchaseId);
		List<PurchaseOrderAudit> Get_PurchaseOrderAudit(Search_PurchaseOrder_AuditLog auditLog);
		Get_PurchaseOrderExtendedPropertyResponse Get_PurchaseOrderExtendedProperty(Get_PurchaseOrderExtendedPropertyRequest request);
		List<PurchaseOrderNote> Get_PurchaseOrderNote(Guid pkPurchaseId);
		List<PurchaseOrderStatus> GetPurchaseOrderStatusList();
		List<Guid> GetPurchaseOrdersWithStockItems(PurchaseOrderWithStockItem purchaseOrder);
		Search_PurchaseOrdersResult Search_PurchaseOrders(Search_PurchaseOrderParameter searchParameter);
		void Update_PurchaseOrderExtendedProperty(Update_PurchaseOrderExtendedPropertyRequest request);
		PurchaseOrderHeader Update_PurchaseOrderHeader(Update_PurchaseOrderHeaderParameter updateParameter);
		Update_PurchaseOrderItemResponse Update_PurchaseOrderItem(Update_PurchaseOrderItemParameter updateItemParameter);
	} 
}