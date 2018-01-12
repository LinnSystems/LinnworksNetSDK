<?php
class SettingsMethods 
{ public static function DeleteCurrencyConversionRates($currencies,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Settings/DeleteCurrencyConversionRates", "currencies=" . json_encode($currencies) . "", $ApiToken, $ApiServer); 
}

public static function GetCurrencyConversionRates($requestParams,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/GetCurrencyConversionRates", "requestParams=" . json_encode($requestParams) . "", $ApiToken, $ApiServer)); 
}

public static function GetMeasures($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Settings/GetMeasures", "", $ApiToken, $ApiServer)); 
}

public static function InsertCurrencyConversionRates($rates,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Settings/InsertCurrencyConversionRates", "rates=" . json_encode($rates) . "", $ApiToken, $ApiServer); 
}

public static function UpdateCurrencyConversionRates($rates,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Settings/UpdateCurrencyConversionRates", "rates=" . json_encode($rates) . "", $ApiToken, $ApiServer); 
} 
}
?>