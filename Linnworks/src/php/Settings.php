<?php
class SettingsMethods 
{ public static function AddSetting($category,$setting,$value,$userSpecific,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Settings/AddSetting", "category=" . $category . "&setting=" . $setting . "&value=" . $value . "&userSpecific=" . $userSpecific . "", $ApiToken, $ApiServer); 
}

public static function DeleteSetting($category,$setting,$userSpecific,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Settings/DeleteSetting", "category=" . $category . "&setting=" . $setting . "&userSpecific=" . $userSpecific . "", $ApiToken, $ApiServer); 
}

public static function GetSettings($categories,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/GetSettings", "categories=" . json_encode($categories) . "", $ApiToken, $ApiServer)); 
}

public static function IsCustomerAuthorized($module,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/IsCustomerAuthorized", "module=" . $module . "", $ApiToken, $ApiServer)); 
}

public static function IsBetaApplied($module,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/IsBetaApplied", "module=" . $module . "", $ApiToken, $ApiServer)); 
}

public static function RequestCustomerAccess($module,$name,$telephone,$time,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Settings/RequestCustomerAccess", "module=" . $module . "&name=" . $name . "&telephone=" . $telephone . "&time=" . json_encode($time) . "", $ApiToken, $ApiServer); 
}

public static function GetMeasures($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/GetMeasures", "", $ApiToken, $ApiServer)); 
}

public static function GetVirtualPrinterClientUrl($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/GetVirtualPrinterClientUrl", "", $ApiToken, $ApiServer)); 
}

public static function GetLinnworksDesktopClientUrl($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/GetLinnworksDesktopClientUrl", "", $ApiToken, $ApiServer)); 
} 
}
?>