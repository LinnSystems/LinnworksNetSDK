<?php
class AuthMethods 
{ public static function AuthorizeByApplication($applicationId,$applicationSecret,$token)
{
 return json_decode(Factory::GetResponse("Auth/AuthorizeByApplication", "applicationId=" . $applicationId . "&applicationSecret=" . $applicationSecret . "&token=" . $token . "", "", "")); 
}

public static function GetApplicationProfileBySecretKey($applicationId,$applicationSecret,$userId)
{
 return json_decode(Factory::GetResponse("Auth/GetApplicationProfileBySecretKey", "applicationId=" . $applicationId . "&applicationSecret=" . $applicationSecret . "&userId=" . $userId . "", "", "")); 
}

public static function GetServerUTCTime()
{
 return json_decode(Factory::GetResponse("Auth/GetServerUTCTime", "", "", "")); 
} 
}
?>