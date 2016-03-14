<?php
class AuthMethods 
{ public static function GetDebugInformation($key,$password)
{
 return json_decode(Factory::GetResponse("Auth/GetDebugInformation", "key=" . $key . "&password=" . $password . "", "", "")); 
}

public static function MultiLogin($userName,$password)
{
 return json_decode(Factory::GetResponse("Auth/MultiLogin", "userName=" . $userName . "&password=" . $password . "", "", "")); 
}

public static function Authorize($userName,$password,$userId)
{
 return json_decode(Factory::GetResponse("Auth/Authorize", "userName=" . $userName . "&password=" . $password . "&userId=" . $userId . "", "", "")); 
}

public static function ResetPassword($userName,$resetToken,$newPassword,$confirmNewPassword)
{
 Factory::GetResponse("Auth/ResetPassword", "userName=" . $userName . "&resetToken=" . $resetToken . "&newPassword=" . $newPassword . "&confirmNewPassword=" . $confirmNewPassword . "", "", ""); 
}

public static function ResetPasswordRequest($userName)
{
 Factory::GetResponse("Auth/ResetPasswordRequest", "userName=" . $userName . "", "", ""); 
}

public static function AuthorizeByApplication($applicationId,$applicationSecret,$token)
{
 return json_decode(Factory::GetResponse("Auth/AuthorizeByApplication", "applicationId=" . $applicationId . "&applicationSecret=" . $applicationSecret . "&token=" . $token . "", "", "")); 
}

public static function GetServerUTCTime()
{
 return json_decode(Factory::GetResponse("Auth/GetServerUTCTime", "", "", "")); 
} 
}
?>