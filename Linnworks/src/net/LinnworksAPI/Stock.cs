using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class StockMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static List<VariationItem> AddVariationItems(Guid pkVariationItemId,List<Guid> pkStockItemIds,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<VariationItem>>(Factory.GetResponse("Stock/AddVariationItems", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(pkStockItemIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static StockItemBatch BookInStockBatch(BatchedBookIn stockItem,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<StockItemBatch>(Factory.GetResponse("Stock/BookInStockBatch", "stockItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockItem, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void BookInStockItem(BookInStockItem stockItem,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Stock/BookInStockItem", "stockItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockItem, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static VariationParentStatus CheckVariationParentSKUExists(String parentSKU,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<VariationParentStatus>(Factory.GetResponse("Stock/CheckVariationParentSKUExists", "parentSKU=" + parentSKU + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemBatch> CreateStockBatches(List<StockItemBatch> batches,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemBatch>>(Factory.GetResponse("Stock/CreateStockBatches", "batches=" + Newtonsoft.Json.JsonConvert.SerializeObject(batches, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static VariationGroup CreateVariationGroup(VariationGroupTemplate template,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/CreateVariationGroup", "template=" + Newtonsoft.Json.JsonConvert.SerializeObject(template, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void DeleteVariationGroup(Guid pkVariationGroupId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Stock/DeleteVariationGroup", "pkVariationGroupId=" + pkVariationGroupId + "", ApiToken, ApiServer); 
		}

		public static void DeleteVariationItem(Guid pkVariationItemId,Guid pkStockItemId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Stock/DeleteVariationItem", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemId=" + pkStockItemId + "", ApiToken, ApiServer); 
		}

		public static GenericPagedResult<StockItemChangeHistory> GetItemChangesHistory(Guid stockItemId,Guid locationId,Int32 entriesPerPage,Int32 pageNumber,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<StockItemChangeHistory>>(Factory.GetResponse("Stock/GetItemChangesHistory", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static TempFile GetItemChangesHistoryCSV(Guid stockItemId,Guid locationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<TempFile>(Factory.GetResponse("Stock/GetItemChangesHistoryCSV", "stockItemId=" + stockItemId + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemSoldStat> GetSoldStat(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemSoldStat>>(Factory.GetResponse("Stock/GetSoldStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockConsumption> GetStockConsumption(Guid stockItemId,Guid? locationId,DateTime startDate,DateTime endDate,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockConsumption>>(Factory.GetResponse("Stock/GetStockConsumption", "stockItemId=" + stockItemId + "&locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId, serializerSettings) + "&startDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(startDate, serializerSettings) + "&endDate=" + Newtonsoft.Json.JsonConvert.SerializeObject(endDate, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemDuePO> GetStockDuePO(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemDuePO>>(Factory.GetResponse("Stock/GetStockDuePO", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemReturn> GetStockItemReturnStat(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemReturn>>(Factory.GetResponse("Stock/GetStockItemReturnStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static GenericPagedResult<StockItem> GetStockItems(Guid ApiToken, String ApiServer,String keyWord,Guid? locationId,Int32 entriesPerPage,Int32 pageNumber,Boolean excludeComposites = false,Boolean excludeVariations = false,Boolean excludeBatches = false)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<StockItem>>(Factory.GetResponse("Stock/GetStockItems", "keyWord=" + keyWord + "&locationId=" + Newtonsoft.Json.JsonConvert.SerializeObject(locationId, serializerSettings) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&excludeComposites=" + excludeComposites + "&excludeVariations=" + excludeVariations + "&excludeBatches=" + excludeBatches + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItem> GetStockItemsByKey(Search_Stock_ByKey stockIdentifier,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItem>>(Factory.GetResponse("Stock/GetStockItemsByKey", "stockIdentifier=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockIdentifier, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemScrap> GetStockItemScrapStat(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemScrap>>(Factory.GetResponse("Stock/GetStockItemScrapStat", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemFull> GetStockItemsFull(String keyword,Boolean loadCompositeParents,Boolean loadVariationParents,Int32 entriesPerPage,Int32 pageNumber,List<StockInformationDataRequirement> dataRequirements,List<StockInformationSearchType> searchTypes,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemFull>>(Factory.GetResponse("Stock/GetStockItemsFull", "keyword=" + keyword + "&loadCompositeParents=" + loadCompositeParents + "&loadVariationParents=" + loadVariationParents + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&dataRequirements=" + Newtonsoft.Json.JsonConvert.SerializeObject(dataRequirements, serializerSettings) + "&searchTypes=" + Newtonsoft.Json.JsonConvert.SerializeObject(searchTypes, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemLevel> GetStockLevel(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLevel>>(Factory.GetResponse("Stock/GetStockLevel", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemSold> GetStockSold(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemSold>>(Factory.GetResponse("Stock/GetStockSold", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static VariationGroup GetVariationGroupByName(String variationName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/GetVariationGroupByName", "variationName=" + variationName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static VariationGroup GetVariationGroupByParentId(Guid pkStockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<VariationGroup>(Factory.GetResponse("Stock/GetVariationGroupByParentId", "pkStockItemId=" + pkStockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<GenericEnumDescriptor> GetVariationGroupSearchTypes(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<GenericEnumDescriptor>>(Factory.GetResponse("Stock/GetVariationGroupSearchTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<VariationItem> GetVariationItems(Guid pkVariationItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<VariationItem>>(Factory.GetResponse("Stock/GetVariationItems", "pkVariationItemId=" + pkVariationItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void RenameVariationGroup(Guid pkVariationItemId,String variationName,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Stock/RenameVariationGroup", "pkVariationItemId=" + pkVariationItemId + "&variationName=" + variationName + "", ApiToken, ApiServer); 
		}

		public static GenericPagedResult<VariationGroup> SearchVariationGroups(VariationSearchType searchType,String searchText,Int32 pageNumber,Int32 entriesPerPage,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<VariationGroup>>(Factory.GetResponse("Stock/SearchVariationGroups", "searchType=" + searchType + "&searchText=" + searchText + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemLevel> SetStockLevel(Guid ApiToken, String ApiServer,List<StockLevelUpdate> stockLevels,String changeSource = null)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLevel>>(Factory.GetResponse("Stock/SetStockLevel", "stockLevels=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockLevels, serializerSettings) + "&changeSource=" + changeSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Boolean SKUExists(String SKU,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("Stock/SKUExists", "SKU=" + SKU + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void Update_StockItemPartial(PartialUpdateParameter update,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Stock/Update_StockItemPartial", "update=" + Newtonsoft.Json.JsonConvert.SerializeObject(update, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static List<StockItemLevel> UpdateStockLevelsBySKU(Guid ApiToken, String ApiServer,List<StockLevelUpdate> stockLevels,String changeSource = null)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLevel>>(Factory.GetResponse("Stock/UpdateStockLevelsBySKU", "stockLevels=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockLevels, serializerSettings) + "&changeSource=" + changeSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void UpdateStockMinimumLevel(Guid stockItemId,Guid locationId,Int32 minimumLevel,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Stock/UpdateStockMinimumLevel", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&minimumLevel=" + minimumLevel + "", ApiToken, ApiServer); 
		} 
	}
}