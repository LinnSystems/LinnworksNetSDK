using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace LinnworksAPI
{public static class StockMethods 
{ public static VariationParentStatus CheckVariationParentSKUExists(String parentSKU,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<VariationParentStatus>(Factory.GetResponse("Stock/CheckVariationParentSKUExists", "parentSKU=" + parentSKU + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<GenericEnumDescriptor> GetVariationGroupSearchTypes(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<GenericEnumDescriptor>>(Factory.GetResponse("Stock/GetVariationGroupSearchTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static GenericPagedResult<VariationGroup> SearchVariationGroups(VariationSearchType searchType,String searchText,Int32 pageNumber,Int32 entriesPerPage,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<VariationGroup>>(Factory.GetResponse("Stock/SearchVariationGroups", "searchType=" + Newtonsoft.Json.JsonConvert.SerializeObject(searchType) + "&searchText=" + searchText + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void DeleteVariationGroup(Guid pkVariationGroupId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Stock/DeleteVariationGroup", "pkVariationGroupId=" + pkVariationGroupId + "", ApiToken, ApiServer); 
}

public static VariationGroup GetVariationGroupByParentId(Guid pkStockItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/GetVariationGroupByParentId", "pkStockItemId=" + pkStockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static VariationGroup GetVariationGroupByName(String variationName,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/GetVariationGroupByName", "variationName=" + variationName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void RenameVariationGroup(Guid pkVariationItemId,String variationName,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Stock/RenameVariationGroup", "pkVariationItemId=" + pkVariationItemId + "&variationName=" + variationName + "", ApiToken, ApiServer); 
}

public static List<VariationItem> GetVariationItems(Guid pkVariationItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<VariationItem>>(Factory.GetResponse("Stock/GetVariationItems", "pkVariationItemId=" + pkVariationItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<VariationItem> AddVariationItems(Guid pkVariationItemId,List<Guid> pkStockItemIds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<VariationItem>>(Factory.GetResponse("Stock/AddVariationItems", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(pkStockItemIds) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void DeleteVariationItem(Guid pkVariationItemId,Guid pkStockItemId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Stock/DeleteVariationItem", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemId=" + pkStockItemId + "", ApiToken, ApiServer); 
}

public static VariationGroup CreateVariationGroup(VariationGroupTemplate template,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/CreateVariationGroup", "template=" + Newtonsoft.Json.JsonConvert.SerializeObject(template) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Boolean SKUExists(String SKU,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("Stock/SKUExists", "SKU=" + SKU + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<StockConsumption> GetStockConsumption(Guid stockItemId,Guid locationId,DateTime startDate,DateTime endDate,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockConsumption>>(Factory.GetResponse("Stock/GetStockConsumption", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static GenericPagedResult<StockItemChangeHistory> GetItemChangesHistory(Guid stockItemId,Guid locationId,Int32 entriesPerPage,Int32 pageNumber,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<StockItemChangeHistory>>(Factory.GetResponse("Stock/GetItemChangesHistory", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static TempFile GetItemChangesHistoryCSV(Guid stockItemId,Guid locationId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<TempFile>(Factory.GetResponse("Stock/GetItemChangesHistoryCSV", "stockItemId=" + stockItemId + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static GenericPagedResult<StockItem> GetStockItems(String keyWord,Guid locationId,Int32 entriesPerPage,Int32 pageNumber,Boolean excludeComposites,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<StockItem>>(Factory.GetResponse("Stock/GetStockItems", "keyWord=" + keyWord + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&excludeComposites=" + excludeComposites + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<StockItemLevel> GetStockLevel(Guid stockItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLevel>>(Factory.GetResponse("Stock/GetStockLevel", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void UpdateStockMinimumLevel(Guid stockItemId,Guid locationId,Int32 minimumLevel,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Stock/UpdateStockMinimumLevel", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&minimumLevel=" + minimumLevel + "", ApiToken, ApiServer); 
}

public static List<StockItemSold> GetStockSold(Guid stockItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemSold>>(Factory.GetResponse("Stock/GetStockSold", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<StockItemDuePO> GetStockDuePO(Guid stockItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemDuePO>>(Factory.GetResponse("Stock/GetStockDuePO", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<StockItemReturn> GetStockItemReturnStat(Guid stockItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemReturn>>(Factory.GetResponse("Stock/GetStockItemReturnStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<StockItemScrap> GetStockItemScrapStat(Guid stockItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemScrap>>(Factory.GetResponse("Stock/GetStockItemScrapStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<StockItemSoldStat> GetSoldStat(Guid stockItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemSoldStat>>(Factory.GetResponse("Stock/GetSoldStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
} 
}
}