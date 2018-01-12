<?php
class ReturnsRefundsMethods 
{ public static function ActionBookedOrder($pkOrderId,$bookedItems,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ReturnsRefunds/ActionBookedOrder", "pkOrderId=" . $pkOrderId . "&bookedItems=" . json_encode($bookedItems) . "", $ApiToken, $ApiServer); 
}

public static function CreateReturnsRefundsCSV($from,$to,$dateType,$searchField,$exactMatch,$searchTerm,$sortColumn,$sortDirection,$historyType,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/CreateReturnsRefundsCSV", "from=" . json_encode($from) . "&to=" . json_encode($to) . "&dateType=" . $dateType . "&searchField=" . $searchField . "&exactMatch=" . $exactMatch . "&searchTerm=" . $searchTerm . "&sortColumn=" . $sortColumn . "&sortDirection=" . $sortDirection . "&historyType=" . $historyType . "", $ApiToken, $ApiServer)); 
}

public static function DeleteBookedItem($pkOrderId,$pkReturnId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ReturnsRefunds/DeleteBookedItem", "pkOrderId=" . $pkOrderId . "&pkReturnId=" . $pkReturnId . "", $ApiToken, $ApiServer); 
}

public static function DeleteBookedOrder($pkOrderId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ReturnsRefunds/DeleteBookedOrder", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer); 
}

public static function DeletePendingRefundItem($fkOrderId,$pkRefundRowId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ReturnsRefunds/DeletePendingRefundItem", "fkOrderId=" . $fkOrderId . "&pkRefundRowId=" . $pkRefundRowId . "", $ApiToken, $ApiServer); 
}

public static function EditBookedItemInfo($pkOrderId,$bookedReturnsExchangeItem,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ReturnsRefunds/EditBookedItemInfo", "pkOrderId=" . $pkOrderId . "&bookedReturnsExchangeItem=" . json_encode($bookedReturnsExchangeItem) . "", $ApiToken, $ApiServer); 
}

public static function GetBookedReturnsExchangeItems($pkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/GetBookedReturnsExchangeItems", "pkOrderId=" . $pkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetBookedReturnsExchangeOrders($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/GetBookedReturnsExchangeOrders", "", $ApiToken, $ApiServer)); 
}

public static function GetRefundOrders($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/GetRefundOrders", "", $ApiToken, $ApiServer)); 
}

public static function GetRefunds($pkOrderId,$refundReference,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/GetRefunds", "pkOrderId=" . $pkOrderId . "&refundReference=" . json_encode($refundReference) . "", $ApiToken, $ApiServer)); 
}

public static function GetSearchTypes($historyType,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/GetSearchTypes", "historyType=" . $historyType . "", $ApiToken, $ApiServer)); 
}

public static function GetTotalRefunds($fkOrderId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/GetTotalRefunds", "fkOrderId=" . $fkOrderId . "", $ApiToken, $ApiServer)); 
}

public static function GetWarehouseLocations($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/GetWarehouseLocations", "", $ApiToken, $ApiServer)); 
}

public static function RefundOrder($pkOrderId,$refundReference,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ReturnsRefunds/RefundOrder", "pkOrderId=" . $pkOrderId . "&refundReference=" . json_encode($refundReference) . "", $ApiToken, $ApiServer); 
}

public static function SearchReturnsRefundsPaged($from,$to,$dateType,$searchField,$exactMatch,$searchTerm,$pageNum,$numEntriesPerPage,$historyType,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ReturnsRefunds/SearchReturnsRefundsPaged", "from=" . json_encode($from) . "&to=" . json_encode($to) . "&dateType=" . $dateType . "&searchField=" . $searchField . "&exactMatch=" . $exactMatch . "&searchTerm=" . $searchTerm . "&pageNum=" . $pageNum . "&numEntriesPerPage=" . $numEntriesPerPage . "&historyType=" . $historyType . "", $ApiToken, $ApiServer)); 
} 
}
?>