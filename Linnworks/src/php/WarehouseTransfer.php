<?php
class WarehouseTransferMethods 
{ public static function AddItemToTransfer($fkTransferId,$pkStockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/AddItemToTransfer", "fkTransferId=" . $fkTransferId . "&pkStockItemId=" . $pkStockItemId . "", $ApiToken, $ApiServer)); 
}

public static function AddTransferBinNote($fkTransferBinId,$note,$fkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/AddTransferBinNote", "fkTransferBinId=" . $fkTransferBinId . "&note=" . $note . "&fkTransferId=" . $fkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function AddTransferItemNote($fkTransferId,$fkTransferItemId,$note,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/AddTransferItemNote", "fkTransferId=" . $fkTransferId . "&fkTransferItemId=" . $fkTransferItemId . "&note=" . $note . "", $ApiToken, $ApiServer)); 
}

public static function AddTransferNote($pkTransferId,$note,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/AddTransferNote", "pkTransferId=" . $pkTransferId . "&note=" . $note . "", $ApiToken, $ApiServer)); 
}

public static function AddTransferProperty($fkTransferId,$propertyName,$propertyValue,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/AddTransferProperty", "fkTransferId=" . $fkTransferId . "&propertyName=" . $propertyName . "&propertyValue=" . $propertyValue . "", $ApiToken, $ApiServer)); 
}

public static function AllocateItemToBin($pkSrcBinId,$pkDstBinId,$pkTransferItemId,$quantity,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/AllocateItemToBin", "pkSrcBinId=" . $pkSrcBinId . "&pkDstBinId=" . $pkDstBinId . "&pkTransferItemId=" . $pkTransferItemId . "&quantity=" . $quantity . "", $ApiToken, $ApiServer)); 
}

public static function ChangeBinDetails($pkTransferId,$pkBinId,$BinName,$BinReference,$BinBarcode,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/ChangeBinDetails", "pkTransferId=" . $pkTransferId . "&pkBinId=" . $pkBinId . "&BinName=" . $BinName . "&BinReference=" . $BinReference . "&BinBarcode=" . $BinBarcode . "", $ApiToken, $ApiServer); 
}

public static function ChangeTransferFromLocation($pkTransferId,$newLocationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/ChangeTransferFromLocation", "pkTransferId=" . $pkTransferId . "&newLocationId=" . $newLocationId . "", $ApiToken, $ApiServer); 
}

public static function ChangeTransferItemReceivedQuantity($pkTransferId,$pkBinId,$pkTransferItemId,$Quantity,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/ChangeTransferItemReceivedQuantity", "pkTransferId=" . $pkTransferId . "&pkBinId=" . $pkBinId . "&pkTransferItemId=" . $pkTransferItemId . "&Quantity=" . json_encode($Quantity) . "", $ApiToken, $ApiServer); 
}

public static function ChangeTransferItemRequestQuantity($pkTransferId,$pkTransferItemId,$Quantity,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/ChangeTransferItemRequestQuantity", "pkTransferId=" . $pkTransferId . "&pkTransferItemId=" . $pkTransferItemId . "&Quantity=" . $Quantity . "", $ApiToken, $ApiServer); 
}

public static function ChangeTransferItemSentQuantity($pkTransferId,$pkBinId,$pkTransferItemId,$Quantity,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/ChangeTransferItemSentQuantity", "pkTransferId=" . $pkTransferId . "&pkBinId=" . $pkBinId . "&pkTransferItemId=" . $pkTransferItemId . "&Quantity=" . $Quantity . "", $ApiToken, $ApiServer)); 
}

public static function ChangeTransferLocations($pkTransferId,$fromLocationId,$toLocationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/ChangeTransferLocations", "pkTransferId=" . $pkTransferId . "&fromLocationId=" . $fromLocationId . "&toLocationId=" . $toLocationId . "", $ApiToken, $ApiServer); 
}

public static function ChangeTransferProperty($pkTransferId,$pkTransferPropertyId,$newValue,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/ChangeTransferProperty", "pkTransferId=" . $pkTransferId . "&pkTransferPropertyId=" . $pkTransferPropertyId . "&newValue=" . $newValue . "", $ApiToken, $ApiServer); 
}

public static function ChangeTransferStatus($pkTransferId,$newStatus,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/ChangeTransferStatus", "pkTransferId=" . $pkTransferId . "&newStatus=" . $newStatus . "", $ApiToken, $ApiServer); 
}

public static function ChangeTransferToLocation($pkTransferId,$newLocationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/ChangeTransferToLocation", "pkTransferId=" . $pkTransferId . "&newLocationId=" . $newLocationId . "", $ApiToken, $ApiServer); 
}

public static function CheckForDraftTransfer($toLocationId,$fromLocationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/CheckForDraftTransfer", "toLocationId=" . $toLocationId . "&fromLocationId=" . $fromLocationId . "", $ApiToken, $ApiServer)); 
}

public static function CreateNewBin($pkTransferId,$barcode,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/CreateNewBin", "pkTransferId=" . $pkTransferId . "&barcode=" . $barcode . "", $ApiToken, $ApiServer)); 
}

public static function CreateTransferFromDescrepancies($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/CreateTransferFromDescrepancies", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function CreateTransferRequestWithReturn($fromLocationId,$toLocationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/CreateTransferRequestWithReturn", "fromLocationId=" . $fromLocationId . "&toLocationId=" . $toLocationId . "", $ApiToken, $ApiServer)); 
}

public static function DeleteEmptyDraftTransfer($pkTransferId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/DeleteEmptyDraftTransfer", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer); 
}

public static function DeleteTransfer($pkTransferId,$DeleteReason,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/DeleteTransfer", "pkTransferId=" . $pkTransferId . "&DeleteReason=" . $DeleteReason . "", $ApiToken, $ApiServer); 
}

public static function DeleteTransferProperty($pkTransferId,$pkTransferPropertyId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/DeleteTransferProperty", "pkTransferId=" . $pkTransferId . "&pkTransferPropertyId=" . $pkTransferPropertyId . "", $ApiToken, $ApiServer); 
}

public static function GetActiveTransfersAllLocations($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetActiveTransfersAllLocations", "", $ApiToken, $ApiServer)); 
}

public static function GetActiveTransfersForLocation($locationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetActiveTransfersForLocation", "locationId=" . $locationId . "", $ApiToken, $ApiServer)); 
}

public static function GetArchivedTransfers($pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetArchivedTransfers", "pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function GetArchivedTransfersBetweenDates($start,$end,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetArchivedTransfersBetweenDates", "start=" . json_encode($start) . "&end=" . json_encode($end) . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function GetArchivedTransfersFiltered($searchType,$filter,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetArchivedTransfersFiltered", "searchType=" . $searchType . "&filter=" . $filter . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function GetDiscrepancyItems($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetDiscrepancyItems", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function GetListTransfers($ids,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetListTransfers", "ids=" . json_encode($ids) . "", $ApiToken, $ApiServer)); 
}

public static function GetModifiedBasic($updateDate,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetModifiedBasic", "updateDate=" . json_encode($updateDate) . "", $ApiToken, $ApiServer)); 
}

public static function GetServerTime($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetServerTime", "", $ApiToken, $ApiServer)); 
}

public static function GetStockAvailability($pkTransferItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetStockAvailability", "pkTransferItemId=" . $pkTransferItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetTransferAudit($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetTransferAudit", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function GetTransferBinNotes($pkBinId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetTransferBinNotes", "pkBinId=" . $pkBinId . "", $ApiToken, $ApiServer)); 
}

public static function GetTransferItemNotes($pkTransferId,$pkTransferItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetTransferItemNotes", "pkTransferId=" . $pkTransferId . "&pkTransferItemId=" . $pkTransferItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetTransferItems($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetTransferItems", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function GetTransferNotes($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetTransferNotes", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function GetTransferProperties($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetTransferProperties", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function GetTransferWithItems($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetTransferWithItems", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function GetTransferWithNotes($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/GetTransferWithNotes", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function IsDraftTransferChanged($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/IsDraftTransferChanged", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function PrintTransfer($pkTransferId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/PrintTransfer", "pkTransferId=" . $pkTransferId . "", $ApiToken, $ApiServer)); 
}

public static function RemoveAllEmptyBins($ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/RemoveAllEmptyBins", "", $ApiToken, $ApiServer); 
}

public static function RemoveItemFromTransfer($pkTransferId,$pkTransferItemId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/RemoveItemFromTransfer", "pkTransferId=" . $pkTransferId . "&pkTransferItemId=" . $pkTransferItemId . "", $ApiToken, $ApiServer); 
}

public static function SearchTransfersAllLocations($searchType,$searchText,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/SearchTransfersAllLocations", "searchType=" . $searchType . "&searchText=" . $searchText . "", $ApiToken, $ApiServer)); 
}

public static function SearchTransfersByLocation($searchType,$searchText,$locationID,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("WarehouseTransfer/SearchTransfersByLocation", "searchType=" . $searchType . "&searchText=" . $searchText . "&locationID=" . $locationID . "", $ApiToken, $ApiServer)); 
}

public static function SetReferenceNumber($pkTransferId,$ReferenceNumber,$ApiToken, $ApiServer)
{
 Factory::GetResponse("WarehouseTransfer/SetReferenceNumber", "pkTransferId=" . $pkTransferId . "&ReferenceNumber=" . $ReferenceNumber . "", $ApiToken, $ApiServer); 
} 
}
?>