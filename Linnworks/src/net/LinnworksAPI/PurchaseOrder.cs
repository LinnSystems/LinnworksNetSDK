using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class PurchaseOrderMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static Search_PurchaseOrdersResult Search_PurchaseOrders(Search_PurchaseOrderParameter searchParameter, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Search_PurchaseOrdersResult>(Factory.GetResponse("PurchaseOrder/Search_PurchaseOrders", "searchParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(searchParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid Create_PurchaseOrder_Initial(Create_PurchaseOrder_InitialParameter createParameters, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("PurchaseOrder/Create_PurchaseOrder_Initial", "createParameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(createParameters, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PurchaseOrderHeader Update_PurchaseOrderHeader(Update_PurchaseOrderHeaderParameter updateParameter, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PurchaseOrderHeader>(Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderHeader", "updateParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(updateParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Update_PurchaseOrderItemResponse Add_PurchaseOrderItem(Add_PurchaseOrderItemParameter addItemParameter, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderItem", "addItemParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(addItemParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Update_PurchaseOrderItemResponse Update_PurchaseOrderItem(Update_PurchaseOrderItemParameter updateItemParameter, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderItem", "updateItemParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(updateItemParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PurchaseOrderHeader Delete_PurchaseOrderItem(Delete_PurchaseOrderItemParameter deleteItemParameter, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PurchaseOrderHeader>(Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderItem", "deleteItemParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(deleteItemParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<Guid> GetPurchaseOrdersWithStockItems(PurchaseOrderWithStockItem purchaseOrder, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Factory.GetResponse("PurchaseOrder/GetPurchaseOrdersWithStockItems", "purchaseOrder=" + Newtonsoft.Json.JsonConvert.SerializeObject(purchaseOrder, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Get_PurchaseOrderResponse Get_PurchaseOrder(Guid pkPurchaseId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Get_PurchaseOrderResponse>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrder", "pkPurchaseId=" + pkPurchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PurchaseOrderNote> Get_PurchaseOrderNote(Guid pkPurchaseId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PurchaseOrderNote>>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PurchaseOrderNote Add_PurchaseOrderNote(Guid pkPurchaseId, String Note, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PurchaseOrderNote>(Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&Note=" + Note + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Int32 Delete_PurchaseOrderNote(Guid pkPurchaseId, Guid pkPurchaseOrderNoteId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&pkPurchaseOrderNoteId=" + pkPurchaseOrderNoteId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PurchaseOrderHeader Change_PurchaseOrderStatus(Change_PurchaseOrderStatusParameter changeStatusParameter, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PurchaseOrderHeader>(Factory.GetResponse("PurchaseOrder/Change_PurchaseOrderStatus", "changeStatusParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(changeStatusParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Deliver_PurchaseOrderItemAllResponse Deliver_PurchaseItemAll(Guid purchaseId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Deliver_PurchaseOrderItemAllResponse>(Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItemAll", "purchaseId=" + purchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Update_PurchaseOrderItemResponse Deliver_PurchaseItem(Deliver_PurchaseItemParameter deliverItemParameter, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItem", "deliverItemParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(deliverItemParameter, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PurchaseOrderStatus> GetPurchaseOrderStatusList(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PurchaseOrderStatus>>(Factory.GetResponse("PurchaseOrder/GetPurchaseOrderStatusList", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void Delete_PurchaseOrder(Guid pkPurchaseId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrder", "pkPurchaseId=" + pkPurchaseId + "", ApiToken, ApiServer);
        }

        public static List<PurchaseOrderAudit> Get_PurchaseOrderAudit(Search_PurchaseOrder_AuditLog auditLog, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PurchaseOrderAudit>>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderAudit", "auditLog=" + Newtonsoft.Json.JsonConvert.SerializeObject(auditLog, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}