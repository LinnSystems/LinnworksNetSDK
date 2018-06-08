using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class StockController : BaseController, IStockController
    {
        public StockController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        public List<VariationItem> AddVariationItems(Guid pkVariationItemId,List<Guid> pkStockItemIds)
		{
			var response = GetResponse("Stock/AddVariationItems", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemIds=" + JsonFormatter.ConvertToJson(pkStockItemIds) + "");
            return JsonFormatter.ConvertFromJson<List<VariationItem>>(response);
		}

		public StockItemBatch BookInStockBatch(BatchedBookIn stockItem)
		{
			var response = GetResponse("Stock/BookInStockBatch", "stockItem=" + JsonFormatter.ConvertToJson(stockItem) + "");
            return JsonFormatter.ConvertFromJson<StockItemBatch>(response);
		}

		public void BookInStockItem(BookInStockItem stockItem)
		{
			GetResponse("Stock/BookInStockItem", "stockItem=" + JsonFormatter.ConvertToJson(stockItem) + "");
		}

		public VariationParentStatus CheckVariationParentSKUExists(String parentSKU)
		{
			var response = GetResponse("Stock/CheckVariationParentSKUExists", "parentSKU=" + System.Net.WebUtility.UrlEncode(parentSKU) + "");
            return JsonFormatter.ConvertFromJson<VariationParentStatus>(response);
		}

		public List<StockItemBatch> CreateStockBatches(List<StockItemBatch> batches)
		{
			var response = GetResponse("Stock/CreateStockBatches", "batches=" + JsonFormatter.ConvertToJson(batches) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemBatch>>(response);
		}

		public VariationGroup CreateVariationGroup(VariationGroupTemplate template)
		{
			var response = GetResponse("Stock/CreateVariationGroup", "template=" + JsonFormatter.ConvertToJson(template) + "");
            return JsonFormatter.ConvertFromJson<VariationGroup>(response);
		}

		public void DeleteVariationGroup(Guid pkVariationGroupId)
		{
			GetResponse("Stock/DeleteVariationGroup", "pkVariationGroupId=" + pkVariationGroupId + "");
		}

		public void DeleteVariationGroups(DeleteVariationGroupsRequest request)
		{
			GetResponse("Stock/DeleteVariationGroups", "request=" + JsonFormatter.ConvertToJson(request) + "");
		}

		public void DeleteVariationItem(Guid pkVariationItemId,Guid pkStockItemId)
		{
			GetResponse("Stock/DeleteVariationItem", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemId=" + pkStockItemId + "");
		}

		public void DeleteVariationItems(DeleteVariationItemsRequest request)
		{
			GetResponse("Stock/DeleteVariationItems", "request=" + JsonFormatter.ConvertToJson(request) + "");
		}

		public GenericPagedResult<StockItemChangeHistory> GetItemChangesHistory(Guid stockItemId,Guid locationId,Int32 entriesPerPage,Int32 pageNumber)
		{
			var response = GetResponse("Stock/GetItemChangesHistory", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<StockItemChangeHistory>>(response);
		}

		public TempFile GetItemChangesHistoryCSV(Guid stockItemId,Guid locationId)
		{
			var response = GetResponse("Stock/GetItemChangesHistoryCSV", "stockItemId=" + stockItemId + "&locationId=" + locationId + "");
            return JsonFormatter.ConvertFromJson<TempFile>(response);
		}

		public List<StockItemSoldStat> GetSoldStat(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetSoldStat", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemSoldStat>>(response);
		}

		public List<StockConsumption> GetStockConsumption(Guid stockItemId,Guid? locationId,DateTime startDate,DateTime endDate)
		{
			var response = GetResponse("Stock/GetStockConsumption", "stockItemId=" + stockItemId + "&locationId=" + JsonFormatter.ConvertToJson(locationId) + "&startDate=" + JsonFormatter.ConvertToJson(startDate) + "&endDate=" + JsonFormatter.ConvertToJson(endDate) + "");
            return JsonFormatter.ConvertFromJson<List<StockConsumption>>(response);
		}

		public List<StockItemDuePO> GetStockDuePO(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockDuePO", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemDuePO>>(response);
		}

		public List<StockItemReturn> GetStockItemReturnStat(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockItemReturnStat", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemReturn>>(response);
		}

		public GenericPagedResult<StockItem> GetStockItems(String keyWord,Guid? locationId,Int32 entriesPerPage,Int32 pageNumber,Boolean excludeComposites = false,Boolean excludeVariations = false,Boolean excludeBatches = false)
		{
			var response = GetResponse("Stock/GetStockItems", "keyWord=" + System.Net.WebUtility.UrlEncode(keyWord) + "&locationId=" + JsonFormatter.ConvertToJson(locationId) + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&excludeComposites=" + excludeComposites + "&excludeVariations=" + excludeVariations + "&excludeBatches=" + excludeBatches + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<StockItem>>(response);
		}

		public List<StockItem> GetStockItemsByKey(Search_Stock_ByKey stockIdentifier)
		{
			var response = GetResponse("Stock/GetStockItemsByKey", "stockIdentifier=" + JsonFormatter.ConvertToJson(stockIdentifier) + "");
            return JsonFormatter.ConvertFromJson<List<StockItem>>(response);
		}

		public List<StockItemScrap> GetStockItemScrapStat(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockItemScrapStat", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemScrap>>(response);
		}

		public List<StockItemFull> GetStockItemsFull(String keyword,Boolean loadCompositeParents,Boolean loadVariationParents,Int32 entriesPerPage,Int32 pageNumber,List<StockInformationDataRequirement> dataRequirements,List<StockInformationSearchType> searchTypes)
		{
			var response = GetResponse("Stock/GetStockItemsFull", "keyword=" + System.Net.WebUtility.UrlEncode(keyword) + "&loadCompositeParents=" + loadCompositeParents + "&loadVariationParents=" + loadVariationParents + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&dataRequirements=" + JsonFormatter.ConvertToJson(dataRequirements) + "&searchTypes=" + JsonFormatter.ConvertToJson(searchTypes) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemFull>>(response);
		}

		public List<StockItemLevel> GetStockLevel(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockLevel", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLevel>>(response);
		}

		public List<GetStockLevel_BatchResponse> GetStockLevel_Batch(GetStockLevel_BatchRequest request)
		{
			var response = GetResponse("Stock/GetStockLevel_Batch", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<List<GetStockLevel_BatchResponse>>(response);
		}

		public List<StockItemSold> GetStockSold(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockSold", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemSold>>(response);
		}

		public BinracksResponse GetSuggestedBinRacks(GetSuggestedBinRacksRequest request)
		{
			var response = GetResponse("Stock/GetSuggestedBinRacks", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<BinracksResponse>(response);
		}

		public BinracksResponse GetSuggestedBinRacks(SearchBinracksRequest request)
		{
			var response = GetResponse("Stock/GetSuggestedBinRacks", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<BinracksResponse>(response);
		}

		public VariationGroup GetVariationGroupByName(String variationName)
		{
			var response = GetResponse("Stock/GetVariationGroupByName", "variationName=" + System.Net.WebUtility.UrlEncode(variationName) + "");
            return JsonFormatter.ConvertFromJson<VariationGroup>(response);
		}

		public VariationGroup GetVariationGroupByParentId(Guid pkStockItemId)
		{
			var response = GetResponse("Stock/GetVariationGroupByParentId", "pkStockItemId=" + pkStockItemId + "");
            return JsonFormatter.ConvertFromJson<VariationGroup>(response);
		}

		public List<GenericEnumDescriptor> GetVariationGroupSearchTypes()
		{
			var response = GetResponse("Stock/GetVariationGroupSearchTypes", "");
            return JsonFormatter.ConvertFromJson<List<GenericEnumDescriptor>>(response);
		}

		public List<VariationItem> GetVariationItems(Guid pkVariationItemId)
		{
			var response = GetResponse("Stock/GetVariationItems", "pkVariationItemId=" + pkVariationItemId + "");
            return JsonFormatter.ConvertFromJson<List<VariationItem>>(response);
		}

		public void RenameVariationGroup(Guid pkVariationItemId,String variationName)
		{
			GetResponse("Stock/RenameVariationGroup", "pkVariationItemId=" + pkVariationItemId + "&variationName=" + System.Net.WebUtility.UrlEncode(variationName) + "");
		}

		public GenericPagedResult<VariationGroup> SearchVariationGroups(VariationSearchType searchType,String searchText,Int32 pageNumber,Int32 entriesPerPage)
		{
			var response = GetResponse("Stock/SearchVariationGroups", "searchType=" + searchType.ToString() + "&searchText=" + System.Net.WebUtility.UrlEncode(searchText) + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<VariationGroup>>(response);
		}

		public List<StockItemLevel> SetStockLevel(List<StockLevelUpdate> stockLevels,String changeSource = null)
		{
			var response = GetResponse("Stock/SetStockLevel", "stockLevels=" + JsonFormatter.ConvertToJson(stockLevels) + "&changeSource=" + System.Net.WebUtility.UrlEncode(changeSource) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLevel>>(response);
		}

		public Boolean SKUExists(String SKU)
		{
			var response = GetResponse("Stock/SKUExists", "SKU=" + System.Net.WebUtility.UrlEncode(SKU) + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		public void Update_StockItemPartial(PartialUpdateParameter update)
		{
			GetResponse("Stock/Update_StockItemPartial", "update=" + JsonFormatter.ConvertToJson(update) + "");
		}

		public List<StockItemLevel> UpdateStockLevelsBySKU(List<StockLevelUpdate> stockLevels,String changeSource = null)
		{
			var response = GetResponse("Stock/UpdateStockLevelsBySKU", "stockLevels=" + JsonFormatter.ConvertToJson(stockLevels) + "&changeSource=" + System.Net.WebUtility.UrlEncode(changeSource) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLevel>>(response);
		}

		public void UpdateStockMinimumLevel(Guid stockItemId,Guid locationId,Int32 minimumLevel)
		{
			GetResponse("Stock/UpdateStockMinimumLevel", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&minimumLevel=" + minimumLevel + "");
		} 
    }
}