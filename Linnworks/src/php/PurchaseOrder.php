<?php
class PurchaseOrderMethods 
{ public static function Add_PurchaseOrderExtendedProperty($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Add_PurchaseOrderExtendedProperty", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function Add_PurchaseOrderItem($addItemParameter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Add_PurchaseOrderItem", "addItemParameter=" . json_encode($addItemParameter) . "", $ApiToken, $ApiServer)); 
}

public static function Add_PurchaseOrderNote($pkPurchaseId,$Note,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Add_PurchaseOrderNote", "pkPurchaseId=" . $pkPurchaseId . "&Note=" . $Note . "", $ApiToken, $ApiServer)); 
}

public static function Change_PurchaseOrderStatus($changeStatusParameter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Change_PurchaseOrderStatus", "changeStatusParameter=" . json_encode($changeStatusParameter) . "", $ApiToken, $ApiServer)); 
}

public static function Create_PurchaseOrder_Initial($createParameters,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Create_PurchaseOrder_Initial", "createParameters=" . json_encode($createParameters) . "", $ApiToken, $ApiServer)); 
}

public static function Delete_PurchaseOrder($pkPurchaseId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("PurchaseOrder/Delete_PurchaseOrder", "pkPurchaseId=" . $pkPurchaseId . "", $ApiToken, $ApiServer); 
}

public static function Delete_PurchaseOrderExtendedProperty($request,$ApiToken, $ApiServer)
{
 Factory::GetResponse("PurchaseOrder/Delete_PurchaseOrderExtendedProperty", "request=" . json_encode($request) . "", $ApiToken, $ApiServer); 
}

public static function Delete_PurchaseOrderItem($deleteItemParameter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Delete_PurchaseOrderItem", "deleteItemParameter=" . json_encode($deleteItemParameter) . "", $ApiToken, $ApiServer)); 
}

public static function Delete_PurchaseOrderNote($pkPurchaseId,$pkPurchaseOrderNoteId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Delete_PurchaseOrderNote", "pkPurchaseId=" . $pkPurchaseId . "&pkPurchaseOrderNoteId=" . $pkPurchaseOrderNoteId . "", $ApiToken, $ApiServer)); 
}

public static function Deliver_PurchaseItem($deliverItemParameter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Deliver_PurchaseItem", "deliverItemParameter=" . json_encode($deliverItemParameter) . "", $ApiToken, $ApiServer)); 
}

public static function Deliver_PurchaseItemAll($purchaseId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Deliver_PurchaseItemAll", "purchaseId=" . $purchaseId . "", $ApiToken, $ApiServer)); 
}

public static function Deliver_PurchaseItemAll_ExceptBatchItems($purchaseId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Deliver_PurchaseItemAll_ExceptBatchItems", "purchaseId=" . $purchaseId . "", $ApiToken, $ApiServer)); 
}

public static function Get_PurchaseOrder($pkPurchaseId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Get_PurchaseOrder", "pkPurchaseId=" . $pkPurchaseId . "", $ApiToken, $ApiServer)); 
}

public static function Get_PurchaseOrderAudit($auditLog,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Get_PurchaseOrderAudit", "auditLog=" . json_encode($auditLog) . "", $ApiToken, $ApiServer)); 
}

public static function Get_PurchaseOrderExtendedProperty($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Get_PurchaseOrderExtendedProperty", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function Get_PurchaseOrderNote($pkPurchaseId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Get_PurchaseOrderNote", "pkPurchaseId=" . $pkPurchaseId . "", $ApiToken, $ApiServer)); 
}

public static function GetPurchaseOrderStatusList($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/GetPurchaseOrderStatusList", "", $ApiToken, $ApiServer)); 
}

public static function GetPurchaseOrdersWithStockItems($purchaseOrder,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/GetPurchaseOrdersWithStockItems", "purchaseOrder=" . json_encode($purchaseOrder) . "", $ApiToken, $ApiServer)); 
}

public static function Search_PurchaseOrders($searchParameter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Search_PurchaseOrders", "searchParameter=" . json_encode($searchParameter) . "", $ApiToken, $ApiServer)); 
}

public static function Update_PurchaseOrderExtendedProperty($request,$ApiToken, $ApiServer)
{
 Factory::GetResponse("PurchaseOrder/Update_PurchaseOrderExtendedProperty", "request=" . json_encode($request) . "", $ApiToken, $ApiServer); 
}

public static function Update_PurchaseOrderHeader($updateParameter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Update_PurchaseOrderHeader", "updateParameter=" . json_encode($updateParameter) . "", $ApiToken, $ApiServer)); 
}

public static function Update_PurchaseOrderItem($updateItemParameter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("PurchaseOrder/Update_PurchaseOrderItem", "updateItemParameter=" . json_encode($updateItemParameter) . "", $ApiToken, $ApiServer)); 
} 
}
?>