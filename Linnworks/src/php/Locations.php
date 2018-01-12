<?php
class LocationsMethods 
{ public static function AddLocation($location,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Locations/AddLocation", "location=" . json_encode($location) . "", $ApiToken, $ApiServer); 
}

public static function DeleteLocation($pkStockLocationId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Locations/DeleteLocation", "pkStockLocationId=" . $pkStockLocationId . "", $ApiToken, $ApiServer); 
}

public static function GetLocation($pkStockLocationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Locations/GetLocation", "pkStockLocationId=" . $pkStockLocationId . "", $ApiToken, $ApiServer)); 
}

public static function UpdateLocation($location,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Locations/UpdateLocation", "location=" . json_encode($location) . "", $ApiToken, $ApiServer); 
} 
}
?>