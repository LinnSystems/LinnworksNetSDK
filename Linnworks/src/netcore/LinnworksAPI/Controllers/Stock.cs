using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class StockController : BaseController, IStockController
    {
        public StockController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Add rolling stock take/count. Rolling stock count will create a stock count header for every day (UTC based). Every request will create a session, adds all entries into the stock count
        /// recounts all totals and discrepancies. WMS location or batched items requires BatchInventoryId to be specified. If you are submitting stock level for item that doesn't have batch inventory you must create it first, get its id and submit in the count
        /// The method validates all entries, if any errors encountered the whole request will be rejected. 
        /// </summary>
        public AddRollingStockTakeResponse AddRollingStockTake(AddRollingStockTakeRequest request)
		{
			var response = GetResponse("Stock/AddRollingStockTake", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AddRollingStockTakeResponse>(response);
		}

		/// <summary>
        /// Use this call to add a new item to a variation group 
        /// </summary>
        /// <param name="pkVariationItemId">The variation group id</param>
        /// <param name="pkStockItemIds">The list of item ids to add</param>
        /// <returns>The row id for the new item</returns>
        public List<VariationItem> AddVariationItems(Guid pkVariationItemId,List<Guid> pkStockItemIds)
		{
			var response = GetResponse("Stock/AddVariationItems", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(pkStockItemIds)) + "");
            return JsonFormatter.ConvertFromJson<List<VariationItem>>(response);
		}

		public BatchStockLevelDeltaResponse BatchStockLevelDelta(BatchStockLevelDetaRequest request)
		{
			var response = GetResponse("Stock/BatchStockLevelDelta", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<BatchStockLevelDeltaResponse>(response);
		}

		/// <summary>
        /// Increases the stock level and current stock value of a batched stock item by the specified quantity 
        /// </summary>
        /// <param name="stockItem">Batch stock item</param>
        public StockItemBatch BookInStockBatch(BatchedBookIn stockItem)
		{
			var response = GetResponse("Stock/BookInStockBatch", "stockItem=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(stockItem)) + "");
            return JsonFormatter.ConvertFromJson<StockItemBatch>(response);
		}

		/// <summary>
        /// Increases the stock level and current stock value of a stock item by the specified quantity. 
        /// </summary>
        /// <param name="stockItem">Book in parameters used to update stock items</param>
        public void BookInStockItem(BookInStockItem stockItem)
		{
			GetResponse("Stock/BookInStockItem", "stockItem=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(stockItem)) + "");
		}

		/// <summary>
        /// Use this call to check if a potential parent SKU exist and its current status. 
        /// </summary>
        /// <param name="parentSKU">The SKU</param>
        /// <returns>An enum describing Exists / NotExists / AlreadyVariation</returns>
        public VariationParentStatus CheckVariationParentSKUExists(String parentSKU)
		{
			var response = GetResponse("Stock/CheckVariationParentSKUExists", "parentSKU=" + System.Net.WebUtility.UrlEncode(parentSKU) + "");
            return JsonFormatter.ConvertFromJson<VariationParentStatus>(response);
		}

		/// <summary>
        /// Creates stock item batches 
        /// </summary>
        /// <param name="batches"></param>
        /// <returns>Returns the stock item batches with batch IDs</returns>
        public List<StockItemBatch> CreateStockBatches(List<StockItemBatch> batches)
		{
			var response = GetResponse("Stock/CreateStockBatches", "batches=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(batches)) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemBatch>>(response);
		}

		/// <summary>
        /// Use this call to create a variation group 
        /// </summary>
        /// <param name="template">Variation parent inforamtion</param>
        public VariationGroup CreateVariationGroup(VariationGroupTemplate template)
		{
			var response = GetResponse("Stock/CreateVariationGroup", "template=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(template)) + "");
            return JsonFormatter.ConvertFromJson<VariationGroup>(response);
		}

		/// <summary>
        /// Create a new warehouse move in state of In Transit or Open. 
        /// To create a new move you need the exact batch inventory id and bin rack id of the destination. However it is possible to create a move without knowing where it is going specifically, 
        /// in which case don't supply BinrackIdDestination (or send null) 
        /// </summary>
        public GetWarehouseMoveResponse CreateWarehouseMove(CreateWarehouseMoveRequest request)
		{
			var response = GetResponse("Stock/CreateWarehouseMove", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetWarehouseMoveResponse>(response);
		}

		/// <summary>
        /// Use this call to delete variation group by id 
        /// </summary>
        public void DeleteVariationGroup(Guid pkVariationGroupId)
		{
			GetResponse("Stock/DeleteVariationGroup", "pkVariationGroupId=" + pkVariationGroupId + "");
		}

		/// <summary>
        /// Use this call to delete variation groups by ids 
        /// </summary>
        public void DeleteVariationGroups(DeleteVariationGroupsRequest request)
		{
			GetResponse("Stock/DeleteVariationGroups", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Use this call to add a new item to a variation group 
        /// </summary>
        /// <param name="pkVariationItemId">The variation group id</param>
        /// <param name="pkStockItemId">The stock item id to add</param>
        /// <returns>The row id for the new item</returns>
        public void DeleteVariationItem(Guid pkVariationItemId,Guid pkStockItemId)
		{
			GetResponse("Stock/DeleteVariationItem", "pkVariationItemId=" + pkVariationItemId + "&pkStockItemId=" + pkStockItemId + "");
		}

		/// <summary>
        /// Use this call to delete variation items in bulk 
        /// </summary>
        /// <param name="request">Contains variation group id 'VariationItemId' and id list of child items 'StockItemIds'</param>
        public void DeleteVariationItems(DeleteVariationItemsRequest request)
		{
			GetResponse("Stock/DeleteVariationItems", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Returns the list of BinRacks by BinRack Ids for WMS locations. 
        /// </summary>
        public BinracksResponse GetBinRacksById(GetBinrackByIdRequest request)
		{
			var response = GetResponse("Stock/GetBinRacksById", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<BinracksResponse>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "stock changes of an item" 
        /// </summary>
        /// <param name="stockItemId">Used to specify report stock item id</param>
        /// <param name="locationId">Used to specify report location id. If null then combined</param>
        /// <param name="entriesPerPage">Used to specify number of entries per page in report</param>
        /// <param name="pageNumber">Used to specify report page number. If -1 then will return all pages</param>
        /// <returns>PagedStockItemChangeHistoryResult</returns>
        public GenericPagedResult<StockItemChangeHistory> GetItemChangesHistory(Guid stockItemId,Guid locationId,Int32 entriesPerPage,Int32 pageNumber)
		{
			var response = GetResponse("Stock/GetItemChangesHistory", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<StockItemChangeHistory>>(response);
		}

		/// <summary>
        /// Use this call to retrieve link to csv file report about "Stock changes of an item" 
        /// </summary>
        /// <param name="stockItemId">Used to specify stock item id</param>
        /// <param name="locationId">Used to specify location id. If null then combined</param>
        /// <returns>TempFile</returns>
        public TempFile GetItemChangesHistoryCSV(Guid stockItemId,Guid locationId)
		{
			var response = GetResponse("Stock/GetItemChangesHistoryCSV", "stockItemId=" + stockItemId + "&locationId=" + locationId + "");
            return JsonFormatter.ConvertFromJson<TempFile>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item sold stat" 
        /// </summary>
        /// <param name="stockItemId">Used to specify report stock item id</param>
        /// <returns>List of StockItemSoldStat</returns>
        public List<StockItemSoldStat> GetSoldStat(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetSoldStat", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemSoldStat>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "stock consumption between two dates" 
        /// </summary>
        /// <param name="stockItemId">Used to specify report stock id</param>
        /// <param name="locationId">Used to specify location id. If null, then will return combined result of every location</param>
        /// <param name="startDate">Used to specify report start date</param>
        /// <param name="endDate">Used to specify report end date</param>
        /// <returns>List of StockConsumption</returns>
        public List<StockConsumption> GetStockConsumption(Guid stockItemId,Guid? locationId,DateTime startDate,DateTime endDate)
		{
			var response = GetResponse("Stock/GetStockConsumption", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&startDate=" + System.Net.WebUtility.UrlEncode(startDate.ToString("yyyy-MM-dd HH:mm:ss")) + "&endDate=" + System.Net.WebUtility.UrlEncode(endDate.ToString("yyyy-MM-dd HH:mm:ss")) + "");
            return JsonFormatter.ConvertFromJson<List<StockConsumption>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item stock due po" 
        /// </summary>
        /// <param name="stockItemId">Used to specify report stock item id</param>
        /// <returns>List of StockItemDuePO</returns>
        public List<StockItemDuePO> GetStockDuePO(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockDuePO", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemDuePO>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item return stat" 
        /// </summary>
        /// <param name="stockItemId">Used to specify report stock item id</param>
        /// <returns>List of StockItemReturn</returns>
        public List<StockItemReturn> GetStockItemReturnStat(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockItemReturnStat", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemReturn>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "Found stock items" 
        /// </summary>
        /// <returns>Stock items list</returns>
        public GenericPagedResult<StockItem> GetStockItems(String keyWord,Guid? locationId,Int32 entriesPerPage,Int32 pageNumber,Boolean excludeComposites = false,Boolean excludeVariations = false,Boolean excludeBatches = false)
		{
			var response = GetResponse("Stock/GetStockItems", "keyWord=" + System.Net.WebUtility.UrlEncode(keyWord) + "&locationId=" + locationId + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&excludeComposites=" + excludeComposites + "&excludeVariations=" + excludeVariations + "&excludeBatches=" + excludeBatches + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<StockItem>>(response);
		}

		public GetStockItemsByIdsResponse GetStockItemsByIds(GetStockItemsByIdsRequest request)
		{
			var response = GetResponse("Stock/GetStockItemsByIds", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetStockItemsByIdsResponse>(response);
		}

		/// <summary>
        /// Returns a list of Stock Items for the provided key and location 
        /// </summary>
        /// <param name="stockIdentifier">Made up of a string key, used to search Item Number, Barcode Number, Supplier Code and Supplier Basrcode Fields as well as Stock Location.</param>
        /// <returns>A list of Stock Items</returns>
        public List<StockItem> GetStockItemsByKey(Search_Stock_ByKey stockIdentifier)
		{
			var response = GetResponse("Stock/GetStockItemsByKey", "stockIdentifier=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(stockIdentifier)) + "");
            return JsonFormatter.ConvertFromJson<List<StockItem>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item stock scrap stat" 
        /// </summary>
        /// <param name="stockItemId">Used to specify report stock item id</param>
        /// <returns>List of StockItemScrap</returns>
        public List<StockItemScrap> GetStockItemScrapStat(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockItemScrapStat", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemScrap>>(response);
		}

		/// <summary>
        /// Used to get inventory information at a basic level 
        /// </summary>
        /// <param name="keyword">Your seearch term</param>
        /// <param name="loadCompositeParents">Whether you want to load composite parents or ignore them</param>
        /// <param name="loadVariationParents">Whether you want to load variation parents</param>
        /// <param name="entriesPerPage">The amount of entries you require. Maximum 200.</param>
        /// <param name="pageNumber">The current page number you are requesting</param>
        /// <param name="dataRequirements">The data you require. eg. StockLevels will load the stock levels for each location</param>
        /// <param name="searchTypes">The parameters that you would like to search by</param>
        public List<StockItemFull> GetStockItemsFull(String keyword,Boolean loadCompositeParents,Boolean loadVariationParents,Int32 entriesPerPage,Int32 pageNumber,List<StockInformationDataRequirement> dataRequirements,List<StockInformationSearchType> searchTypes)
		{
			var response = GetResponse("Stock/GetStockItemsFull", "keyword=" + System.Net.WebUtility.UrlEncode(keyword) + "&loadCompositeParents=" + loadCompositeParents + "&loadVariationParents=" + loadVariationParents + "&entriesPerPage=" + entriesPerPage + "&pageNumber=" + pageNumber + "&dataRequirements=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(dataRequirements)) + "&searchTypes=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(searchTypes)) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemFull>>(response);
		}

		/// <summary>
        /// Used to get inventory item information at a basic level from ids. 
        /// </summary>
        /// <param name="request">Object with a list of pkStockItemIds and Data Requirements</param>
        /// <returns>Object with StockItemsFullExtendedByIds</returns>
        public GetStockItemsFullByIdsResponse GetStockItemsFullByIds(GetStockItemsFullByIdsRequest request)
		{
			var response = GetResponse("Stock/GetStockItemsFullByIds", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetStockItemsFullByIdsResponse>(response);
		}

		public GetStockItemTypeInfoResponse GetStockItemTypeInfo(GetStockItemTypeInfoRequest request)
		{
			var response = GetResponse("Stock/GetStockItemTypeInfo", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetStockItemTypeInfoResponse>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item stock level" 
        /// </summary>
        /// <param name="stockItemId">Used to specify stock item id</param>
        /// <returns>List of StockItemLevel</returns>
        public List<StockItemLevel> GetStockLevel(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockLevel", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLevel>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item stock level" 
        /// </summary>
        /// <param name="request">Method request parameters</param>
        /// <returns>List of StockItemLevel</returns>
        public List<GetStockLevel_BatchResponse> GetStockLevel_Batch(GetStockLevel_BatchRequest request)
		{
			var response = GetResponse("Stock/GetStockLevel_Batch", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<List<GetStockLevel_BatchResponse>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item stock level" 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>StockItemLevel</returns>
        public GetStockLevelByLocationResponse GetStockLevelByLocation(GetStockLevelByLocationRequest request)
		{
			var response = GetResponse("Stock/GetStockLevelByLocation", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetStockLevelByLocationResponse>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item stock sold" 
        /// </summary>
        /// <param name="stockItemId">Used to specify report stock item id</param>
        /// <returns>List of StockItemSold</returns>
        public List<StockItemSold> GetStockSold(Guid stockItemId)
		{
			var response = GetResponse("Stock/GetStockSold", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemSold>>(response);
		}

		/// <summary>
        /// Use this call to search for a variation group by the group name 
        /// </summary>
        /// <param name="variationName">The group name to search by</param>
        /// <returns>A variation group object</returns>
        public VariationGroup GetVariationGroupByName(String variationName)
		{
			var response = GetResponse("Stock/GetVariationGroupByName", "variationName=" + System.Net.WebUtility.UrlEncode(variationName) + "");
            return JsonFormatter.ConvertFromJson<VariationGroup>(response);
		}

		/// <summary>
        /// Use this call to search for a variation group by the parent SKU's stock item id 
        /// </summary>
        /// <param name="pkStockItemId">The stock item id to search by</param>
        /// <returns>A variation group object</returns>
        public VariationGroup GetVariationGroupByParentId(Guid pkStockItemId)
		{
			var response = GetResponse("Stock/GetVariationGroupByParentId", "pkStockItemId=" + pkStockItemId + "");
            return JsonFormatter.ConvertFromJson<VariationGroup>(response);
		}

		/// <summary>
        /// Use this call to retrieve a list of the search types for searching for variation groups 
        /// </summary>
        /// <returns>A list of search types</returns>
        public List<GenericEnumDescriptor> GetVariationGroupSearchTypes()
		{
			var response = GetResponse("Stock/GetVariationGroupSearchTypes", "");
            return JsonFormatter.ConvertFromJson<List<GenericEnumDescriptor>>(response);
		}

		/// <summary>
        /// Use this call to retrieve the items in this variation 
        /// </summary>
        /// <param name="pkVariationItemId">The variation item id</param>
        /// <returns>A list of items</returns>
        public List<VariationItem> GetVariationItems(Guid pkVariationItemId)
		{
			var response = GetResponse("Stock/GetVariationItems", "pkVariationItemId=" + pkVariationItemId + "");
            return JsonFormatter.ConvertFromJson<List<VariationItem>>(response);
		}

		/// <summary>
        /// Use this call to rename a variation group 
        /// </summary>
        /// <param name="pkVariationItemId">The id of the group to rename</param>
        /// <param name="variationName">The name of the variation</param>
        public void RenameVariationGroup(Guid pkVariationItemId,String variationName)
		{
			GetResponse("Stock/RenameVariationGroup", "pkVariationItemId=" + pkVariationItemId + "&variationName=" + System.Net.WebUtility.UrlEncode(variationName) + "");
		}

		/// <summary>
        /// Use this call to search for a variation group 
        /// </summary>
        /// <param name="searchType">The search method to use</param>
        /// <param name="searchText">The search term (either in part of full)</param>
        /// <param name="pageNumber">The page number (e.g. 1).</param>
        /// <param name="entriesPerPage">The number of entries to return per page.</param>
        /// <returns>A paged list of search results</returns>
        public GenericPagedResult<VariationGroup> SearchVariationGroups(VariationSearchType searchType,String searchText,Int32 pageNumber,Int32 entriesPerPage)
		{
			var response = GetResponse("Stock/SearchVariationGroups", "searchType=" + searchType.ToString() + "&searchText=" + System.Net.WebUtility.UrlEncode(searchText) + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "");
            return JsonFormatter.ConvertFromJson<GenericPagedResult<VariationGroup>>(response);
		}

		/// <summary>
        /// Set the stock level of a list of stock items identified by its SKU to the value provided 
        /// </summary>
        /// <param name="stockLevels">The new stock items levels to set</param>
        /// <param name="changeSource"></param>
        /// <returns>Returns StockItemLevel object</returns>
        public List<StockItemLevel> SetStockLevel(List<StockLevelUpdate> stockLevels,String changeSource = null)
		{
			var response = GetResponse("Stock/SetStockLevel", "stockLevels=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(stockLevels)) + "&changeSource=" + System.Net.WebUtility.UrlEncode(changeSource) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLevel>>(response);
		}

		/// <summary>
        /// Use this call to check if a SKU exists within Linnworks. 
        /// </summary>
        /// <param name="SKU">The SKU you want to check exists.</param>
        /// <returns>True if the SKU exists or False if it does not.</returns>
        public Boolean SKUExists(String SKU)
		{
			var response = GetResponse("Stock/SKUExists", "SKU=" + System.Net.WebUtility.UrlEncode(SKU) + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <summary>
        /// Updates specified fields in the stockitem object. 
        /// </summary>
        /// <param name="update">Contains the StockItemId along with a list of parameters</param>
        public void Update_StockItemPartial(PartialUpdateParameter update)
		{
			GetResponse("Stock/Update_StockItemPartial", "update=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(update)) + "");
		}

		public UpdateSkuGroupIdentifierResponse UpdateSkuGroupIdentifier(UpdateSkuGroupIdentifierRequest request)
		{
			var response = GetResponse("Stock/UpdateSkuGroupIdentifier", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<UpdateSkuGroupIdentifierResponse>(response);
		}

		/// <summary>
        /// Allows the change of non batched / composite stock levels in build. Accepts either StockItemId or SKU and Stock location name or id 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns StockItemLevel object</returns>
        public UpdateStockLevelsBulkResponse UpdateStockLevelsBulk(UpdateStockLevelsBulkRequest request)
		{
			var response = GetResponse("Stock/UpdateStockLevelsBulk", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<UpdateStockLevelsBulkResponse>(response);
		}

		/// <summary>
        /// Change the stock level of a list of stock items by the provided value 
        /// </summary>
        /// <param name="stockLevels">The new stock items levels to adjust</param>
        /// <param name="changeSource"></param>
        /// <returns>Returns StockItemLevel object</returns>
        public List<StockItemLevel> UpdateStockLevelsBySKU(List<StockLevelUpdate> stockLevels,String changeSource = null)
		{
			var response = GetResponse("Stock/UpdateStockLevelsBySKU", "stockLevels=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(stockLevels)) + "&changeSource=" + System.Net.WebUtility.UrlEncode(changeSource) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLevel>>(response);
		}

		/// <summary>
        /// Use this call to update stock minimum level 
        /// </summary>
        /// <param name="stockItemId">stockItemId</param>
        /// <param name="locationId">locationId</param>
        /// <param name="minimumLevel">minimumLevel</param>
        public void UpdateStockMinimumLevel(Guid stockItemId,Guid locationId,Int32 minimumLevel)
		{
			GetResponse("Stock/UpdateStockMinimumLevel", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&minimumLevel=" + minimumLevel + "");
		} 
    }
}