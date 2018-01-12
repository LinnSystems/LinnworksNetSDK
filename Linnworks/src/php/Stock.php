<?php
class StockMethods 
{ public static function AddVariationItems($pkVariationItemId,$pkStockItemIds,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/AddVariationItems", "pkVariationItemId=" . $pkVariationItemId . "&pkStockItemIds=" . json_encode($pkStockItemIds) . "", $ApiToken, $ApiServer)); 
}

public static function BookInStockBatch($stockItem,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/BookInStockBatch", "stockItem=" . json_encode($stockItem) . "", $ApiToken, $ApiServer)); 
}

public static function BookInStockItem($stockItem,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/BookInStockItem", "stockItem=" . json_encode($stockItem) . "", $ApiToken, $ApiServer); 
}

public static function CheckVariationParentSKUExists($parentSKU,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/CheckVariationParentSKUExists", "parentSKU=" . $parentSKU . "", $ApiToken, $ApiServer)); 
}

public static function CreateStockBatches($batches,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/CreateStockBatches", "batches=" . json_encode($batches) . "", $ApiToken, $ApiServer)); 
}

public static function CreateVariationGroup($template,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/CreateVariationGroup", "template=" . json_encode($template) . "", $ApiToken, $ApiServer)); 
}

public static function DeleteVariationGroup($pkVariationGroupId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/DeleteVariationGroup", "pkVariationGroupId=" . $pkVariationGroupId . "", $ApiToken, $ApiServer); 
}

public static function DeleteVariationItem($pkVariationItemId,$pkStockItemId,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/DeleteVariationItem", "pkVariationItemId=" . $pkVariationItemId . "&pkStockItemId=" . $pkStockItemId . "", $ApiToken, $ApiServer); 
}

public static function GetItemChangesHistory($stockItemId,$locationId,$entriesPerPage,$pageNumber,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetItemChangesHistory", "stockItemId=" . $stockItemId . "&locationId=" . $locationId . "&entriesPerPage=" . $entriesPerPage . "&pageNumber=" . $pageNumber . "", $ApiToken, $ApiServer)); 
}

public static function GetItemChangesHistoryCSV($stockItemId,$locationId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetItemChangesHistoryCSV", "stockItemId=" . $stockItemId . "&locationId=" . $locationId . "", $ApiToken, $ApiServer)); 
}

public static function GetSoldStat($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetSoldStat", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockConsumption($stockItemId,$locationId,$startDate,$endDate,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockConsumption", "stockItemId=" . $stockItemId . "&locationId=" . json_encode($locationId) . "&startDate=" . json_encode($startDate) . "&endDate=" . json_encode($endDate) . "", $ApiToken, $ApiServer)); 
}

public static function GetStockDuePO($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockDuePO", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockItemReturnStat($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockItemReturnStat", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockItems($keyWord,$locationId,$entriesPerPage,$pageNumber,$excludeComposites,$excludeVariations,$excludeBatches,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockItems", "keyWord=" . $keyWord . "&locationId=" . json_encode($locationId) . "&entriesPerPage=" . $entriesPerPage . "&pageNumber=" . $pageNumber . "&excludeComposites=" . $excludeComposites . "&excludeVariations=" . $excludeVariations . "&excludeBatches=" . $excludeBatches . "", $ApiToken, $ApiServer)); 
}

public static function GetStockItemsByKey($stockIdentifier,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockItemsByKey", "stockIdentifier=" . json_encode($stockIdentifier) . "", $ApiToken, $ApiServer)); 
}

public static function GetStockItemScrapStat($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockItemScrapStat", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockItemsFull($keyword,$loadCompositeParents,$loadVariationParents,$entriesPerPage,$pageNumber,$dataRequirements,$searchTypes,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockItemsFull", "keyword=" . $keyword . "&loadCompositeParents=" . $loadCompositeParents . "&loadVariationParents=" . $loadVariationParents . "&entriesPerPage=" . $entriesPerPage . "&pageNumber=" . $pageNumber . "&dataRequirements=" . json_encode($dataRequirements) . "&searchTypes=" . json_encode($searchTypes) . "", $ApiToken, $ApiServer)); 
}

public static function GetStockLevel($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockLevel", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetStockSold($stockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetStockSold", "stockItemId=" . $stockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetVariationGroupByName($variationName,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetVariationGroupByName", "variationName=" . $variationName . "", $ApiToken, $ApiServer)); 
}

public static function GetVariationGroupByParentId($pkStockItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetVariationGroupByParentId", "pkStockItemId=" . $pkStockItemId . "", $ApiToken, $ApiServer)); 
}

public static function GetVariationGroupSearchTypes($ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetVariationGroupSearchTypes", "", $ApiToken, $ApiServer)); 
}

public static function GetVariationItems($pkVariationItemId,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/GetVariationItems", "pkVariationItemId=" . $pkVariationItemId . "", $ApiToken, $ApiServer)); 
}

public static function RenameVariationGroup($pkVariationItemId,$variationName,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/RenameVariationGroup", "pkVariationItemId=" . $pkVariationItemId . "&variationName=" . $variationName . "", $ApiToken, $ApiServer); 
}

public static function SearchVariationGroups($searchType,$searchText,$pageNumber,$entriesPerPage,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/SearchVariationGroups", "searchType=" . $searchType . "&searchText=" . $searchText . "&pageNumber=" . $pageNumber . "&entriesPerPage=" . $entriesPerPage . "", $ApiToken, $ApiServer)); 
}

public static function SetStockLevel($stockLevels,$changeSource,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/SetStockLevel", "stockLevels=" . json_encode($stockLevels) . "&changeSource=" . $changeSource . "", $ApiToken, $ApiServer)); 
}

public static function SKUExists($SKU,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/SKUExists", "SKU=" . $SKU . "", $ApiToken, $ApiServer)); 
}

public static function Update_StockItemPartial($update,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/Update_StockItemPartial", "update=" . json_encode($update) . "", $ApiToken, $ApiServer); 
}

public static function UpdateStockLevelsBySKU($stockLevels,$changeSource,$ApiToken, $ApiServer)
{
 return json_decode(Factory::GetResponse("Stock/UpdateStockLevelsBySKU", "stockLevels=" . json_encode($stockLevels) . "&changeSource=" . $changeSource . "", $ApiToken, $ApiServer)); 
}

public static function UpdateStockMinimumLevel($stockItemId,$locationId,$minimumLevel,$ApiToken, $ApiServer)
{
 Factory::GetResponse("Stock/UpdateStockMinimumLevel", "stockItemId=" . $stockItemId . "&locationId=" . $locationId . "&minimumLevel=" . $minimumLevel . "", $ApiToken, $ApiServer); 
} 
}
?>