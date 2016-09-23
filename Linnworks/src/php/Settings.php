<?php
class SettingsMethods 
{ public static function GetCurrencyConversionRates($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/GetCurrencyConversionRates", "", $ApiToken, $ApiServer)); 
}

public static function UpdateCurrencyConversionRates($rates,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Settings/UpdateCurrencyConversionRates", "rates=" . json_encode($rates) . "", $ApiToken, $ApiServer); 
}

public static function GetMeasures($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/GetMeasures", "", $ApiToken, $ApiServer)); 
} 
}
?>