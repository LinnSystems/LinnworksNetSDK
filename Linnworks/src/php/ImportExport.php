<?php
class ImportExportMethods 
{ public static function DeleteExport($id,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/DeleteExport", "id=" . $id . "", $ApiToken, $ApiServer); 
}

public static function DeleteImport($id,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/DeleteImport", "id=" . $id . "", $ApiToken, $ApiServer); 
}

public static function DownloadImportedFile($fileId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/DownloadImportedFile", "fileId=" . $fileId . "", $ApiToken, $ApiServer)); 
}

public static function EnableExport($exportId,$enable,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/EnableExport", "exportId=" . $exportId . "&enable=" . $enable . "", $ApiToken, $ApiServer)); 
}

public static function EnableImport($importId,$enable,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/EnableImport", "importId=" . $importId . "&enable=" . $enable . "", $ApiToken, $ApiServer)); 
}

public static function GetExport($id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExport", "id=" . $id . "", $ApiToken, $ApiServer)); 
}

public static function GetExports($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetExports", "", $ApiToken, $ApiServer)); 
}

public static function GetFullfilmentCenterSettings($fkStockLocationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetFullfilmentCenterSettings", "fkStockLocationId=" . $fkStockLocationId . "", $ApiToken, $ApiServer)); 
}

public static function GetImport($id,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImport", "id=" . $id . "", $ApiToken, $ApiServer)); 
}

public static function GetImports($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("ImportExport/GetImports", "", $ApiToken, $ApiServer)); 
}

public static function RunNowExport($exportId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/RunNowExport", "exportId=" . $exportId . "", $ApiToken, $ApiServer); 
}

public static function RunNowImport($importId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("ImportExport/RunNowImport", "importId=" . $importId . "", $ApiToken, $ApiServer); 
} 
}
?>