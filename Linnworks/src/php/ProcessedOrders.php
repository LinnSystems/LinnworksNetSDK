<?php
class ProcessedOrdersMethods 
{ public static function AddOrderNote($pkOrderID,$noteText,$isInternal,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/AddOrderNote", "pkOrderID=" . $pkOrderID . "&noteText=" . $noteText . "&isInternal=" . $isInternal . "", $ApiToken, $ApiServer)); 
}

public static function AddReturnCategory($categoryName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/AddReturnCategory", "categoryName=" . $categoryName . "", $ApiToken, $ApiServer)); 
}

public static function ChangeOrderNote($pkOrderNoteId,$noteText,$isInternal,$noteTypeId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ProcessedOrders/ChangeOrderNote", "pkOrderNoteId=" . $pkOrderNoteId . "&noteText=" . $noteText . "&isInternal=" . $isInternal . "&noteTypeId=" . json_encode($noteTypeId) . "", $ApiToken, $ApiServer); 
}

public static function CheckOrderFullyReturned($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/CheckOrderFullyReturned", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function CreateExchange($pkOrderId,$exchangeItems,$despatchLocation,$returnLocation,$channelReason,$channelSubReason,$category,$reason,$isBooking,$ignoredValidation,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/CreateExchange", "pkOrderId=" . $pkOrderId . "&exchangeItems=" . json_encode($exchangeItems) . "&despatchLocation=" . $despatchLocation . "&returnLocation=" . $returnLocation . "&channelReason=" . $channelReason . "&channelSubReason=" . $channelSubReason . "&category=" . $category . "&reason=" . $reason . "&isBooking=" . $isBooking . "&ignoredValidation=" . $ignoredValidation . "", $ApiToken, $ApiServer)); 
}

public static function CreateFullResend($pkOrderId,$despatchLocation,$category,$reason,$additionalCost,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/CreateFullResend", "pkOrderId=" . $pkOrderId . "&despatchLocation=" . $despatchLocation . "&category=" . $category . "&reason=" . $reason . "&additionalCost=" . $additionalCost . "", $ApiToken, $ApiServer)); 
}

public static function CreateProcessedOrdersCSV($from,$to,$dateType,$searchField,$exactMatch,$searchTerm,$sortColumn,$sortDirection,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/CreateProcessedOrdersCSV", "from=" . json_encode($from) . "&to=" . json_encode($to) . "&dateType=" . $dateType . "&searchField=" . $searchField . "&exactMatch=" . $exactMatch . "&searchTerm=" . $searchTerm . "&sortColumn=" . $sortColumn . "&sortDirection=" . $sortDirection . "", $ApiToken, $ApiServer)); 
}

public static function CreateResend($pkOrderId,$resendItems,$despatchLocation,$category,$reason,$additionalCost,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/CreateResend", "pkOrderId=" . $pkOrderId . "&resendItems=" . json_encode($resendItems) . "&despatchLocation=" . $despatchLocation . "&category=" . $category . "&reason=" . $reason . "&additionalCost=" . $additionalCost . "", $ApiToken, $ApiServer)); 
}

public static function CreateReturn($pkOrderId,$returnitems,$returnLocation,$channelReason,$channelSubReason,$category,$reason,$isReturnBooking,$ignoredValidation,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/CreateReturn", "pkOrderId=" . $pkOrderId . "&returnitems=" . json_encode($returnitems) . "&returnLocation=" . $returnLocation . "&channelReason=" . $channelReason . "&channelSubReason=" . $channelSubReason . "&category=" . $category . "&reason=" . $reason . "&isReturnBooking=" . $isReturnBooking . "&ignoredValidation=" . $ignoredValidation . "", $ApiToken, $ApiServer)); 
}

public static function DeleteOrderNote($pkOrderNoteId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ProcessedOrders/DeleteOrderNote", "pkOrderNoteId=" . $pkOrderNoteId . "", $ApiToken, $ApiServer); 
}

public static function DeleteReturnCategory($pkItemId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ProcessedOrders/DeleteReturnCategory", "pkItemId=" . $pkItemId . "", $ApiToken, $ApiServer); 
}

public static function GetChannelRefundReasons($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetChannelRefundReasons", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetOrderInfo($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetOrderInfo", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetPackageSplit($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetPackageSplit", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetProcessedAuditTrail($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetProcessedAuditTrail", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetProcessedOrderExtendedProperties($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetProcessedOrderExtendedProperties", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetProcessedOrderNotes($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetProcessedOrderNotes", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetProcessedRelatives($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetProcessedRelatives", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetRefundableServiceItems($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetRefundableServiceItems", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetRefunds($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetRefunds", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetRefundsOptions($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetRefundsOptions", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetReturnCategories($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetReturnCategories", "", $ApiToken, $ApiServer)); 
}

public static function GetReturnItemsInfo($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetReturnItemsInfo", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetReturnOrderInfo($pkOrderId,$includeRefundLink,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetReturnOrderInfo", "pkOrderId=" . $pkOrderId . "&includeRefundLink=" . $includeRefundLink . "", $ApiToken, $ApiServer)); 
}

public static function GetReturnsExchanges($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetReturnsExchanges", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetTotalRefunds($pkOrderId,$includeBookings,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/GetTotalRefunds", "pkOrderId=" . $pkOrderId . "&includeBookings=" . json_encode($includeBookings) . "", $ApiToken, $ApiServer)); 
}

public static function IsRefundValid($pkOrderId,$refundItems,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/IsRefundValid", "pkOrderId=" . $pkOrderId . "&refundItems=" . json_encode($refundItems) . "", $ApiToken, $ApiServer)); 
}

public static function IsRefundValidationRequiredByOrderId($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/IsRefundValidationRequiredByOrderId", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function MarkManualRefundsAsActioned($pkOrderId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ProcessedOrders/MarkManualRefundsAsActioned", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer); 
}

public static function RefundCompleteOrder($pkOrderId,$isManualRefund,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/RefundCompleteOrder", "pkOrderId=" . $pkOrderId . "&isManualRefund=" . $isManualRefund . "", $ApiToken, $ApiServer)); 
}

public static function RefundFreeText($pkOrderId,$refundItems,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/RefundFreeText", "pkOrderId=" . $pkOrderId . "&refundItems=" . json_encode($refundItems) . "", $ApiToken, $ApiServer)); 
}

public static function RefundServices($pkOrderId,$refundItems,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/RefundServices", "pkOrderId=" . $pkOrderId . "&refundItems=" . json_encode($refundItems) . "", $ApiToken, $ApiServer)); 
}

public static function RefundShipping($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/RefundShipping", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function RenameReturnCategory($pkItemId,$newName,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ProcessedOrders/RenameReturnCategory", "pkItemId=" . $pkItemId . "&newName=" . $newName . "", $ApiToken, $ApiServer); 
}

public static function SearchProcessedOrdersPaged($from,$to,$dateType,$searchField,$exactMatch,$searchTerm,$pageNum,$numEntriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/SearchProcessedOrdersPaged", "from=" . json_encode($from) . "&to=" . json_encode($to) . "&dateType=" . $dateType . "&searchField=" . $searchField . "&exactMatch=" . $exactMatch . "&searchTerm=" . $searchTerm . "&pageNum=" . $pageNum . "&numEntriesPerPage=" . $numEntriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function ValidateCompleteOrderRefund($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ProcessedOrders/ValidateCompleteOrderRefund", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
} 
}
?>