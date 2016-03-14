<?php
class ImportExportMethods 
{ public static function GetImportTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImportTypes", "", $ApiToken, $ApiServer)); 
}

public static function SaveImport($importConfig,$feedType,$feedJSON,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/SaveImport", "importConfig=" . json_encode($importConfig) . "&feedType=" . $feedType . "&feedJSON=" . $feedJSON . "", $ApiToken, $ApiServer)); 
}

public static function IsImportEnabled($id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/IsImportEnabled", "id=" . $id . "", $ApiToken, $ApiServer)); 
}

public static function EnableImport($importId,$enable,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/EnableImport", "importId=" . $importId . "&enable=" . $enable . "", $ApiToken, $ApiServer)); 
}

public static function RunNowImport($importId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/RunNowImport", "importId=" . $importId . "", $ApiToken, $ApiServer); 
}

public static function GetImport($id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImport", "id=" . $id . "", $ApiToken, $ApiServer)); 
}

public static function GetImportIdByName($friendlyName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImportIdByName", "friendlyName=" . $friendlyName . "", $ApiToken, $ApiServer)); 
}

public static function DeleteImport($id,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/DeleteImport", "id=" . $id . "", $ApiToken, $ApiServer); 
}

public static function GetExecutingOrQueuedImports($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExecutingOrQueuedImports", "", $ApiToken, $ApiServer)); 
}

public static function GetImportSessionErrors($sessionId,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImportSessionErrors", "sessionId=" . $sessionId . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function GetImportSessions($importId,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImportSessions", "importId=" . $importId . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function GetImports($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImports", "", $ApiToken, $ApiServer)); 
}

public static function GetImportRegister($id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImportRegister", "id=" . $id . "", $ApiToken, $ApiServer)); 
}

public static function DownloadImportedFile($fileId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/DownloadImportedFile", "fileId=" . $fileId . "", $ApiToken, $ApiServer); 
}

public static function GetImportListOfValues($importType,$columnName,$additionalFieldName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImportListOfValues", "importType=" . json_encode($importType) . "&columnName=" . $columnName . "&additionalFieldName=" . $additionalFieldName . "", $ApiToken, $ApiServer)); 
}

public static function GetFullfilmentCenterSettings($fkStockLocationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetFullfilmentCenterSettings", "fkStockLocationId=" . $fkStockLocationId . "", $ApiToken, $ApiServer)); 
}

public static function SaveOrdersExportId($fkStockLocationId,$fkOrdersExportId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/SaveOrdersExportId", "fkStockLocationId=" . $fkStockLocationId . "&fkOrdersExportId=" . $fkOrdersExportId . "", $ApiToken, $ApiServer); 
}

public static function SaveOrdersImportId($fkStockLocationId,$fkOrdersImportId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/SaveOrdersImportId", "fkStockLocationId=" . $fkStockLocationId . "&fkOrdersImportId=" . $fkOrdersImportId . "", $ApiToken, $ApiServer); 
}

public static function SaveInventoryImportId($fkStockLocationId,$fkInventoryImportId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/SaveInventoryImportId", "fkStockLocationId=" . $fkStockLocationId . "&fkInventoryImportId=" . $fkInventoryImportId . "", $ApiToken, $ApiServer); 
}

public static function DeleteOrdersExportId($fkStockLocationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/DeleteOrdersExportId", "fkStockLocationId=" . $fkStockLocationId . "", $ApiToken, $ApiServer); 
}

public static function DeleteOrdersImportId($fkStockLocationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/DeleteOrdersImportId", "fkStockLocationId=" . $fkStockLocationId . "", $ApiToken, $ApiServer); 
}

public static function DeleteInventoryImportId($fkStockLocationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/DeleteInventoryImportId", "fkStockLocationId=" . $fkStockLocationId . "", $ApiToken, $ApiServer); 
}

public static function GetFulfilmentCenterNameByOrdersExportId($fkOrdersExportId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetFulfilmentCenterNameByOrdersExportId", "fkOrdersExportId=" . $fkOrdersExportId . "", $ApiToken, $ApiServer)); 
}

public static function GetFulfilmentCenterNameByOrdersImportId($fkOrdersImportId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetFulfilmentCenterNameByOrdersImportId", "fkOrdersImportId=" . $fkOrdersImportId . "", $ApiToken, $ApiServer)); 
}

public static function GetFulfilmentCenterNameByInventoryImportId($fkInventoryImportId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetFulfilmentCenterNameByInventoryImportId", "fkInventoryImportId=" . $fkInventoryImportId . "", $ApiToken, $ApiServer)); 
}

public static function GetExportIdByName($friendlyName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExportIdByName", "friendlyName=" . $friendlyName . "", $ApiToken, $ApiServer)); 
}

public static function GetExportTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExportTypes", "", $ApiToken, $ApiServer)); 
}

public static function GetExportSubQuerySelectionFieldValues($exportType,$subQueryName,$selectionFieldName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExportSubQuerySelectionFieldValues", "exportType=" . json_encode($exportType) . "&subQueryName=" . $subQueryName . "&selectionFieldName=" . $selectionFieldName . "", $ApiToken, $ApiServer)); 
}

public static function SaveExport($exportConfig,$feedType,$feedJSON,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/SaveExport", "exportConfig=" . json_encode($exportConfig) . "&feedType=" . $feedType . "&feedJSON=" . $feedJSON . "", $ApiToken, $ApiServer)); 
}

public static function IsExportEnabled($id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/IsExportEnabled", "id=" . $id . "", $ApiToken, $ApiServer)); 
}

public static function EnableExport($exportId,$enable,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/EnableExport", "exportId=" . $exportId . "&enable=" . $enable . "", $ApiToken, $ApiServer)); 
}

public static function RunNowExport($exportId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/RunNowExport", "exportId=" . $exportId . "", $ApiToken, $ApiServer); 
}

public static function GetExport($id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExport", "id=" . $id . "", $ApiToken, $ApiServer)); 
}

public static function DeleteExport($id,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/DeleteExport", "id=" . $id . "", $ApiToken, $ApiServer); 
}

public static function GetExecutingOrQueuedExports($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExecutingOrQueuedExports", "", $ApiToken, $ApiServer)); 
}

public static function GetExportSessionErrors($sessionId,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExportSessionErrors", "sessionId=" . $sessionId . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function GetExportSessions($exportId,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExportSessions", "exportId=" . $exportId . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function GetExports($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExports", "", $ApiToken, $ApiServer)); 
}

public static function GetExportRegister($id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExportRegister", "id=" . $id . "", $ApiToken, $ApiServer)); 
}

public static function GetSQLColumns($sqlQuery,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetSQLColumns", "sqlQuery=" . $sqlQuery . "", $ApiToken, $ApiServer)); 
}

public static function GetDropboxAccounts($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetDropboxAccounts", "", $ApiToken, $ApiServer)); 
}

public static function SetDropboxAccounts($accounts,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/SetDropboxAccounts", "accounts=" . json_encode($accounts) . "", $ApiToken, $ApiServer); 
}

public static function EvalExpression($expression,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/EvalExpression", "expression=" . $expression . "", $ApiToken, $ApiServer)); 
}

public static function CheckFileLocation($feedJSON,$feedType,$fileName,$downloadEventJSON,$isExport,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/CheckFileLocation", "feedJSON=" . $feedJSON . "&feedType=" . $feedType . "&fileName=" . $fileName . "&downloadEventJSON=" . $downloadEventJSON . "&isExport=" . $isExport . "", $ApiToken, $ApiServer)); 
}

public static function GetFolderContent($feedJSON,$feedType,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetFolderContent", "feedJSON=" . $feedJSON . "&feedType=" . $feedType . "", $ApiToken, $ApiServer)); 
}

public static function GetColumnsFromFile($feedJSON,$feedType,$csvSettingsJSON,$fileName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetColumnsFromFile", "feedJSON=" . $feedJSON . "&feedType=" . $feedType . "&csvSettingsJSON=" . $csvSettingsJSON . "&fileName=" . $fileName . "", $ApiToken, $ApiServer)); 
}

public static function GetColumnsFromUploadedFile($fileId,$csvSettingsJSON,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetColumnsFromUploadedFile", "fileId=" . $fileId . "&csvSettingsJSON=" . $csvSettingsJSON . "", $ApiToken, $ApiServer)); 
} 
}
?>