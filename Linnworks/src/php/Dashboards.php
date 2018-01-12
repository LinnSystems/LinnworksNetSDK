<?php
class DashboardsMethods 
{ public static function ExecuteCustomPagedScript($scriptId,$parameters,$entriesPerPage,$pageNumber,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/ExecuteCustomPagedScript", "scriptId=" . $scriptId . "&parameters=" . json_encode($parameters) . "&entriesPerPage=" . $entriesPerPage . "&pageNumber=" . $pageNumber . "", $ApiToken, $ApiServer)); 
}

public static function ExecuteCustomScriptQuery($script,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/ExecuteCustomScriptQuery", "script=" . $script . "", $ApiToken, $ApiServer)); 
}

public static function GetInventoryLocationCategoriesData($date,$locationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/GetInventoryLocationCategoriesData", "date=" . json_encode($date) . "&locationId=" . $locationId . "", $ApiToken, $ApiServer)); 
}

public static function GetInventoryLocationData($date,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/GetInventoryLocationData", "date=" . json_encode($date) . "", $ApiToken, $ApiServer)); 
}

public static function GetInventoryLocationProductsData($date,$locationId,$categoryId,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/GetInventoryLocationProductsData", "date=" . json_encode($date) . "&locationId=" . $locationId . "&categoryId=" . $categoryId . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function GetLowStockLevel($locationId,$numRows,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/GetLowStockLevel", "locationId=" . json_encode($locationId) . "&numRows=" . json_encode($numRows) . "", $ApiToken, $ApiServer)); 
}

public static function GetPerformanceDetail($period,$timeScale,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/GetPerformanceDetail", "period=" . $period . "&timeScale=" . $timeScale . "", $ApiToken, $ApiServer)); 
}

public static function GetPerformanceTableData($period,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/GetPerformanceTableData", "period=" . $period . "", $ApiToken, $ApiServer)); 
}

public static function GetTopProducts($type,$period,$numRows,$orderStatus,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Dashboards/GetTopProducts", "type=" . $type . "&period=" . $period . "&numRows=" . $numRows . "&orderStatus=" . $orderStatus . "", $ApiToken, $ApiServer)); 
} 
}
?>