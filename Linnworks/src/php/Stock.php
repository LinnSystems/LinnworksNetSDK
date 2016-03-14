<?php
class StockMethods 
{ public static function CheckVariationParentSKUExists($parentSKU,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/CheckVariationParentSKUExists", "parentSKU=" . $parentSKU . "", $ApiToken, $ApiServer)); 
}

public static function GetVariationGroupSearchTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetVariationGroupSearchTypes", "", $ApiToken, $ApiServer)); 
}

public static function SearchVariationGroups($searchType,$searchText,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/SearchVariationGroups", "searchType=" . json_encode($searchType) . "&searchText=" . $searchText . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function DeleteVariationGroup($pkVariationGroupId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/DeleteVariationGroup", "pkVariationGroupId=" . $pkVariationGroupId . "", $ApiToken, $ApiServer); 
}

public static function GetVariationGroupByParentId($pkStockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetVariationGroupByParentId", "pkStockItemId=" . $pkStockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetVariationGroupByName($variationName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetVariationGroupByName", "variationName=" . $variationName . "", $ApiToken, $ApiServer)); 
}

public static function RenameVariationGroup($pkVariationItemId,$variationName,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/RenameVariationGroup", "pkVariationItemId=" . $pkVariationItemId . "&variationName=" . $variationName . "", $ApiToken, $ApiServer); 
}

public static function GetVariationItems($pkVariationItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetVariationItems", "pkVariationItemId=" . $pkVariationItemId . "", $ApiToken, $ApiServer)); 
}

public static function AddVariationItems($pkVariationItemId,$pkStockItemIds,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/AddVariationItems", "pkVariationItemId=" . $pkVariationItemId . "&pkStockItemIds=" . json_encode($pkStockItemIds) . "", $ApiToken, $ApiServer)); 
}

public static function DeleteVariationItem($pkVariationItemId,$pkStockItemId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/DeleteVariationItem", "pkVariationItemId=" . $pkVariationItemId . "&pkStockItemId=" . $pkStockItemId . "", $ApiToken, $ApiServer); 
}

public static function FindInstantNewParentSKU($keyWord,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/FindInstantNewParentSKU", "keyWord=" . $keyWord . "", $ApiToken, $ApiServer)); 
}

public static function GetNewParentSKUs($keyWord,$entriesPerPage,$pageNumber,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetNewParentSKUs", "keyWord=" . $keyWord . "&entriesPerPage=" . $entriesPerPage . "&pageNumber=" . $pageNumber . "", $ApiToken, $ApiServer)); 
}

public static function CreateVariationGroup($template,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/CreateVariationGroup", "template=" . json_encode($template) . "", $ApiToken, $ApiServer)); 
}

public static function GetSystemWeightMeasure($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetSystemWeightMeasure", "", $ApiToken, $ApiServer)); 
}

public static function GetWeightMeasures($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetWeightMeasures", "", $ApiToken, $ApiServer)); 
}

public static function GetNewSKU($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetNewSKU", "", $ApiToken, $ApiServer)); 
}

public static function SKUExists($SKU,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/SKUExists", "SKU=" . $SKU . "", $ApiToken, $ApiServer)); 
}

public static function GetStockConsumption($stockItemId,$locationId,$startDate,$endDate,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockConsumption", "stockItemId=" . $stockItemId . "&locationId=" . $locationId . "&startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "", $ApiToken, $ApiServer)); 
}

public static function GetItemChangesHistory($stockItemId,$locationId,$entriesPerPage,$pageNumber,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetItemChangesHistory", "stockItemId=" . $stockItemId . "&locationId=" . $locationId . "&entriesPerPage=" . $entriesPerPage . "&pageNumber=" . $pageNumber . "", $ApiToken, $ApiServer)); 
}

public static function GetItemChangesHistoryCSV($stockItemId,$locationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetItemChangesHistoryCSV", "stockItemId=" . $stockItemId . "&locationId=" . $locationId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockItems($keyWord,$locationId,$entriesPerPage,$pageNumber,$excludeComposites,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockItems", "keyWord=" . $keyWord . "&locationId=" . $locationId . "&entriesPerPage=" . $entriesPerPage . "&pageNumber=" . $pageNumber . "&excludeComposites=" . $excludeComposites . "", $ApiToken, $ApiServer)); 
}

public static function FindInstantStockItems($keyWord,$locationId,$excludeComposites,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/FindInstantStockItems", "keyWord=" . $keyWord . "&locationId=" . $locationId . "&excludeComposites=" . $excludeComposites . "", $ApiToken, $ApiServer)); 
}

public static function GetStockLevel($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockLevel", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function UpdateStockMinimumLevel($stockItemId,$locationId,$minimumLevel,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/UpdateStockMinimumLevel", "stockItemId=" . $stockItemId . "&locationId=" . $locationId . "&minimumLevel=" . $minimumLevel . "", $ApiToken, $ApiServer); 
}

public static function GetStockSold($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockSold", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockDuePO($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockDuePO", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockItemReturnStat($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockItemReturnStat", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockItemScrapStat($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockItemScrapStat", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetSoldStat($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetSoldStat", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
} 
}
?>