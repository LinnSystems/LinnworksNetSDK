using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace LinnworksAPI
{public static class PurchaseOrderMethods 
{ public static Search_PurchaseOrdersResult Search_PurchaseOrders(Search_PurchaseOrderParameter searchParameter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Search_PurchaseOrdersResult>(Factory.GetResponse("PurchaseOrder/Search_PurchaseOrders", "searchParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(searchParameter) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Guid Create_PurchaseOrder_Initial(Create_PurchaseOrder_InitialParameter createParameters,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("PurchaseOrder/Create_PurchaseOrder_Initial", "createParameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(createParameters) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Update_PurchaseOrderItemResponse Add_PurchaseOrderItem(Add_PurchaseOrderItemParameter addItemParameter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderItem", "addItemParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(addItemParameter) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Update_PurchaseOrderItemResponse Update_PurchaseOrderItem(Update_PurchaseOrderItemParameter updateItemParameter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Update_PurchaseOrderItem", "updateItemParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(updateItemParameter) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static PurchaseOrderHeader Delete_PurchaseOrderItem(Delete_PurchaseOrderItemParameter deleteItemParameter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<PurchaseOrderHeader>(Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderItem", "deleteItemParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(deleteItemParameter) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Get_PurchaseOrderResponse Get_PurchaseOrder(Guid pkPurchaseId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Get_PurchaseOrderResponse>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrder", "pkPurchaseId=" + pkPurchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<PurchaseOrderNote> Get_PurchaseOrderNote(Guid pkPurchaseId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PurchaseOrderNote>>(Factory.GetResponse("PurchaseOrder/Get_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Int32 Add_PurchaseOrderNote(Guid pkPurchaseId,String Note,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("PurchaseOrder/Add_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&Note=" + Note + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Int32 Delete_PurchaseOrderNote(Guid pkPurchaseId,Guid pkPurchaseOrderNoteId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("PurchaseOrder/Delete_PurchaseOrderNote", "pkPurchaseId=" + pkPurchaseId + "&pkPurchaseOrderNoteId=" + pkPurchaseOrderNoteId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static PurchaseOrderHeader Change_PurchaseOrderStatus(Change_PurchaseOrderStatusParameter changeStatusParameter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<PurchaseOrderHeader>(Factory.GetResponse("PurchaseOrder/Change_PurchaseOrderStatus", "changeStatusParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(changeStatusParameter) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Update_PurchaseOrderItemResponse Deliver_PurchaseItem(Deliver_PurchaseItemParameter deliverItemParameter,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Update_PurchaseOrderItemResponse>(Factory.GetResponse("PurchaseOrder/Deliver_PurchaseItem", "deliverItemParameter=" + Newtonsoft.Json.JsonConvert.SerializeObject(deliverItemParameter) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<PurchaseOrderStatus> GetPurchaseOrderStatusList(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PurchaseOrderStatus>>(Factory.GetResponse("PurchaseOrder/GetPurchaseOrderStatusList", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
} 
}
}