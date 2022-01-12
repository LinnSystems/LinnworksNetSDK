using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{ 
    public interface IStockController
	{
		AddRollingStockTakeResponse AddRollingStockTake(AddRollingStockTakeRequest request);
		List<VariationItem> AddVariationItems(Guid pkVariationItemId,List<Guid> pkStockItemIds);
		BatchStockLevelDeltaResponse BatchStockLevelDelta(BatchStockLevelDetaRequest request);
		StockItemBatch BookInStockBatch(BatchedBookIn stockItem);
		void BookInStockItem(BookInStockItem stockItem);
		VariationParentStatus CheckVariationParentSKUExists(String parentSKU);
		List<StockItemBatch> CreateStockBatches(List<StockItemBatch> batches);
		VariationGroup CreateVariationGroup(VariationGroupTemplate template);
		GetWarehouseMoveResponse CreateWarehouseMove(CreateWarehouseMoveRequest request);
		void DeleteVariationGroup(Guid pkVariationGroupId);
		void DeleteVariationGroups(DeleteVariationGroupsRequest request);
		void DeleteVariationItem(Guid pkVariationItemId,Guid pkStockItemId);
		void DeleteVariationItems(DeleteVariationItemsRequest request);
		BinracksResponse GetBinRacksById(GetBinrackByIdRequest request);
		GenericPagedResult<StockItemChangeHistory> GetItemChangesHistory(Guid stockItemId,Guid locationId,Int32 entriesPerPage,Int32 pageNumber);
		TempFile GetItemChangesHistoryCSV(Guid stockItemId,Guid locationId);
		List<StockItemSoldStat> GetSoldStat(Guid stockItemId);
		List<StockConsumption> GetStockConsumption(Guid stockItemId,Guid? locationId,DateTime startDate,DateTime endDate);
		List<StockItemDuePO> GetStockDuePO(Guid stockItemId);
		List<StockItemReturn> GetStockItemReturnStat(Guid stockItemId);
		GenericPagedResult<StockItem> GetStockItems(String keyWord,Guid? locationId,Int32 entriesPerPage,Int32 pageNumber,Boolean excludeComposites = false,Boolean excludeVariations = false,Boolean excludeBatches = false);
		GetStockItemsByIdsResponse GetStockItemsByIds(GetStockItemsByIdsRequest request);
		List<StockItem> GetStockItemsByKey(Search_Stock_ByKey stockIdentifier);
		List<StockItemScrap> GetStockItemScrapStat(Guid stockItemId);
		List<StockItemFull> GetStockItemsFull(String keyword,Boolean loadCompositeParents,Boolean loadVariationParents,Int32 entriesPerPage,Int32 pageNumber,List<StockInformationDataRequirement> dataRequirements,List<StockInformationSearchType> searchTypes);
		GetStockItemsFullByIdsResponse GetStockItemsFullByIds(GetStockItemsFullByIdsRequest request);
		GetStockItemTypeInfoResponse GetStockItemTypeInfo(GetStockItemTypeInfoRequest request);
		List<StockItemLevel> GetStockLevel(Guid stockItemId);
		List<GetStockLevel_BatchResponse> GetStockLevel_Batch(GetStockLevel_BatchRequest request);
		GetStockLevelByLocationResponse GetStockLevelByLocation(GetStockLevelByLocationRequest request);
		List<StockItemSold> GetStockSold(Guid stockItemId);
		VariationGroup GetVariationGroupByName(String variationName);
		VariationGroup GetVariationGroupByParentId(Guid pkStockItemId);
		List<GenericEnumDescriptor> GetVariationGroupSearchTypes();
		List<VariationItem> GetVariationItems(Guid pkVariationItemId);
		void RenameVariationGroup(Guid pkVariationItemId,String variationName);
		GenericPagedResult<VariationGroup> SearchVariationGroups(VariationSearchType searchType,String searchText,Int32 pageNumber,Int32 entriesPerPage);
		List<StockItemLevel> SetStockLevel(List<StockLevelUpdate> stockLevels,String changeSource = null);
		Boolean SKUExists(String SKU);
		void Update_StockItemPartial(PartialUpdateParameter update);
		UpdateSkuGroupIdentifierResponse UpdateSkuGroupIdentifier(UpdateSkuGroupIdentifierRequest request);
		UpdateStockLevelsBulkResponse UpdateStockLevelsBulk(UpdateStockLevelsBulkRequest request);
		List<StockItemLevel> UpdateStockLevelsBySKU(List<StockLevelUpdate> stockLevels,String changeSource = null);
		void UpdateStockMinimumLevel(Guid stockItemId,Guid locationId,Int32 minimumLevel);
	} 
}