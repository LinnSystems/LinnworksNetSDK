<?php
class LocationsMethods 
{ public static function GetLocation($pkStockLocationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/GetLocation", "pkStockLocationId=" . $pkStockLocationId . "", $ApiToken, $ApiServer)); 
}

public static function AddLocation($location,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Locations/AddLocation", "location=" . json_encode($location) . "", $ApiToken, $ApiServer); 
}

public static function UpdateLocation($location,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Locations/UpdateLocation", "location=" . json_encode($location) . "", $ApiToken, $ApiServer); 
}

public static function DeleteLocation($pkStockLocationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Locations/DeleteLocation", "pkStockLocationId=" . $pkStockLocationId . "", $ApiToken, $ApiServer); 
}

public static function GetDefaultColumns($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/GetDefaultColumns", "", $ApiToken, $ApiServer)); 
}

public static function TestFTPConnection($ftpPath,$username,$password,$active,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/TestFTPConnection", "ftpPath=" . $ftpPath . "&username=" . $username . "&password=" . $password . "&active=" . $active . "", $ApiToken, $ApiServer)); 
}

public static function TestSFTPConnection($ftpPath,$username,$password,$port,$compression,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/TestSFTPConnection", "ftpPath=" . $ftpPath . "&username=" . $username . "&password=" . $password . "&port=" . $port . "&compression=" . $compression . "", $ApiToken, $ApiServer)); 
}

public static function TestURLConnection($url,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/TestURLConnection", "url=" . $url . "", $ApiToken, $ApiServer)); 
}

public static function UploadOpenOrdersFlatFile($settings,$mapping,$locationId,$ftpPath,$username,$password,$active,$filename,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Locations/UploadOpenOrdersFlatFile", "settings=" . json_encode($settings) . "&mapping=" . json_encode($mapping) . "&locationId=" . $locationId . "&ftpPath=" . $ftpPath . "&username=" . $username . "&password=" . $password . "&active=" . $active . "&filename=" . $filename . "", $ApiToken, $ApiServer); 
}

public static function UploadOpenOrdersFlatFileSFTP($settings,$mapping,$locationId,$ftpPath,$username,$password,$port,$compression,$filename,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Locations/UploadOpenOrdersFlatFileSFTP", "settings=" . json_encode($settings) . "&mapping=" . json_encode($mapping) . "&locationId=" . $locationId . "&ftpPath=" . $ftpPath . "&username=" . $username . "&password=" . $password . "&port=" . $port . "&compression=" . $compression . "&filename=" . $filename . "", $ApiToken, $ApiServer); 
}

public static function DownloadFileFromFTP($ftpPath,$username,$password,$active,$filename,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/DownloadFileFromFTP", "ftpPath=" . $ftpPath . "&username=" . $username . "&password=" . $password . "&active=" . $active . "&filename=" . $filename . "", $ApiToken, $ApiServer)); 
}

public static function DownloadFileFromSFTP($ftpPath,$username,$password,$port,$compression,$filename,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/DownloadFileFromSFTP", "ftpPath=" . $ftpPath . "&username=" . $username . "&password=" . $password . "&port=" . $port . "&compression=" . $compression . "&filename=" . $filename . "", $ApiToken, $ApiServer)); 
}

public static function GetFileColumnNames($fileId,$settings,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/GetFileColumnNames", "fileId=" . $fileId . "&settings=" . json_encode($settings) . "", $ApiToken, $ApiServer)); 
}

public static function GetImportFilePreview($fileId,$settings,$mapping,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/GetImportFilePreview", "fileId=" . $fileId . "&settings=" . json_encode($settings) . "&mapping=" . json_encode($mapping) . "", $ApiToken, $ApiServer)); 
}

public static function GetExportFilePreview($locationId,$mapping,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/GetExportFilePreview", "locationId=" . $locationId . "&mapping=" . json_encode($mapping) . "", $ApiToken, $ApiServer)); 
} 
}
?>