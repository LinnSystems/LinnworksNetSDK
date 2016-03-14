<?php
class ExtensionsMethods 
{ public static function RevokeToken($token,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Extensions/RevokeToken", "token=" . $token . "", $ApiToken, $ApiServer); 
}

public static function UninstallApplication($InstallationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Extensions/UninstallApplication", "InstallationId=" . $InstallationId . "", $ApiToken, $ApiServer); 
}

public static function LeaveReview($applicationId,$rating,$comment,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Extensions/LeaveReview", "applicationId=" . $applicationId . "&rating=" . $rating . "&comment=" . $comment . "", $ApiToken, $ApiServer)); 
}

public static function GetTemporaryToken($applicationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Extensions/GetTemporaryToken", "applicationId=" . $applicationId . "", $ApiToken, $ApiServer)); 
}

public static function GetApplication($applicationId,$loadReviews,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Extensions/GetApplication", "applicationId=" . $applicationId . "&loadReviews=" . $loadReviews . "", $ApiToken, $ApiServer)); 
}

public static function GetInstalledExtensions($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Extensions/GetInstalledExtensions", "", $ApiToken, $ApiServer)); 
}

public static function SearchApplications($searchString,$count,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Extensions/SearchApplications", "searchString=" . $searchString . "&count=" . $count . "", $ApiToken, $ApiServer)); 
}

public static function GetTokens($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Extensions/GetTokens", "", $ApiToken, $ApiServer)); 
}

public static function GetInstalled($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Extensions/GetInstalled", "", $ApiToken, $ApiServer)); 
}

public static function DownloadLinnworksDesktopClient($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Extensions/DownloadLinnworksDesktopClient", "", $ApiToken, $ApiServer)); 
} 
}
?>