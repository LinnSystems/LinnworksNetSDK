<?php
class OrdersMethods 
{ public static function AddCoupon($orderId,$barcode,$couponData,$fulfilmentCenter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/AddCoupon", "orderId=" . $orderId . "&barcode=" . $barcode . "&couponData=" . json_encode($couponData) . "&fulfilmentCenter=" . $fulfilmentCenter . "", $ApiToken, $ApiServer)); 
}

public static function AddOrderItem($orderId,$itemId,$channelSKU,$fulfilmentCenter,$quantity,$linePricing,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/AddOrderItem", "orderId=" . $orderId . "&itemId=" . $itemId . "&channelSKU=" . $channelSKU . "&fulfilmentCenter=" . $fulfilmentCenter . "&quantity=" . $quantity . "&linePricing=" . json_encode($linePricing) . "", $ApiToken, $ApiServer)); 
}

public static function AddOrderService($orderId,$service,$cost,$taxRate,$fulfilmentCenter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/AddOrderService", "orderId=" . $orderId . "&service=" . $service . "&cost=" . $cost . "&taxRate=" . $taxRate . "&fulfilmentCenter=" . $fulfilmentCenter . "", $ApiToken, $ApiServer)); 
}

public static function AssignToFolder($orderIds,$folder,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/AssignToFolder", "orderIds=" . json_encode($orderIds) . "&folder=" . $folder . "", $ApiToken, $ApiServer)); 
}

public static function CancelOrder($orderId,$fulfilmentCenter,$refund,$note,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/CancelOrder", "orderId=" . $orderId . "&fulfilmentCenter=" . $fulfilmentCenter . "&refund=" . $refund . "&note=" . $note . "", $ApiToken, $ApiServer)); 
}

public static function ChangeOrderTag($orderIds,$tag,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ChangeOrderTag", "orderIds=" . json_encode($orderIds) . "&tag=" . json_encode($tag) . "", $ApiToken, $ApiServer)); 
}

public static function ChangeShippingMethod($orderIds,$shippingMethod,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ChangeShippingMethod", "orderIds=" . json_encode($orderIds) . "&shippingMethod=" . $shippingMethod . "", $ApiToken, $ApiServer)); 
}

public static function ChangeStatus($orderIds,$status,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ChangeStatus", "orderIds=" . json_encode($orderIds) . "&status=" . $status . "", $ApiToken, $ApiServer)); 
}

public static function ClearInvoicePrinted($orderIds,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ClearInvoicePrinted", "orderIds=" . json_encode($orderIds) . "", $ApiToken, $ApiServer)); 
}

public static function ClearPickListPrinted($orderIds,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ClearPickListPrinted", "orderIds=" . json_encode($orderIds) . "", $ApiToken, $ApiServer)); 
}

public static function ClearShippingLabelInfo($orderIds,$withoutConfirmation,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ClearShippingLabelInfo", "orderIds=" . json_encode($orderIds) . "&withoutConfirmation=" . $withoutConfirmation . "", $ApiToken, $ApiServer)); 
}

public static function CompleteOrder($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/CompleteOrder", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function CreateNewItemAndLink($pkStockItemId,$itemTitle,$source,$subSource,$channelSKU,$locationId,$initialQuantity,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/CreateNewItemAndLink", "pkStockItemId=" . $pkStockItemId . "&itemTitle=" . $itemTitle . "&source=" . $source . "&subSource=" . $subSource . "&channelSKU=" . $channelSKU . "&locationId=" . json_encode($locationId) . "&initialQuantity=" . json_encode($initialQuantity) . "", $ApiToken, $ApiServer)); 
}

public static function CreateNewOrder($fulfilmentCenter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/CreateNewOrder", "fulfilmentCenter=" . $fulfilmentCenter . "", $ApiToken, $ApiServer)); 
}

public static function CreateOrders($orders,$location,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/CreateOrders", "orders=" . json_encode($orders) . "&location=" . $location . "", $ApiToken, $ApiServer)); 
}

public static function CustomerLookUp($field,$txt,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/CustomerLookUp", "field=" . $field . "&txt=" . $txt . "", $ApiToken, $ApiServer)); 
}

public static function DeleteOrder($orderId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/DeleteOrder", "orderId=" . $orderId . "", $ApiToken, $ApiServer); 
}

public static function GetAllAvailableOrderItemBatchsByOrderId($parameters,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetAllAvailableOrderItemBatchsByOrderId", "parameters=" . json_encode($parameters) . "", $ApiToken, $ApiServer)); 
}

public static function GetAllOpenOrders($filters,$sorting,$fulfilmentCenter,$additionalFilter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetAllOpenOrders", "filters=" . json_encode($filters) . "&sorting=" . json_encode($sorting) . "&fulfilmentCenter=" . $fulfilmentCenter . "&additionalFilter=" . $additionalFilter . "", $ApiToken, $ApiServer)); 
}

public static function GetAllOpenOrdersBetweenIndex($fromIndex,$toIndex,$filters,$sorting,$fulfilmentCenter,$additionalFilter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetAllOpenOrdersBetweenIndex", "fromIndex=" . $fromIndex . "&toIndex=" . $toIndex . "&filters=" . json_encode($filters) . "&sorting=" . json_encode($sorting) . "&fulfilmentCenter=" . $fulfilmentCenter . "&additionalFilter=" . $additionalFilter . "", $ApiToken, $ApiServer)); 
}

public static function GetAssignedOrderItemBatches($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetAssignedOrderItemBatches", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetAvailableFolders($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetAvailableFolders", "", $ApiToken, $ApiServer)); 
}

public static function GetBatchPilots($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetBatchPilots", "", $ApiToken, $ApiServer)); 
}

public static function GetCountries($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetCountries", "", $ApiToken, $ApiServer)); 
}

public static function GetDefaultPaymentMethodIdForNewOrder($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetDefaultPaymentMethodIdForNewOrder", "", $ApiToken, $ApiServer)); 
}

public static function GetDraftOrders($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetDraftOrders", "", $ApiToken, $ApiServer)); 
}

public static function GetExtendedProperties($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetExtendedProperties", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function GetExtendedPropertyNames($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetExtendedPropertyNames", "", $ApiToken, $ApiServer)); 
}

public static function GetExtendedPropertyTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetExtendedPropertyTypes", "", $ApiToken, $ApiServer)); 
}

public static function GetLinkedItems($itemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetLinkedItems", "itemId=" . $itemId . "", $ApiToken, $ApiServer)); 
}

public static function GetOpenOrderIdByOrderOrReferenceId($orderOrReferenceId,$filters,$locationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceId", "orderOrReferenceId=" . $orderOrReferenceId . "&filters=" . json_encode($filters) . "&locationId=" . json_encode($locationId) . "", $ApiToken, $ApiServer)); 
}

public static function GetOpenOrderIdByOrderOrReferenceIdAndProcess($orderOrReferenceId,$fulfilmentCenter,$filters,$batchScanned,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOpenOrderIdByOrderOrReferenceIdAndProcess", "orderOrReferenceId=" . $orderOrReferenceId . "&fulfilmentCenter=" . $fulfilmentCenter . "&filters=" . json_encode($filters) . "&batchScanned=" . $batchScanned . "", $ApiToken, $ApiServer)); 
}

public static function GetOpenOrderItemsSuppliers($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOpenOrderItemsSuppliers", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function GetOpenOrders($entriesPerPage,$pageNumber,$filters,$sorting,$fulfilmentCenter,$additionalFilter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOpenOrders", "entriesPerPage=" . $entriesPerPage . "&pageNumber=" . $pageNumber . "&filters=" . json_encode($filters) . "&sorting=" . json_encode($sorting) . "&fulfilmentCenter=" . json_encode($fulfilmentCenter) . "&additionalFilter=" . $additionalFilter . "", $ApiToken, $ApiServer)); 
}

public static function GetOpenOrdersByItemBarcode($productBarcode,$filters,$locationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOpenOrdersByItemBarcode", "productBarcode=" . $productBarcode . "&filters=" . json_encode($filters) . "&locationId=" . json_encode($locationId) . "", $ApiToken, $ApiServer)); 
}

public static function GetOrder($orderId,$fulfilmentLocationId,$loadItems,$loadAdditionalInfo,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrder", "orderId=" . $orderId . "&fulfilmentLocationId=" . json_encode($fulfilmentLocationId) . "&loadItems=" . $loadItems . "&loadAdditionalInfo=" . $loadAdditionalInfo . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderAuditTrail($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderAuditTrail", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderById($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderById", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderDetailsByNumOrderId($OrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderDetailsByNumOrderId", "OrderId=" . $OrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderDetailsByReferenceId($ReferenceId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderDetailsByReferenceId", "ReferenceId=" . $ReferenceId . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderItemBatchsByOrderId($parameters,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderItemBatchsByOrderId", "parameters=" . json_encode($parameters) . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderItemComposition($orderId,$stockItemId,$fulfilmentCenter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderItemComposition", "orderId=" . $orderId . "&stockItemId=" . $stockItemId . "&fulfilmentCenter=" . $fulfilmentCenter . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderItems($orderId,$fulfilmentCenter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderItems", "orderId=" . $orderId . "&fulfilmentCenter=" . $fulfilmentCenter . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderNotes($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderNotes", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderNoteTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderNoteTypes", "", $ApiToken, $ApiServer)); 
}

public static function GetOrderPackagingCalculation($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderPackagingCalculation", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderPackagingSplit($orderId,$openOrdersOnly,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderPackagingSplit", "orderId=" . $orderId . "&openOrdersOnly=" . $openOrdersOnly . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderRelations($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderRelations", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function GetOrders($ordersIds,$fulfilmentLocationId,$loadItems,$loadAdditionalInfo,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrders", "ordersIds=" . json_encode($ordersIds) . "&fulfilmentLocationId=" . json_encode($fulfilmentLocationId) . "&loadItems=" . $loadItems . "&loadAdditionalInfo=" . $loadAdditionalInfo . "", $ApiToken, $ApiServer)); 
}

public static function GetOrdersById($pkOrderIds,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrdersById", "pkOrderIds=" . json_encode($pkOrderIds) . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderView($pkViewId,$markAsLatestViewed,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderView", "pkViewId=" . $pkViewId . "&markAsLatestViewed=" . $markAsLatestViewed . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderViews($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderViews", "", $ApiToken, $ApiServer)); 
}

public static function GetOrderXml($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderXml", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderXmlJSTree($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetOrderXmlJSTree", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function GetPackagingGroups($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetPackagingGroups", "", $ApiToken, $ApiServer)); 
}

public static function GetPaymentMethods($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetPaymentMethods", "", $ApiToken, $ApiServer)); 
}

public static function GetShippingMethods($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetShippingMethods", "", $ApiToken, $ApiServer)); 
}

public static function GetUserLocationId($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/GetUserLocationId", "", $ApiToken, $ApiServer)); 
}

public static function LockOrder($orderIds,$lockOrder,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/LockOrder", "orderIds=" . json_encode($orderIds) . "&lockOrder=" . $lockOrder . "", $ApiToken, $ApiServer); 
}

public static function MergeOrders($ordersToMerge,$fulfilmentCenter,$pkPostalServiceId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/MergeOrders", "ordersToMerge=" . json_encode($ordersToMerge) . "&fulfilmentCenter=" . $fulfilmentCenter . "&pkPostalServiceId=" . $pkPostalServiceId . "", $ApiToken, $ApiServer)); 
}

public static function MoveToFulfilmentCenter($orderIds,$fulfilmentCenterId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/MoveToFulfilmentCenter", "orderIds=" . json_encode($orderIds) . "&fulfilmentCenterId=" . $fulfilmentCenterId . "", $ApiToken, $ApiServer)); 
}

public static function MoveToLocation($orderIds,$pkStockLocationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/MoveToLocation", "orderIds=" . json_encode($orderIds) . "&pkStockLocationId=" . $pkStockLocationId . "", $ApiToken, $ApiServer)); 
}

public static function ProcessFulfilmentCentreOrder($orderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ProcessFulfilmentCentreOrder", "orderId=" . $orderId . "", $ApiToken, $ApiServer)); 
}

public static function ProcessOrder($orderId,$scanPerformed,$locationId,$allowZeroAndNegativeBatchQty,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ProcessOrder", "orderId=" . $orderId . "&scanPerformed=" . $scanPerformed . "&locationId=" . json_encode($locationId) . "&allowZeroAndNegativeBatchQty=" . $allowZeroAndNegativeBatchQty . "", $ApiToken, $ApiServer)); 
}

public static function ProcessOrder_RequiredBatchScans($BatchAssignment,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/ProcessOrder_RequiredBatchScans", "BatchAssignment=" . json_encode($BatchAssignment) . "", $ApiToken, $ApiServer); 
}

public static function ProcessOrderByOrderOrReferenceId($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ProcessOrderByOrderOrReferenceId", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function ProcessOrdersInBatch($ordersIds,$locationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ProcessOrdersInBatch", "ordersIds=" . json_encode($ordersIds) . "&locationId=" . json_encode($locationId) . "", $ApiToken, $ApiServer)); 
}

public static function RecalculateSingleOrderPackaging($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/RecalculateSingleOrderPackaging", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function RemoveOrderItem($orderId,$rowid,$fulfilmentCenter,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/RemoveOrderItem", "orderId=" . $orderId . "&rowid=" . $rowid . "&fulfilmentCenter=" . $fulfilmentCenter . "", $ApiToken, $ApiServer)); 
}

public static function RunRulesEngine($orderIds,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/RunRulesEngine", "orderIds=" . json_encode($orderIds) . "", $ApiToken, $ApiServer)); 
}

public static function SaveOrderView($pkViewId,$viewName,$OrderViewDetailJSON,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/SaveOrderView", "pkViewId=" . $pkViewId . "&viewName=" . $viewName . "&OrderViewDetailJSON=" . $OrderViewDetailJSON . "", $ApiToken, $ApiServer); 
}

public static function SetAdditionalInfo($orderId,$rowId,$additionalInfo,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/SetAdditionalInfo", "orderId=" . $orderId . "&rowId=" . $rowId . "&additionalInfo=" . json_encode($additionalInfo) . "", $ApiToken, $ApiServer); 
}

public static function SetAvailableFolders($folders,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetAvailableFolders", "folders=" . json_encode($folders) . "", $ApiToken, $ApiServer)); 
}

public static function SetDefaultPaymentMethodIdForNewOrder($paymentMethod,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/SetDefaultPaymentMethodIdForNewOrder", "paymentMethod=" . $paymentMethod . "", $ApiToken, $ApiServer); 
}

public static function SetExtendedProperties($orderId,$extendedProperties,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetExtendedProperties", "orderId=" . $orderId . "&extendedProperties=" . json_encode($extendedProperties) . "", $ApiToken, $ApiServer)); 
}

public static function SetInvoicesPrinted($orderIds,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetInvoicesPrinted", "orderIds=" . json_encode($orderIds) . "", $ApiToken, $ApiServer)); 
}

public static function SetLabelsPrinted($orderIds,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetLabelsPrinted", "orderIds=" . json_encode($orderIds) . "", $ApiToken, $ApiServer)); 
}

public static function SetOrderCustomerInfo($orderId,$info,$saveToCrm,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetOrderCustomerInfo", "orderId=" . $orderId . "&info=" . json_encode($info) . "&saveToCrm=" . json_encode($saveToCrm) . "", $ApiToken, $ApiServer)); 
}

public static function SetOrderGeneralInfo($orderId,$info,$wasDraft,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/SetOrderGeneralInfo", "orderId=" . $orderId . "&info=" . json_encode($info) . "&wasDraft=" . $wasDraft . "", $ApiToken, $ApiServer); 
}

public static function SetOrderNotes($orderId,$orderNotes,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/SetOrderNotes", "orderId=" . $orderId . "&orderNotes=" . json_encode($orderNotes) . "", $ApiToken, $ApiServer); 
}

public static function SetOrderPackaging($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetOrderPackaging", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function SetOrderPackagingSplit($orderId,$packagingSplit,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetOrderPackagingSplit", "orderId=" . $orderId . "&packagingSplit=" . json_encode($packagingSplit) . "", $ApiToken, $ApiServer)); 
}

public static function SetOrderShippingInfo($orderId,$info,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetOrderShippingInfo", "orderId=" . $orderId . "&info=" . json_encode($info) . "", $ApiToken, $ApiServer)); 
}

public static function SetOrderSplitPackagingManualOverwrite($request,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetOrderSplitPackagingManualOverwrite", "request=" . json_encode($request) . "", $ApiToken, $ApiServer)); 
}

public static function SetOrderTotalsInfo($orderId,$info,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/SetOrderTotalsInfo", "orderId=" . $orderId . "&info=" . json_encode($info) . "", $ApiToken, $ApiServer); 
}

public static function SetPaymentMethods($paymentMethods,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SetPaymentMethods", "paymentMethods=" . json_encode($paymentMethods) . "", $ApiToken, $ApiServer)); 
}

public static function SetPickListPrinted($Request,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/SetPickListPrinted", "Request=" . json_encode($Request) . "", $ApiToken, $ApiServer); 
}

public static function SplitOrder($orderId,$newOrders,$type,$fulfilmentLocationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/SplitOrder", "orderId=" . $orderId . "&newOrders=" . json_encode($newOrders) . "&type=" . $type . "&fulfilmentLocationId=" . $fulfilmentLocationId . "", $ApiToken, $ApiServer)); 
}

public static function UnassignToFolder($orderIds,$folder,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/UnassignToFolder", "orderIds=" . json_encode($orderIds) . "&folder=" . $folder . "", $ApiToken, $ApiServer)); 
}

public static function UpdateBillingAddress($orderId,$billingAddress,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/UpdateBillingAddress", "orderId=" . $orderId . "&billingAddress=" . json_encode($billingAddress) . "", $ApiToken, $ApiServer); 
}

public static function UpdateLinkItem($pkStockId,$pkStockItemId,$source,$subSource,$channelSKU,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Orders/UpdateLinkItem", "pkStockId=" . $pkStockId . "&pkStockItemId=" . $pkStockItemId . "&source=" . $source . "&subSource=" . $subSource . "&channelSKU=" . $channelSKU . "", $ApiToken, $ApiServer); 
}

public static function UpdateOrderItem($orderId,$orderItem,$fulfilmentCenter,$source,$subSource,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/UpdateOrderItem", "orderId=" . $orderId . "&orderItem=" . json_encode($orderItem) . "&fulfilmentCenter=" . $fulfilmentCenter . "&source=" . $source . "&subSource=" . $subSource . "", $ApiToken, $ApiServer)); 
}

public static function ValidateCoupon($orderId,$barcode,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Orders/ValidateCoupon", "orderId=" . $orderId . "&barcode=" . $barcode . "", $ApiToken, $ApiServer)); 
} 
}
?>