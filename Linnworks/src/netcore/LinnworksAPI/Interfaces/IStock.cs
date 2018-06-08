using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IStockController
	{
		List<VariationItem> AddVariationItems(Guid pkVariationItemId,List<Guid> pkStockItemIds);
		StockItemBatch BookInStockBatch(BatchedBookIn stockItem);
		void BookInStockItem(BookInStockItem stockItem);
		VariationParentStatus CheckVariationParentSKUExists(String parentSKU);
		List<StockItemBatch> CreateStockBatches(List<StockItemBatch> batches);
		VariationGroup CreateVariationGroup(VariationGroupTemplate template);
		void DeleteVariationGroup(Guid pkVariationGroupId);
		void DeleteVariationGroups(DeleteVariationGroupsRequest request);
		void DeleteVariationItem(Guid pkVariationItemId,Guid pkStockItemId);
		void DeleteVariationItems(DeleteVariationItemsRequest request);
		GenericPagedResult<StockItemChangeHistory> GetItemChangesHistory(Guid stockItemId,Guid locationId,Int32 entriesPerPage,Int32 pageNumber);
		TempFile GetItemChangesHistoryCSV(Guid stockItemId,Guid locationId);
		List<StockItemSoldStat> GetSoldStat(Guid stockItemId);
		List<StockConsumption> GetStockConsumption(Guid stockItemId,Guid? locationId,DateTime startDate,DateTime endDate);
		List<StockItemDuePO> GetStockDuePO(Guid stockItemId);
		List<StockItemReturn> GetStockItemReturnStat(Guid stockItemId);
		GenericPagedResult<StockItem> GetStockItems(String keyWord,Guid? locationId,Int32 entriesPerPage,Int32 pageNumber,Boolean excludeComposites = false,Boolean excludeVariations = false,Boolean excludeBatches = false);
		List<StockItem> GetStockItemsByKey(Search_Stock_ByKey stockIdentifier);
		List<StockItemScrap> GetStockItemScrapStat(Guid stockItemId);
		List<StockItemFull> GetStockItemsFull(String keyword,Boolean loadCompositeParents,Boolean loadVariationParents,Int32 entriesPerPage,Int32 pageNumber,List<StockInformationDataRequirement> dataRequirements,List<StockInformationSearchType> searchTypes);
		List<StockItemLevel> GetStockLevel(Guid stockItemId);
		List<GetStockLevel_BatchResponse> GetStockLevel_Batch(GetStockLevel_BatchRequest request);
		List<StockItemSold> GetStockSold(Guid stockItemId);
		BinracksResponse GetSuggestedBinRacks(GetSuggestedBinRacksRequest request);
		BinracksResponse GetSuggestedBinRacks(SearchBinracksRequest request);
		VariationGroup GetVariationGroupByName(String variationName);
		VariationGroup GetVariationGroupByParentId(Guid pkStockItemId);
		List<GenericEnumDescriptor> GetVariationGroupSearchTypes();
		List<VariationItem> GetVariationItems(Guid pkVariationItemId);
		void RenameVariationGroup(Guid pkVariationItemId,String variationName);
		GenericPagedResult<VariationGroup> SearchVariationGroups(VariationSearchType searchType,String searchText,Int32 pageNumber,Int32 entriesPerPage);
		List<StockItemLevel> SetStockLevel(List<StockLevelUpdate> stockLevels,String changeSource = null);
		Boolean SKUExists(String SKU);
		void Update_StockItemPartial(PartialUpdateParameter update);
		List<StockItemLevel> UpdateStockLevelsBySKU(List<StockLevelUpdate> stockLevels,String changeSource = null);
		void UpdateStockMinimumLevel(Guid stockItemId,Guid locationId,Int32 minimumLevel);
	} 
}