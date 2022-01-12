using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class InventoryController : BaseController, IInventoryController
    {
        public InventoryController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Adds an image to the stock item 
        /// </summary>
        /// <param name="request">Add Image object</param>
        public AddImageToInventoryItemResponse AddImageToInventoryItem(AddImageToInventoryItemRequest request)
		{
			var response = GetResponse("Inventory/AddImageToInventoryItem", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AddImageToInventoryItemResponse>(response);
		}

		/// <summary>
        /// Use this call to add stock item. 
        /// </summary>
        /// <param name="inventoryItem">New StockItem</param>
        public void AddInventoryItem(StockItem inventoryItem)
		{
			GetResponse("Inventory/AddInventoryItem", "inventoryItem=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItem)) + "");
		}

		/// <summary>
        /// Use this call to add stock item locations bin/rack 
        /// </summary>
        /// <param name="itemLocations">List of stock item locations</param>
        public void AddItemLocations(List<StockItemLocation> itemLocations)
		{
			GetResponse("Inventory/AddItemLocations", "itemLocations=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(itemLocations)) + "");
		}

		/// <summary>
        /// Used to add product identifiers 
        /// </summary>
        /// <param name="request">Object with collection of product identifiers</param>
        public void AddProductIdentifiers(AddProductIdentifiersRequest request)
		{
			GetResponse("Inventory/AddProductIdentifiers", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Used to add scrap categories 
        /// </summary>
        /// <param name="request">Object with List of scrap category names</param>
        public AddScrapCategoriesResponse AddScrapCategories(AddScrapCategoriesRequest request)
		{
			var response = GetResponse("Inventory/AddScrapCategories", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AddScrapCategoriesResponse>(response);
		}

		/// <summary>
        /// Used to add scrap item 
        /// </summary>
        public AddScrapItemResponse AddScrapItem(AddScrapItemRequest request)
		{
			var response = GetResponse("Inventory/AddScrapItem", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<AddScrapItemResponse>(response);
		}

		/// <summary>
        /// Use this call to create a new supplier 
        /// </summary>
        /// <param name="supplier">Details of supplier to be added. Set pkSupplierId to a new uniqueidentifier</param>
        public Supplier AddSupplier(Supplier supplier)
		{
			var response = GetResponse("Inventory/AddSupplier", "supplier=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(supplier)) + "");
            return JsonFormatter.ConvertFromJson<Supplier>(response);
		}

		/// <summary>
        /// Use this call to create LMS Update for dispatch time only (Mr Auto) 
        /// </summary>
        /// <param name="inventoryItemIds">Inventory item ids</param>
        /// <param name="subSource">Channel Name</param>
        /// <param name="siteId">Ebay Site to adjust N.B this is not currently used</param>
        /// <param name="adjustmentOptions">Fields which should be adjusted</param>
        public void AdjustEbayTemplatesDispatchLMS(IEnumerable<Guid> inventoryItemIds,String subSource,String siteId,AdjustmentOptions adjustmentOptions)
		{
			GetResponse("Inventory/AdjustEbayTemplatesDispatchLMS", "inventoryItemIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemIds)) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "&siteId=" + System.Net.WebUtility.UrlEncode(siteId) + "&adjustmentOptions=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(adjustmentOptions)) + "");
		}

		/// <summary>
        /// Use this call to create LMS Update (Only works for fixed price templates) 
        /// </summary>
        /// <param name="inventoryItemIds">Inventory item ids</param>
        /// <param name="subSource">Channel Name</param>
        /// <param name="siteId">Ebay Site to adjust N.B this is not currently used</param>
        /// <param name="adjustmentOptions">Fields which should be adjusted</param>
        public void AdjustEbayTemplatesInstantLMS(IEnumerable<Guid> inventoryItemIds,String subSource,String siteId,AdjustmentOptions adjustmentOptions)
		{
			GetResponse("Inventory/AdjustEbayTemplatesInstantLMS", "inventoryItemIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemIds)) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "&siteId=" + System.Net.WebUtility.UrlEncode(siteId) + "&adjustmentOptions=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(adjustmentOptions)) + "");
		}

		/// <summary>
        /// Use this call to adjust templates 
        /// </summary>
        /// <param name="inventoryItemIds">Inventory item ids</param>
        /// <param name="source">Channel type ('EBAY', 'AMAZON', 'BIGCOMMERCE', 'MAGENTO')</param>
        /// <param name="subSource">Channel Name</param>
        /// <param name="adjustmentOptions">Fields which should be adjusted</param>
        public void AdjustTemplatesInstant(IEnumerable<Guid> inventoryItemIds,String source,String subSource,AdjustmentOptions adjustmentOptions)
		{
			GetResponse("Inventory/AdjustTemplatesInstant", "inventoryItemIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemIds)) + "&source=" + System.Net.WebUtility.UrlEncode(source) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "&adjustmentOptions=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(adjustmentOptions)) + "");
		}

		/// <summary>
        /// Use this call to archive inventory items. Send only list of IDs and empty list of regions. 
        /// </summary>
        /// <param name="parameters">InventoryParameters object</param>
        public void ArchiveInventoryItems(InventoryParametersRequest parameters)
		{
			GetResponse("Inventory/ArchiveInventoryItems", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
		}

		/// <summary>
        /// Use this call to get stock item channel skus for a list of inventory items 
        /// </summary>
        /// <param name="inventoryItemIds">List of Stock item Id's'</param>
        /// <returns>List for stock channel skus</returns>
        public IEnumerable<StockItemChannelSkuResponse> BatchGetInventoryItemChannelSKUs(List<Guid> inventoryItemIds)
		{
			var response = GetResponse("Inventory/BatchGetInventoryItemChannelSKUs", "inventoryItemIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemIds)) + "");
            return JsonFormatter.ConvertFromJson<IEnumerable<StockItemChannelSkuResponse>>(response);
		}

		/// <summary>
        /// Scrap batched items in bulk without consumption 
        /// </summary>
        /// <param name="request"></param>
        public void BulkScrapBatchedItems(BulkScrapBatchedItemsRequest request)
		{
			GetResponse("Inventory/BulkScrapBatchedItems", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Used to create new batches 
        /// </summary>
        /// <param name="batches">List of batches to create</param>
        public void CreateBatches(IEnumerable<StockItemBatch> batches)
		{
			GetResponse("Inventory/CreateBatches", "batches=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(batches)) + "");
		}

		/// <summary>
        /// Use this call to create new category 
        /// </summary>
        /// <param name="categoryName">Category name</param>
        /// <returns>New category</returns>
        public Category CreateCategory(String categoryName)
		{
			var response = GetResponse("Inventory/CreateCategory", "categoryName=" + System.Net.WebUtility.UrlEncode(categoryName) + "");
            return JsonFormatter.ConvertFromJson<Category>(response);
		}

		/// <summary>
        /// Use this call to create new countries 
        /// </summary>
        /// <param name="countries">Countries to create</param>
        public void CreateCountries(IEnumerable<Country> countries)
		{
			GetResponse("Inventory/CreateCountries", "countries=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(countries)) + "");
		}

		/// <summary>
        /// Create regions for country 
        /// </summary>
        /// <param name="request">Country regions to create</param>
        public CreateCountryRegionsResponse CreateCountryRegions(CreateCountryRegionsRequest request)
		{
			var response = GetResponse("Inventory/CreateCountryRegions", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<CreateCountryRegionsResponse>(response);
		}

		/// <summary>
        /// Use this call to create stockitem channel skus 
        /// </summary>
        /// <param name="inventoryItemChannelSKUs">stockitem channel skus</param>
        public void CreateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs)
		{
			GetResponse("Inventory/CreateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemChannelSKUs)) + "");
		}

		/// <summary>
        /// Use this call to create compositions for stockItem 
        /// </summary>
        /// <param name="inventoryItemCompositions">stockItem compositions</param>
        public void CreateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions)
		{
			GetResponse("Inventory/CreateInventoryItemCompositions", "inventoryItemCompositions=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemCompositions)) + "");
		}

		/// <summary>
        /// Use this call to create stockitem Descriptions 
        /// </summary>
        /// <param name="inventoryItemDescriptions">list of stockitem Descriptions</param>
        public void CreateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions)
		{
			GetResponse("Inventory/CreateInventoryItemDescriptions", "inventoryItemDescriptions=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemDescriptions)) + "");
		}

		/// <summary>
        /// Use this call to create stockitem Extended Properties 
        /// </summary>
        /// <param name="inventoryItemExtendedProperties">list of stockitem Extended Properties</param>
        public void CreateInventoryItemExtendedProperties(List<StockItemExtendedPropertyUpsertItem> inventoryItemExtendedProperties)
		{
			GetResponse("Inventory/CreateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemExtendedProperties)) + "");
		}

		/// <summary>
        /// Use this call to create stock item prices for a specific channel 
        /// </summary>
        /// <param name="inventoryItemPrices">List of stock item prices to create</param>
        public void CreateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices)
		{
			GetResponse("Inventory/CreateInventoryItemPrices", "inventoryItemPrices=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemPrices)) + "");
		}

		/// <summary>
        /// Use this call to create stock item price rules 
        /// </summary>
        /// <param name="rules">List of stock item pricing rules</param>
        public void CreateInventoryItemPricingRules(List<StockItemPricingRule> rules)
		{
			GetResponse("Inventory/CreateInventoryItemPricingRules", "rules=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(rules)) + "");
		}

		/// <summary>
        /// Use this call to create stockitem Titles 
        /// </summary>
        /// <param name="inventoryItemTitles">list of stockitem Titles</param>
        public void CreateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles)
		{
			GetResponse("Inventory/CreateInventoryItemTitles", "inventoryItemTitles=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemTitles)) + "");
		}

		/// <summary>
        /// Use this call to create item supplier stat 
        /// </summary>
        /// <param name="itemSuppliers">List of StockItemSupplierStat</param>
        public void CreateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers)
		{
			GetResponse("Inventory/CreateStockSupplierStat", "itemSuppliers=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(itemSuppliers)) + "");
		}

		/// <summary>
        /// Use this call to create a new user-specific view 
        /// </summary>
        /// <param name="view">New user-specific view</param>
        public void CreateUserSpecificView(InventoryView view)
		{
			GetResponse("Inventory/CreateUserSpecificView", "view=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(view)) + "");
		}

		/// <summary>
        /// Used to delete batches by stock item id 
        /// </summary>
        /// <param name="stockItemId">Stock item unique identifier</param>
        public void DeleteBatchesByStockItemId(Guid stockItemId)
		{
			GetResponse("Inventory/DeleteBatchesByStockItemId", "stockItemId=" + stockItemId + "");
		}

		/// <summary>
        /// Used to delete batch inventory info 
        /// </summary>
        /// <param name="batchInventoryIds">List of batch inventory ids</param>
        public void DeleteBatchInventoryInBulk(IEnumerable<Int32> batchInventoryIds)
		{
			GetResponse("Inventory/DeleteBatchInventoryInBulk", "batchInventoryIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(batchInventoryIds)) + "");
		}

		/// <summary>
        /// Use this call to delete category by id. 
        /// </summary>
        /// <param name="categoryId">Unique id that identifies the category that you want to delete.</param>
        public void DeleteCategoryById(Guid categoryId)
		{
			GetResponse("Inventory/DeleteCategoryById", "categoryId=" + categoryId + "");
		}

		/// <summary>
        /// Use this call to delete countries 
        /// </summary>
        /// <param name="countriesIds">Ids of countries to delete</param>
        public void DeleteCountries(IEnumerable<Guid> countriesIds)
		{
			GetResponse("Inventory/DeleteCountries", "countriesIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(countriesIds)) + "");
		}

		/// <summary>
        /// Use this call to delete a list of Ebay Compatibility 
        /// </summary>
        /// <param name="request">List of Ebay Compatibility</param>
        public DeleteEbayCompatibilityListResponse DeleteEbayCompatibilityList(DeleteEbayCompatibilityListRequest request)
		{
			var response = GetResponse("Inventory/DeleteEbayCompatibilityList", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<DeleteEbayCompatibilityListResponse>(response);
		}

		/// <summary>
        /// Use this call to delete images from inventory items 
        /// </summary>
        /// <param name="inventoryItemImages">Inventory item ids and a list of image urls to be deleted for each item</param>
        public void DeleteImagesFromInventoryItem(Dictionary<Guid,List<String>> inventoryItemImages)
		{
			GetResponse("Inventory/DeleteImagesFromInventoryItem", "inventoryItemImages=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemImages)) + "");
		}

		/// <summary>
        /// Use this call to delete stockitem channel skus 
        /// </summary>
        /// <param name="inventoryItemChannelSKUIds">stockitem channel sku ids</param>
        public void DeleteInventoryItemChannelSKUs(List<Guid> inventoryItemChannelSKUIds)
		{
			GetResponse("Inventory/DeleteInventoryItemChannelSKUs", "inventoryItemChannelSKUIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemChannelSKUIds)) + "");
		}

		/// <summary>
        /// Use this call to delete stockItem compositions 
        /// </summary>
        /// <param name="stockItemId">Id of StockItem</param>
        /// <param name="inventoryItemCompositionIds">stockItem composition ids</param>
        public void DeleteInventoryItemCompositions(Guid stockItemId,List<Guid> inventoryItemCompositionIds)
		{
			GetResponse("Inventory/DeleteInventoryItemCompositions", "stockItemId=" + stockItemId + "&inventoryItemCompositionIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemCompositionIds)) + "");
		}

		/// <summary>
        /// Use this call to delete stockitem Descriptions 
        /// </summary>
        /// <param name="inventoryItemDescriptionIds">list of stockitem Descriptions</param>
        public void DeleteInventoryItemDescriptions(List<Guid> inventoryItemDescriptionIds)
		{
			GetResponse("Inventory/DeleteInventoryItemDescriptions", "inventoryItemDescriptionIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemDescriptionIds)) + "");
		}

		/// <summary>
        /// Use this call to delete stockitem Extended Properties 
        /// </summary>
        /// <param name="inventoryItemId">Id of StockItem</param>
        /// <param name="inventoryItemExtendedPropertyIds">list of stockitem Extended Properties</param>
        public void DeleteInventoryItemExtendedProperties(Guid inventoryItemId,List<Guid> inventoryItemExtendedPropertyIds)
		{
			GetResponse("Inventory/DeleteInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&inventoryItemExtendedPropertyIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemExtendedPropertyIds)) + "");
		}

		/// <summary>
        /// Use this call to delete stock item prices 
        /// </summary>
        /// <param name="inventoryItemPriceIds">List of stock item prices</param>
        public void DeleteInventoryItemPrices(List<Guid> inventoryItemPriceIds)
		{
			GetResponse("Inventory/DeleteInventoryItemPrices", "inventoryItemPriceIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemPriceIds)) + "");
		}

		/// <summary>
        /// Use this call to update stock item price rules 
        /// </summary>
        /// <param name="pricingRuleIds">List of stock item pricing rule ids to delete</param>
        public void DeleteInventoryItemPricingRules(List<Int32> pricingRuleIds)
		{
			GetResponse("Inventory/DeleteInventoryItemPricingRules", "pricingRuleIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(pricingRuleIds)) + "");
		}

		/// <summary>
        /// Use this call to delete inventory item.
        /// All associated information will be unlinked/removed from this stock item. 
        /// </summary>
        /// <param name="request">Do not send this parameter</param>
        /// <param name="inventoryItemIds">List of stock item IDs that needs to be deleted</param>
        public void DeleteInventoryItems(DeleteInventoryItemsRequest request,List<Guid> inventoryItemIds)
		{
			GetResponse("Inventory/DeleteInventoryItems", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "&inventoryItemIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemIds)) + "");
		}

		/// <summary>
        /// Use this call to delete stockitem Titles 
        /// </summary>
        /// <param name="inventoryItemTitleIds">list of stockitem Titles</param>
        public void DeleteInventoryItemTitles(List<Guid> inventoryItemTitleIds)
		{
			GetResponse("Inventory/DeleteInventoryItemTitles", "inventoryItemTitleIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemTitleIds)) + "");
		}

		/// <summary>
        /// Use this call to delete stock item locations bin/rack 
        /// </summary>
        /// <param name="inventoryItemId">Id of StockItem</param>
        /// <param name="itemLocations">List of stock item location ids</param>
        public void DeleteItemLocations(Guid inventoryItemId,List<Guid> itemLocations)
		{
			GetResponse("Inventory/DeleteItemLocations", "inventoryItemId=" + inventoryItemId + "&itemLocations=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(itemLocations)) + "");
		}

		/// <summary>
        /// Used to delete product identifiers 
        /// </summary>
        /// <param name="request">Object with collection of product identifiers</param>
        public void DeleteProductIdentifiers(DeleteProductIdentifiersRequest request)
		{
			GetResponse("Inventory/DeleteProductIdentifiers", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Used to delete scrap categories 
        /// </summary>
        /// <param name="request">Object with List of scrap category ids</param>
        public void DeleteScrapCategories(DeleteScrapCategoriesRequest request)
		{
			GetResponse("Inventory/DeleteScrapCategories", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Use this call to delete item supplier stat 
        /// </summary>
        /// <param name="stockItemId">Id of StockItem</param>
        /// <param name="itemSupplierIds">List of StockItemSupplierStat</param>
        public void DeleteStockSupplierStat(Guid stockItemId,List<Guid> itemSupplierIds)
		{
			GetResponse("Inventory/DeleteStockSupplierStat", "stockItemId=" + stockItemId + "&itemSupplierIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(itemSupplierIds)) + "");
		}

		/// <summary>
        /// Use this call delete Supplied by Id
        /// List of Supplier IDs 
        /// </summary>
        public void DeleteSuppliers(List<Guid> suppliersIds)
		{
			GetResponse("Inventory/DeleteSuppliers", "suppliersIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(suppliersIds)) + "");
		}

		/// <summary>
        /// Use this call to delete user-specific view from database 
        /// </summary>
        /// <param name="viewName">User-specific view name</param>
        public void DeleteUserSpecificView(String viewName)
		{
			GetResponse("Inventory/DeleteUserSpecificView", "viewName=" + System.Net.WebUtility.UrlEncode(viewName) + "");
		}

		/// <summary>
        /// Use this call to add stock item by duplicating existing one 
        /// </summary>
        /// <param name="inventoryItem">New StockItem</param>
        /// <param name="sourceItemId">Source StockItem</param>
        /// <param name="copyImages">Set to True to copy images from source stock item</param>
        public void DuplicateInventoryItem(StockItem inventoryItem,Guid sourceItemId,Boolean copyImages)
		{
			GetResponse("Inventory/DuplicateInventoryItem", "inventoryItem=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItem)) + "&sourceItemId=" + sourceItemId + "&copyImages=" + copyImages + "");
		}

		/// <summary>
        /// Use this call to get extended properties for all types 
        /// </summary>
        public Dictionary<String,List<String>> GetAllExtendedPropertyNames()
		{
			var response = GetResponse("Inventory/GetAllExtendedPropertyNames", "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,List<String>>>(response);
		}

		/// <summary>
        /// Get audit trail for batches 
        /// </summary>
        /// <param name="request"></param>
        public GetBatchAuditResponse GetBatchAudit(GetBatchAuditRequest request)
		{
			var response = GetResponse("Inventory/GetBatchAudit", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetBatchAuditResponse>(response);
		}

		/// <summary>
        /// Used to get batch info for stock item for all locations 
        /// </summary>
        /// <param name="stockItemId">Item id</param>
        /// <param name="onlyAvailable">If true, only available batches will be returned</param>
        /// <param name="stockLocationId"></param>
        public List<StockItemBatch> GetBatchesByStockItemId(Guid stockItemId,Boolean onlyAvailable,Guid? stockLocationId = null)
		{
			var response = GetResponse("Inventory/GetBatchesByStockItemId", "stockItemId=" + stockItemId + "&onlyAvailable=" + onlyAvailable + "&stockLocationId=" + stockLocationId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemBatch>>(response);
		}

		/// <summary>
        /// Retruns batch header and only batch inventory for provided batch 
        /// </summary>
        /// <param name="request"></param>
        public GetBatchInventoryByIdResponse GetBatchInventoryById(GetBatchInventoryByIdRequest request)
		{
			var response = GetResponse("Inventory/GetBatchInventoryById", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetBatchInventoryByIdResponse>(response);
		}

		/// <summary>
        /// Use this call to get categories 
        /// </summary>
        /// <returns>List of categories</returns>
        public List<Category> GetCategories()
		{
			var response = GetResponse("Inventory/GetCategories", "");
            return JsonFormatter.ConvertFromJson<List<Category>>(response);
		}

		/// <summary>
        /// Use this call to get all channels 
        /// </summary>
        public List<AnyConfig> GetChannels()
		{
			var response = GetResponse("Inventory/GetChannels", "");
            return JsonFormatter.ConvertFromJson<List<AnyConfig>>(response);
		}

		/// <summary>
        /// Use this call to get channels by source 
        /// </summary>
        /// <param name="source">Channel source</param>
        public List<HeaderConfig> GetChannelsBySource(String source)
		{
			var response = GetResponse("Inventory/GetChannelsBySource", "source=" + System.Net.WebUtility.UrlEncode(source) + "");
            return JsonFormatter.ConvertFromJson<List<HeaderConfig>>(response);
		}

		/// <summary>
        /// Use this call to get list of all countries 
        /// </summary>
        /// <returns>List of all countries</returns>
        public IEnumerable<Country> GetCountries()
		{
			var response = GetResponse("Inventory/GetCountries", "");
            return JsonFormatter.ConvertFromJson<IEnumerable<Country>>(response);
		}

		/// <summary>
        /// Use this call to get all country codes from ebay channel 
        /// </summary>
        public Dictionary<String,String> GetCountryCodes()
		{
			var response = GetResponse("Inventory/GetCountryCodes", "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,String>>(response);
		}

		/// <summary>
        /// Use this call to get a list of Ebay Compatibility 
        /// </summary>
        /// <param name="stockItemId">Stock Item Id</param>
        /// <returns>List of Ebay Compatibility</returns>
        public List<StockItemEbayCompatibility> GetEbayCompatibilityList(Guid stockItemId)
		{
			var response = GetResponse("Inventory/GetEbayCompatibilityList", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemEbayCompatibility>>(response);
		}

		/// <summary>
        /// Use this call to get all available extended property names 
        /// </summary>
        /// <returns>list of available extended property names</returns>
        public List<String> GetExtendedPropertyNames(String propertyType = "Attribute")
		{
			var response = GetResponse("Inventory/GetExtendedPropertyNames", "propertyType=" + System.Net.WebUtility.UrlEncode(propertyType) + "");
            return JsonFormatter.ConvertFromJson<List<String>>(response);
		}

		/// <summary>
        /// Use this call to get default extended property types 
        /// </summary>
        /// <returns>list of default extended property types</returns>
        public List<String> GetExtendedPropertyTypes()
		{
			var response = GetResponse("Inventory/GetExtendedPropertyTypes", "");
            return JsonFormatter.ConvertFromJson<List<String>>(response);
		}

		/// <summary>
        /// Use this call to Get inventory item images 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>list of inventory item images</returns>
        public GetImagesInBulkResponse GetImagesInBulk(GetImagesInBulkRequest request)
		{
			var response = GetResponse("Inventory/GetImagesInBulk", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetImagesInBulkResponse>(response);
		}

		/// <summary>
        /// Use this call to get available inventory batch types 
        /// </summary>
        /// <returns>Dictionary of inventory batch types</returns>
        public Dictionary<String,Byte> GetInventoryBatchTypes()
		{
			var response = GetResponse("Inventory/GetInventoryBatchTypes", "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,Byte>>(response);
		}

		/// <summary>
        /// Use this call to get StockItem AuditTrail 
        /// </summary>
        /// <param name="inventoryItemId">StockItem unique identifier</param>
        /// <returns>StockItem AuditTrail</returns>
        public List<StockItemAuditTrail> GetInventoryItemAuditTrail(Guid inventoryItemId)
		{
			var response = GetResponse("Inventory/GetInventoryItemAuditTrail", "inventoryItemId=" + inventoryItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemAuditTrail>>(response);
		}

		/// <summary>
        /// Used to get the batch information of a specific item 
        /// </summary>
        /// <param name="Request">Details for the batch to be fetched</param>
        public List<StockItemBatch> GetInventoryItemBatchInformation(GetInventoryItemBatchInformationRequest Request)
		{
			var response = GetResponse("Inventory/GetInventoryItemBatchInformation", "Request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(Request)) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemBatch>>(response);
		}

		public GetInventoryItemBatchInformationByIdsResponse GetInventoryItemBatchInformationByIds(GetInventoryItemBatchInformationByIdsRequest request)
		{
			var response = GetResponse("Inventory/GetInventoryItemBatchInformationByIds", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetInventoryItemBatchInformationByIdsResponse>(response);
		}

		/// <summary>
        /// Use this call to get all product details 
        /// </summary>
        /// <param name="id"></param>
        public StockItemInv GetInventoryItemById(Guid id)
		{
			var response = GetResponse("Inventory/GetInventoryItemById", "id=" + id + "");
            return JsonFormatter.ConvertFromJson<StockItemInv>(response);
		}

		/// <summary>
        /// Use this call to get stockitem channel skus 
        /// </summary>
        /// <param name="inventoryItemId">stockitem id</param>
        /// <returns>List for stock channel skus</returns>
        public List<StockItemChannelSKU> GetInventoryItemChannelSKUs(Guid inventoryItemId)
		{
			var response = GetResponse("Inventory/GetInventoryItemChannelSKUs", "inventoryItemId=" + inventoryItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemChannelSKU>>(response);
		}

		/// <summary>
        /// Use this call to retrieve all stock item channel sku's with location for a given channel sku RowId 
        /// </summary>
        /// <param name="channelSKURowId">ChannelSKU record Id</param>
        public List<StockItemChannelSKUWithLocation> GetInventoryItemChannelSKUsWithLocation(Guid channelSKURowId)
		{
			var response = GetResponse("Inventory/GetInventoryItemChannelSKUsWithLocation", "channelSKURowId=" + channelSKURowId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemChannelSKUWithLocation>>(response);
		}

		/// <summary>
        /// Use this call to get all StockItem Compositions 
        /// </summary>
        /// <param name="inventoryItemId">Id of StockItem</param>
        /// <param name="getFullDetail">Indicate if the method has to be recursive, going throw inner composites, getting only real items</param>
        /// <returns>List of StockItem Compositions</returns>
        public List<StockItemComposition> GetInventoryItemCompositions(Guid inventoryItemId,Boolean getFullDetail = false)
		{
			var response = GetResponse("Inventory/GetInventoryItemCompositions", "inventoryItemId=" + inventoryItemId + "&getFullDetail=" + getFullDetail + "");
            return JsonFormatter.ConvertFromJson<List<StockItemComposition>>(response);
		}

		/// <summary>
        /// Use this call to get stockitem Descriptions 
        /// </summary>
        /// <param name="inventoryItemId">stockitem id</param>
        /// <returns>list of stockitem Descriptions</returns>
        public List<StockItemDescription> GetInventoryItemDescriptions(Guid inventoryItemId)
		{
			var response = GetResponse("Inventory/GetInventoryItemDescriptions", "inventoryItemId=" + inventoryItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemDescription>>(response);
		}

		/// <summary>
        /// Use this call to get stockitem Extended Properties 
        /// </summary>
        /// <param name="inventoryItemId">stockitem id</param>
        /// <param name="propertyParams">Optional parameters to look for specific PropertyName and PropertyType</param>
        /// <returns>list of stockitem Extended Properties</returns>
        public List<StockItemExtendedProperty> GetInventoryItemExtendedProperties(Guid inventoryItemId,GetExtendedPropertyFilter propertyParams)
		{
			var response = GetResponse("Inventory/GetInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&propertyParams=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(propertyParams)) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemExtendedProperty>>(response);
		}

		/// <summary>
        /// Use this call to Get inventory item images 
        /// </summary>
        /// <param name="inventoryItemId">Id of StockItem</param>
        /// <returns>list of inventory item images</returns>
        public List<StockItemImage> GetInventoryItemImages(Guid inventoryItemId)
		{
			var response = GetResponse("Inventory/GetInventoryItemImages", "inventoryItemId=" + inventoryItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemImage>>(response);
		}

		/// <summary>
        /// Use this call to get stock item locations bin/rack 
        /// </summary>
        /// <param name="inventoryItemId">Stock item ID</param>
        /// <returns>List of stock item locations</returns>
        public List<StockItemLocation> GetInventoryItemLocations(Guid inventoryItemId)
		{
			var response = GetResponse("Inventory/GetInventoryItemLocations", "inventoryItemId=" + inventoryItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLocation>>(response);
		}

		/// <summary>
        /// Use this call to get all possible price change subsource suffices for all channels 
        /// </summary>
        public Dictionary<String,List<String>> GetInventoryItemPriceChannelSuffixes()
		{
			var response = GetResponse("Inventory/GetInventoryItemPriceChannelSuffixes", "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,List<String>>>(response);
		}

		/// <summary>
        /// Use this call to get stock item price rules by price id 
        /// </summary>
        /// <param name="stockItemPriceId">Price ID of an item</param>
        public List<StockItemPricingRule> GetInventoryItemPriceRulesById(Guid stockItemPriceId)
		{
			var response = GetResponse("Inventory/GetInventoryItemPriceRulesById", "stockItemPriceId=" + stockItemPriceId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemPricingRule>>(response);
		}

		/// <summary>
        /// Use this call to get stock item price rules by item id, source and subsource 
        /// </summary>
        /// <param name="stockItemId">Stock item id</param>
        /// <param name="source">Channel source</param>
        /// <param name="subSource">Channel subsource</param>
        public List<StockItemPricingRule> GetInventoryItemPriceRulesBySource(Guid stockItemId,String source,String subSource)
		{
			var response = GetResponse("Inventory/GetInventoryItemPriceRulesBySource", "stockItemId=" + stockItemId + "&source=" + System.Net.WebUtility.UrlEncode(source) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "");
            return JsonFormatter.ConvertFromJson<List<StockItemPricingRule>>(response);
		}

		/// <summary>
        /// Use this call to get stock item prices by channel 
        /// </summary>
        /// <param name="inventoryItemId">Stock item id</param>
        /// <returns>List of stock item prices</returns>
        public List<StockItemPrice> GetInventoryItemPrices(Guid inventoryItemId)
		{
			var response = GetResponse("Inventory/GetInventoryItemPrices", "inventoryItemId=" + inventoryItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemPrice>>(response);
		}

		/// <summary>
        /// Use this call to get all possible price change tags for all channels 
        /// </summary>
        public Dictionary<String,List<String>> GetInventoryItemPriceTags()
		{
			var response = GetResponse("Inventory/GetInventoryItemPriceTags", "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,List<String>>>(response);
		}

		/// <summary>
        /// Use this call to get all StockItem Compositions 
        /// </summary>
        /// <param name="request">Object with InventoryItemIds</param>
        /// <returns>Object with InventoryItemsCompositionByIds</returns>
        public GetInventoryItemsCompositionByIdsResponse GetInventoryItemsCompositionByIds(GetInventoryItemsCompositionByIdsRequest request)
		{
			var response = GetResponse("Inventory/GetInventoryItemsCompositionByIds", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetInventoryItemsCompositionByIdsResponse>(response);
		}

		/// <summary>
        /// Use this call to get total items count 
        /// </summary>
        /// <param name="includeDeleted">Include deleted items</param>
        /// <param name="includeArchived">Include archived items</param>
        public Int32 GetInventoryItemsCount(Boolean? includeDeleted,Boolean? includeArchived)
		{
			var response = GetResponse("Inventory/GetInventoryItemsCount", "includeDeleted=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(includeDeleted)) + "&includeArchived=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(includeArchived)) + "");
            return JsonFormatter.ConvertFromJson<Int32>(response);
		}

		/// <summary>
        /// Use this call to get stockitem Titles 
        /// </summary>
        /// <param name="inventoryItemId">stockitem id</param>
        /// <returns>list of stockitem Titles</returns>
        public List<StockItemTitle> GetInventoryItemTitles(Guid inventoryItemId)
		{
			var response = GetResponse("Inventory/GetInventoryItemTitles", "inventoryItemId=" + inventoryItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemTitle>>(response);
		}

		/// <summary>
        /// Use this call to get next unused SKU 
        /// </summary>
        /// <returns>New SKU</returns>
        public String GetNewItemNumber()
		{
			var response = GetResponse("Inventory/GetNewItemNumber", "");
            return JsonFormatter.ConvertFromJson<String>(response);
		}

		/// <summary>
        /// Use this call to get all package groups 
        /// </summary>
        public IEnumerable<KeyGuidValue> GetPackageGroups()
		{
			var response = GetResponse("Inventory/GetPackageGroups", "");
            return JsonFormatter.ConvertFromJson<IEnumerable<KeyGuidValue>>(response);
		}

		/// <summary>
        /// Use this call to get all postal services 
        /// </summary>
        public List<KeyGuidValue> GetPostalServices()
		{
			var response = GetResponse("Inventory/GetPostalServices", "");
            return JsonFormatter.ConvertFromJson<List<KeyGuidValue>>(response);
		}

		/// <summary>
        /// Use this call to get pre-defined (standard) views 
        /// </summary>
        public List<InventoryView> GetPreDefinedViews()
		{
			var response = GetResponse("Inventory/GetPreDefinedViews", "");
            return JsonFormatter.ConvertFromJson<List<InventoryView>>(response);
		}

		/// <summary>
        /// Used to get product identifiers for multiple stock items 
        /// </summary>
        /// <param name="request">Object containing a list of stock item ids</param>
        public GetProductIdentifiersByStockItemIdResponse GetProductIdentifiersBulkByStockItemId(GetProductIdentifiersBulkByStockItemIdRequest request)
		{
			var response = GetResponse("Inventory/GetProductIdentifiersBulkByStockItemId", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetProductIdentifiersByStockItemIdResponse>(response);
		}

		/// <summary>
        /// Used to get product identifiers for a stock item 
        /// </summary>
        /// <param name="request">Object with StockItemId</param>
        public GetProductIdentifiersByStockItemIdResponse GetProductIdentifiersByStockItemId(GetProductIdentifiersByStockItemIdRequest request)
		{
			var response = GetResponse("Inventory/GetProductIdentifiersByStockItemId", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetProductIdentifiersByStockItemIdResponse>(response);
		}

		/// <summary>
        /// Use this call to get available Product Identifier types 
        /// </summary>
        /// <returns>Object with  Dictionary of Product Identifier types</returns>
        public GetProductIdentifierTypesRequest GetProductIdentifierTypes()
		{
			var response = GetResponse("Inventory/GetProductIdentifierTypes", "");
            return JsonFormatter.ConvertFromJson<GetProductIdentifierTypesRequest>(response);
		}

		/// <summary>
        /// Used to get scrap categories 
        /// </summary>
        public GetScrapCategoriesResponse GetScrapCategories()
		{
			var response = GetResponse("Inventory/GetScrapCategories", "");
            return JsonFormatter.ConvertFromJson<GetScrapCategoriesResponse>(response);
		}

		/// <summary>
        /// Used to get scrap history 
        /// </summary>
        public GetScrapHistoryResponse GetScrapHistory(GetScrapHistoryRequest request)
		{
			var response = GetResponse("Inventory/GetScrapHistory", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetScrapHistoryResponse>(response);
		}

		/// <summary>
        /// Used to get batch info by stock item id and location id 
        /// </summary>
        /// <param name="request">Contains Guid StockItemId, Guid LocationId, bool OnlyAvailable</param>
        public GetStockItemBatchesByLocationResponse GetStockItemBatchesByLocation(GetStockItemBatchesByLocationRequest request)
		{
			var response = GetResponse("Inventory/GetStockItemBatchesByLocation", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetStockItemBatchesByLocationResponse>(response);
		}

		/// <summary>
        /// Use this call to Get inventory item images 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>list of inventory item images</returns>
        public GetStockItemIdsBySKU GetStockItemIdsBySKU(GetStockItemIdsBySKURequest request)
		{
			var response = GetResponse("Inventory/GetStockItemIdsBySKU", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetStockItemIdsBySKU>(response);
		}

		/// <summary>
        /// Use this call to get labels by search token 
        /// </summary>
        /// <param name="selectedRegions">Row numbers to retrieve item ids for</param>
        /// <param name="token">Search Token</param>
        /// <param name="location">Location id</param>
        public List<StockItemLabel> GetStockItemLabels(List<Tuple<Int32,Int32>> selectedRegions,Guid token,Guid location)
		{
			var response = GetResponse("Inventory/GetStockItemLabels", "selectedRegions=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(selectedRegions)) + "&token=" + token + "&location=" + location + "");
            return JsonFormatter.ConvertFromJson<List<StockItemLabel>>(response);
		}

		/// <summary>
        /// Use this call to get all stock locations 
        /// </summary>
        /// <returns>List of all stock locations</returns>
        public List<InventoryStockLocation> GetStockLocations()
		{
			var response = GetResponse("Inventory/GetStockLocations", "");
            return JsonFormatter.ConvertFromJson<List<InventoryStockLocation>>(response);
		}

		/// <summary>
        /// Use this call to retrieve report about "item supplier stat" 
        /// </summary>
        /// <param name="inventoryItemId">Used to specify report stock item id</param>
        /// <returns>List of StockItemSupplierStat</returns>
        public List<StockItemSupplierStat> GetStockSupplierStat(Guid inventoryItemId)
		{
			var response = GetResponse("Inventory/GetStockSupplierStat", "inventoryItemId=" + inventoryItemId + "");
            return JsonFormatter.ConvertFromJson<List<StockItemSupplierStat>>(response);
		}

		/// <summary>
        /// Use this call to retrieve details of one Supplier 
        /// </summary>
        /// <param name="supplierId">Supplier ID</param>
        /// <returns>Supplier</returns>
        public Supplier GetSupplierDetails(Guid supplierId)
		{
			var response = GetResponse("Inventory/GetSupplierDetails", "supplierId=" + supplierId + "");
            return JsonFormatter.ConvertFromJson<Supplier>(response);
		}

		/// <summary>
        /// Use this call to retrieve list of all Suppliers' names 
        /// </summary>
        /// <returns>List of all Suppliers' names</returns>
        public List<Supplier> GetSuppliers()
		{
			var response = GetResponse("Inventory/GetSuppliers", "");
            return JsonFormatter.ConvertFromJson<List<Supplier>>(response);
		}

		/// <summary>
        /// Use this call to get user-specific views from database 
        /// </summary>
        public List<InventoryView> GetUserSpecificViews()
		{
			var response = GetResponse("Inventory/GetUserSpecificViews", "");
            return JsonFormatter.ConvertFromJson<List<InventoryView>>(response);
		}

		/// <summary>
        /// Used to check if stock item has batches 
        /// </summary>
        /// <param name="stockItemId">Stock item unique identifier</param>
        public Boolean HasStockItemBatches(Guid stockItemId)
		{
			var response = GetResponse("Inventory/HasStockItemBatches", "stockItemId=" + stockItemId + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <summary>
        /// Used to check has stock item stock level or not 
        /// </summary>
        /// <param name="request">Object with StockItemId</param>
        public HasStockItemStockLevelResponse HasStockItemStockLevel(HasStockItemStockLevelRequest request)
		{
			var response = GetResponse("Inventory/HasStockItemStockLevel", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<HasStockItemStockLevelResponse>(response);
		}

		/// <summary>
        /// Use this call to insert and update a list of Ebay Compatibility 
        /// </summary>
        /// <param name="request">List of Ebay Compatibility</param>
        public InsertUpdateEbayCompatibilityListResponse InsertUpdateEbayCompatibilityList(InsertUpdateEbayCompatibilityListRequest request)
		{
			var response = GetResponse("Inventory/InsertUpdateEbayCompatibilityList", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<InsertUpdateEbayCompatibilityListResponse>(response);
		}

		/// <summary>
        /// Use this call to check if ChannelSKU is linked 
        /// </summary>
        /// <param name="channelSKU">Product Channel SKU</param>
        /// <param name="source">ChannelName/Source (e.g. EBAY)</param>
        /// <param name="subSource">Subsource (e.g. EBAY1)</param>
        public Boolean IsInventoryItemChannelSKULinked(String channelSKU,String source,String subSource)
		{
			var response = GetResponse("Inventory/IsInventoryItemChannelSKULinked", "channelSKU=" + System.Net.WebUtility.UrlEncode(channelSKU) + "&source=" + System.Net.WebUtility.UrlEncode(source) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <summary>
        /// Checks whether a location is FBA or has an enabled inventory update import 
        /// </summary>
        /// <param name="locationId">Location ID</param>
        /// <returns>List of all stock locations</returns>
        public Boolean IsOwnedStockLocation(Guid locationId)
		{
			var response = GetResponse("Inventory/IsOwnedStockLocation", "locationId=" + locationId + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <summary>
        /// Used to scrap batched item 
        /// </summary>
        public ScrapBatchedItemResponse ScrapBatchedItem(ScrapBatchedItemRequest request)
		{
			var response = GetResponse("Inventory/ScrapBatchedItem", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<ScrapBatchedItemResponse>(response);
		}

		/// <summary>
        /// Use this call to update inventory item main image 
        /// </summary>
        /// <param name="inventoryItemId">Id of StockItem</param>
        /// <param name="mainImageId">main image id</param>
        public void SetInventoryItemImageAsMain(Guid inventoryItemId,Guid mainImageId)
		{
			GetResponse("Inventory/SetInventoryItemImageAsMain", "inventoryItemId=" + inventoryItemId + "&mainImageId=" + mainImageId + "");
		}

		/// <summary>
        /// Use this call to unarchive inventory items 
        /// </summary>
        /// <param name="parameters">InventoryParameters object</param>
        public void UnarchiveInventoryItems(InventoryParametersRequest parameters)
		{
			GetResponse("Inventory/UnarchiveInventoryItems", "parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "");
		}

		/// <summary>
        /// Use this call to unlink  inventory listing from inventory item 
        /// </summary>
        /// <param name="channelRefId">ChannelRefId</param>
        /// <param name="source">Source</param>
        /// <param name="subSource">Subsource</param>
        public void UnlinkChannelListing(String channelRefId,String source,String subSource)
		{
			GetResponse("Inventory/UnlinkChannelListing", "channelRefId=" + System.Net.WebUtility.UrlEncode(channelRefId) + "&source=" + System.Net.WebUtility.UrlEncode(source) + "&subSource=" + System.Net.WebUtility.UrlEncode(subSource) + "");
		}

		/// <summary>
        /// Used to update batch details for stock item 
        /// </summary>
        /// <param name="request">Stock item id and batch details</param>
        public void UpdateBatchDetails(UpdateBatchDetailsRequest request)
		{
			GetResponse("Inventory/UpdateBatchDetails", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Used to update batches and batch inventory info 
        /// </summary>
        /// <param name="batches">List of batches to update</param>
        public void UpdateBatchesWithInventory(IEnumerable<StockItemBatch> batches)
		{
			GetResponse("Inventory/UpdateBatchesWithInventory", "batches=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(batches)) + "");
		}

		/// <summary>
        /// Use this call to update category name 
        /// </summary>
        /// <param name="category">category to update</param>
        public void UpdateCategory(Category category)
		{
			GetResponse("Inventory/UpdateCategory", "category=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(category)) + "");
		}

		/// <summary>
        /// Updates the stock level of the composite parent item 
        /// </summary>
        /// <param name="stockItemId">Stock item id</param>
        /// <param name="locationId">Stock location id</param>
        /// <param name="fieldValue">Stock tracked status</param>
        /// <returns>Composite parent stock level</returns>
        public Int32 UpdateCompositeParentStockLevel(Guid stockItemId,Guid locationId,Int32 fieldValue)
		{
			var response = GetResponse("Inventory/UpdateCompositeParentStockLevel", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&fieldValue=" + fieldValue + "");
            return JsonFormatter.ConvertFromJson<Int32>(response);
		}

		/// <summary>
        /// Use this call to udpate countries 
        /// </summary>
        /// <param name="countries">Countries to udpate</param>
        public void UpdateCountries(IEnumerable<Country> countries)
		{
			GetResponse("Inventory/UpdateCountries", "countries=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(countries)) + "");
		}

		/// <summary>
        /// Update regions for country 
        /// </summary>
        /// <param name="request">Country region information to update</param>
        public void UpdateCountryRegions(UpdateCountryRegionsRequest request)
		{
			GetResponse("Inventory/UpdateCountryRegions", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Update properties on images 
        /// </summary>
        /// <param name="images">Images to edit</param>
        public void UpdateImages(List<StockItemImageSimple> images)
		{
			GetResponse("Inventory/UpdateImages", "images=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(images)) + "");
		}

		/// <summary>
        /// Use this call to update stock item with images 
        /// </summary>
        /// <param name="inventoryItem">Inventory item object</param>
        public void UpdateInventoryItem(StockItemInv inventoryItem)
		{
			GetResponse("Inventory/UpdateInventoryItem", "inventoryItem=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItem)) + "");
		}

		/// <summary>
        /// Update inventory Channel SKU's properties, such as Max Listed Quantity 
        /// </summary>
        /// <param name="inventoryItemChannelSKUs">stockitem channel skus</param>
        public void UpdateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs)
		{
			GetResponse("Inventory/UpdateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemChannelSKUs)) + "");
		}

		/// <summary>
        /// Update inventory Channel SKU's with location properties, such as Max Listed Quantity 
        /// </summary>
        /// <param name="inventoryItemChannelSKUsWithLocation">Listing information</param>
        public void UpdateInventoryItemChannelSKUsWithLocation(List<StockItemChannelSKUWithLocation> inventoryItemChannelSKUsWithLocation)
		{
			GetResponse("Inventory/UpdateInventoryItemChannelSKUsWithLocation", "inventoryItemChannelSKUsWithLocation=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemChannelSKUsWithLocation)) + "");
		}

		/// <summary>
        /// Use this call to update stockItem compositions 
        /// </summary>
        /// <param name="inventoryItemCompositions">stockItem compositions</param>
        public void UpdateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions)
		{
			GetResponse("Inventory/UpdateInventoryItemCompositions", "inventoryItemCompositions=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemCompositions)) + "");
		}

		/// <summary>
        /// Use this call to update stockitem Descriptions 
        /// </summary>
        /// <param name="inventoryItemDescriptions">list of stockitem Descriptions</param>
        public void UpdateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions)
		{
			GetResponse("Inventory/UpdateInventoryItemDescriptions", "inventoryItemDescriptions=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemDescriptions)) + "");
		}

		/// <summary>
        /// Use this call to update stockitem Extended Properties 
        /// </summary>
        /// <param name="inventoryItemExtendedProperties">list of stockitem Extended Properties</param>
        public void UpdateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties)
		{
			GetResponse("Inventory/UpdateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemExtendedProperties)) + "");
		}

		public Dictionary<String,Object> UpdateInventoryItemField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue)
		{
			var response = GetResponse("Inventory/UpdateInventoryItemField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName.ToString() + "&fieldValue=" + System.Net.WebUtility.UrlEncode(fieldValue) + "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,Object>>(response);
		}

		/// <summary>
        /// Update and return stock level records for the stock item and any composite related items 
        /// </summary>
        /// <param name="inventoryItemId">Stock Item Id</param>
        /// <param name="fieldName">Name of field updated</param>
        /// <param name="fieldValue">Input value</param>
        /// <param name="locationId">Location Id</param>
        /// <param name="changeSource"></param>
        public Dictionary<Guid,Dictionary<String,Object>> UpdateInventoryItemLevels(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null)
		{
			var response = GetResponse("Inventory/UpdateInventoryItemLevels", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName.ToString() + "&fieldValue=" + System.Net.WebUtility.UrlEncode(fieldValue) + "&locationId=" + locationId + "&changeSource=" + System.Net.WebUtility.UrlEncode(changeSource) + "");
            return JsonFormatter.ConvertFromJson<Dictionary<Guid,Dictionary<String,Object>>>(response);
		}

		/// <summary>
        /// Update and return stock level records for the stock item 
        /// </summary>
        /// <param name="inventoryItemId">Stock Item Id</param>
        /// <param name="fieldName">Name of field updated</param>
        /// <param name="fieldValue">Input value</param>
        /// <param name="locationId">Location Id</param>
        /// <param name="changeSource"></param>
        public Dictionary<String,Object> UpdateInventoryItemLocationField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null)
		{
			var response = GetResponse("Inventory/UpdateInventoryItemLocationField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName.ToString() + "&fieldValue=" + System.Net.WebUtility.UrlEncode(fieldValue) + "&locationId=" + locationId + "&changeSource=" + System.Net.WebUtility.UrlEncode(changeSource) + "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,Object>>(response);
		}

		/// <summary>
        /// Use this call to update stock item prices 
        /// </summary>
        /// <param name="inventoryItemPrices">List of stock item prices to update</param>
        public void UpdateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices)
		{
			GetResponse("Inventory/UpdateInventoryItemPrices", "inventoryItemPrices=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemPrices)) + "");
		}

		/// <summary>
        /// Use this call to update stock item price rules 
        /// </summary>
        /// <param name="rules">List of stock item pricing rules to update</param>
        public void UpdateInventoryItemPricingRules(List<StockItemPricingRule> rules)
		{
			GetResponse("Inventory/UpdateInventoryItemPricingRules", "rules=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(rules)) + "");
		}

		/// <summary>
        /// Update and return stock level 
        /// </summary>
        /// <param name="inventoryItemId">Stock Item Id</param>
        /// <param name="fieldName">Name of field updated</param>
        /// <param name="fieldValue">Input value</param>
        /// <param name="locationId">Location Id</param>
        /// <param name="changeSource">changeSource</param>
        public Dictionary<String,Object> UpdateInventoryItemStockField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null)
		{
			var response = GetResponse("Inventory/UpdateInventoryItemStockField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName.ToString() + "&fieldValue=" + System.Net.WebUtility.UrlEncode(fieldValue) + "&locationId=" + locationId + "&changeSource=" + System.Net.WebUtility.UrlEncode(changeSource) + "");
            return JsonFormatter.ConvertFromJson<Dictionary<String,Object>>(response);
		}

		/// <summary>
        /// Use this call to update stockitem Titles 
        /// </summary>
        /// <param name="inventoryItemTitles">list of stockitem Titles</param>
        public void UpdateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles)
		{
			GetResponse("Inventory/UpdateInventoryItemTitles", "inventoryItemTitles=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(inventoryItemTitles)) + "");
		}

		/// <summary>
        /// Use this call to update stock item locations bin/rack 
        /// </summary>
        /// <param name="itemLocations">List of stock item locations</param>
        public void UpdateItemLocations(List<StockItemLocation> itemLocations)
		{
			GetResponse("Inventory/UpdateItemLocations", "itemLocations=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(itemLocations)) + "");
		}

		/// <summary>
        /// Used to update product identifiers 
        /// </summary>
        /// <param name="request">Object with collection of product identifiers</param>
        public void UpdateProductIdentifiers(UpdateProductIdentifiersRequest request)
		{
			GetResponse("Inventory/UpdateProductIdentifiers", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Used to update scrap categories 
        /// </summary>
        /// <param name="request">Object with List of scrap categories</param>
        public void UpdateScrapCategories(UpdateScrapCategoriesRequest request)
		{
			GetResponse("Inventory/UpdateScrapCategories", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
		}

		/// <summary>
        /// Use this call to update item supplier stat 
        /// </summary>
        /// <param name="itemSuppliers">List of StockItemSupplierStat</param>
        public void UpdateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers)
		{
			GetResponse("Inventory/UpdateStockSupplierStat", "itemSuppliers=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(itemSuppliers)) + "");
		}

		/// <summary>
        /// Use this call to update supplier 
        /// </summary>
        /// <param name="supplier">Details of supplier to be updated. pkSupplierId is used to identify the supplier to update.</param>
        public void UpdateSupplier(Supplier supplier)
		{
			GetResponse("Inventory/UpdateSupplier", "supplier=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(supplier)) + "");
		}

		/// <summary>
        /// Use this call to update an existing user-specific view 
        /// </summary>
        /// <param name="viewName">Current user-specific view name</param>
        /// <param name="view">Updated user-specific view</param>
        public void UpdateUserSpecificView(String viewName,InventoryView view)
		{
			GetResponse("Inventory/UpdateUserSpecificView", "viewName=" + System.Net.WebUtility.UrlEncode(viewName) + "&view=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(view)) + "");
		}

		/// <summary>
        /// Use this call to upload images from Uploader to StockItem 
        /// </summary>
        /// <param name="inventoryItemId">Id of StockItem</param>
        /// <param name="imageIds">List of image Ids</param>
        public List<PictureSource> UploadImagesToInventoryItem(Guid inventoryItemId,List<Guid> imageIds)
		{
			var response = GetResponse("Inventory/UploadImagesToInventoryItem", "inventoryItemId=" + inventoryItemId + "&imageIds=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(imageIds)) + "");
            return JsonFormatter.ConvertFromJson<List<PictureSource>>(response);
		} 
    }
}