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
	public static class InventoryMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static AddImageToInventoryItemResponse AddImageToInventoryItem(AddImageToInventoryItemRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<AddImageToInventoryItemResponse>(Factory.GetResponse("Inventory/AddImageToInventoryItem", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void AddInventoryItem(StockItem inventoryItem,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/AddInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void AddItemLocations(List<StockItemLocation> itemLocations,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/AddItemLocations", "itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static AddScrapCategoriesResponse AddScrapCategories(AddScrapCategoriesRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<AddScrapCategoriesResponse>(Factory.GetResponse("Inventory/AddScrapCategories", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static AddScrapItemResponse AddScrapItem(AddScrapItemRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<AddScrapItemResponse>(Factory.GetResponse("Inventory/AddScrapItem", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Supplier AddSupplier(Supplier supplier,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Supplier>(Factory.GetResponse("Inventory/AddSupplier", "supplier=" + Newtonsoft.Json.JsonConvert.SerializeObject(supplier, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void AdjustTemplatesInstant(IEnumerable<Guid> inventoryItemIds,String source,String subSource,AdjustmentOptions adjustmentOptions,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/AdjustTemplatesInstant", "inventoryItemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemIds, serializerSettings) + "&source=" + source + "&subSource=" + subSource + "&adjustmentOptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(adjustmentOptions, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void ArchiveInventoryItems(InventoryParametersRequest parameters,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/ArchiveInventoryItems", "parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateBatches(IEnumerable<StockItemBatch> batches,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateBatches", "batches=" + Newtonsoft.Json.JsonConvert.SerializeObject(batches, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static Category CreateCategory(String categoryName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Category>(Factory.GetResponse("Inventory/CreateCategory", "categoryName=" + categoryName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void CreateCountries(IEnumerable<Country> countries,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateCountries", "countries=" + Newtonsoft.Json.JsonConvert.SerializeObject(countries, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static CreateCountryRegionsResponse CreateCountryRegions(CreateCountryRegionsRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CreateCountryRegionsResponse>(Factory.GetResponse("Inventory/CreateCountryRegions", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void CreateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUs, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateInventoryItemCompositions", "inventoryItemCompositions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositions, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateInventoryItemDescriptions", "inventoryItemDescriptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptions, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedProperties, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateInventoryItemPrices", "inventoryItemPrices=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPrices, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateInventoryItemPricingRules(List<StockItemPricingRule> rules,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateInventoryItemPricingRules", "rules=" + Newtonsoft.Json.JsonConvert.SerializeObject(rules, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateInventoryItemTitles", "inventoryItemTitles=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitles, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateStockSupplierStat", "itemSuppliers=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSuppliers, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void CreateUserSpecificView(InventoryView view,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/CreateUserSpecificView", "view=" + Newtonsoft.Json.JsonConvert.SerializeObject(view, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteBatchesByStockItemId(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteBatchesByStockItemId", "stockItemId=" + stockItemId + "", ApiToken, ApiServer); 
		}

		public static void DeleteBatchInventoryInBulk(IEnumerable<Int32> batchInventoryIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteBatchInventoryInBulk", "batchInventoryIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(batchInventoryIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteCategoryById(Guid categoryId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteCategoryById", "categoryId=" + categoryId + "", ApiToken, ApiServer); 
		}

		public static void DeleteCountries(IEnumerable<Guid> countriesIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteCountries", "countriesIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(countriesIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static DeleteEbayCompatibilityListResponse DeleteEbayCompatibilityList(DeleteEbayCompatibilityListRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<DeleteEbayCompatibilityListResponse>(Factory.GetResponse("Inventory/DeleteEbayCompatibilityList", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void DeleteImagesFromInventoryItem(Dictionary<Guid,List<String>> inventoryItemImages,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteImagesFromInventoryItem", "inventoryItemImages=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemImages, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteInventoryItemChannelSKUs(List<Guid> inventoryItemChannelSKUIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteInventoryItemChannelSKUs", "inventoryItemChannelSKUIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteInventoryItemCompositions(Guid stockItemId,List<Guid> inventoryItemCompositionIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteInventoryItemCompositions", "stockItemId=" + stockItemId + "&inventoryItemCompositionIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositionIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteInventoryItemDescriptions(List<Guid> inventoryItemDescriptionIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteInventoryItemDescriptions", "inventoryItemDescriptionIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptionIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteInventoryItemExtendedProperties(Guid inventoryItemId,List<Guid> inventoryItemExtendedPropertyIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&inventoryItemExtendedPropertyIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedPropertyIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteInventoryItemPrices(List<Guid> inventoryItemPriceIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteInventoryItemPrices", "inventoryItemPriceIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPriceIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteInventoryItemPricingRules(List<Int32> pricingRuleIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteInventoryItemPricingRules", "pricingRuleIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(pricingRuleIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteInventoryItems(DeleteInventoryItemsRequest request,List<Guid> inventoryItemIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteInventoryItems", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "&inventoryItemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteInventoryItemTitles(List<Guid> inventoryItemTitleIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteInventoryItemTitles", "inventoryItemTitleIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitleIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteItemLocations(Guid inventoryItemId,List<Guid> itemLocations,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteItemLocations", "inventoryItemId=" + inventoryItemId + "&itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteScrapCategories(DeleteScrapCategoriesRequest request,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteScrapCategories", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteStockSupplierStat(Guid stockItemId,List<Guid> itemSupplierIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteStockSupplierStat", "stockItemId=" + stockItemId + "&itemSupplierIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSupplierIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteSuppliers(List<Guid> suppliersIds,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteSuppliers", "suppliersIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(suppliersIds, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void DeleteUserSpecificView(String viewName,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DeleteUserSpecificView", "viewName=" + viewName + "", ApiToken, ApiServer); 
		}

		public static void DuplicateInventoryItem(StockItem inventoryItem,Guid sourceItemId,Boolean copyImages,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/DuplicateInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "&sourceItemId=" + sourceItemId + "&copyImages=" + copyImages + "", ApiToken, ApiServer); 
		}

		public static Dictionary<String,List<String>> GetAllExtendedPropertyNames(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,List<String>>>(Factory.GetResponse("Inventory/GetAllExtendedPropertyNames", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static GetBatchAuditResponse GetBatchAudit(GetBatchAuditRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetBatchAuditResponse>(Factory.GetResponse("Inventory/GetBatchAudit", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemBatch> GetBatchesByStockItemId(Guid stockItemId,Boolean onlyAvailable,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemBatch>>(Factory.GetResponse("Inventory/GetBatchesByStockItemId", "stockItemId=" + stockItemId + "&onlyAvailable=" + onlyAvailable + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Category> GetCategories(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Category>>(Factory.GetResponse("Inventory/GetCategories", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<AnyConfig> GetChannels(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<AnyConfig>>(Factory.GetResponse("Inventory/GetChannels", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<HeaderConfig> GetChannelsBySource(String source,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<HeaderConfig>>(Factory.GetResponse("Inventory/GetChannelsBySource", "source=" + source + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static IEnumerable<Country> GetCountries(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Country>>(Factory.GetResponse("Inventory/GetCountries", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Dictionary<String,String> GetCountryCodes(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,String>>(Factory.GetResponse("Inventory/GetCountryCodes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemEbayCompatibility> GetEbayCompatibilityList(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemEbayCompatibility>>(Factory.GetResponse("Inventory/GetEbayCompatibilityList", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<String> GetExtendedPropertyNames(Guid ApiToken, String ApiServer,String propertyType = "Attribute")		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Inventory/GetExtendedPropertyNames", "propertyType=" + propertyType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<String> GetExtendedPropertyTypes(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Inventory/GetExtendedPropertyTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Dictionary<String,Byte> GetInventoryBatchTypes(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,Byte>>(Factory.GetResponse("Inventory/GetInventoryBatchTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemAuditTrail> GetInventoryItemAuditTrail(Guid inventoryItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemAuditTrail>>(Factory.GetResponse("Inventory/GetInventoryItemAuditTrail", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemBatch> GetInventoryItemBatchInformation(GetInventoryItemBatchInformationRequest Request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemBatch>>(Factory.GetResponse("Inventory/GetInventoryItemBatchInformation", "Request=" + Newtonsoft.Json.JsonConvert.SerializeObject(Request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static StockItemInv GetInventoryItemById(Guid id,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<StockItemInv>(Factory.GetResponse("Inventory/GetInventoryItemById", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemChannelSKU> GetInventoryItemChannelSKUs(Guid inventoryItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemChannelSKU>>(Factory.GetResponse("Inventory/GetInventoryItemChannelSKUs", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemChannelSKUWithLocation> GetInventoryItemChannelSKUsWithLocation(Guid channelSKURowId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemChannelSKUWithLocation>>(Factory.GetResponse("Inventory/GetInventoryItemChannelSKUsWithLocation", "channelSKURowId=" + channelSKURowId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemComposition> GetInventoryItemCompositions(Guid ApiToken, String ApiServer,Guid inventoryItemId,Boolean getFullDetail = false)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemComposition>>(Factory.GetResponse("Inventory/GetInventoryItemCompositions", "inventoryItemId=" + inventoryItemId + "&getFullDetail=" + getFullDetail + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemDescription> GetInventoryItemDescriptions(Guid inventoryItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemDescription>>(Factory.GetResponse("Inventory/GetInventoryItemDescriptions", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemExtendedProperty> GetInventoryItemExtendedProperties(Guid inventoryItemId,GetExtendedPropertyFilter propertyParams,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemExtendedProperty>>(Factory.GetResponse("Inventory/GetInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&propertyParams=" + Newtonsoft.Json.JsonConvert.SerializeObject(propertyParams, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemImage> GetInventoryItemImages(Guid inventoryItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemImage>>(Factory.GetResponse("Inventory/GetInventoryItemImages", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemLocation> GetInventoryItemLocations(Guid inventoryItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLocation>>(Factory.GetResponse("Inventory/GetInventoryItemLocations", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemPricingRule> GetInventoryItemPriceRulesById(Guid stockItemPriceId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemPricingRule>>(Factory.GetResponse("Inventory/GetInventoryItemPriceRulesById", "stockItemPriceId=" + stockItemPriceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemPricingRule> GetInventoryItemPriceRulesBySource(Guid stockItemId,String source,String subSource,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemPricingRule>>(Factory.GetResponse("Inventory/GetInventoryItemPriceRulesBySource", "stockItemId=" + stockItemId + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemPrice> GetInventoryItemPrices(Guid inventoryItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemPrice>>(Factory.GetResponse("Inventory/GetInventoryItemPrices", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Int32 GetInventoryItemsCount(Boolean? includeDeleted,Boolean? includeArchived,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("Inventory/GetInventoryItemsCount", "includeDeleted=" + Newtonsoft.Json.JsonConvert.SerializeObject(includeDeleted, serializerSettings) + "&includeArchived=" + Newtonsoft.Json.JsonConvert.SerializeObject(includeArchived, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemTitle> GetInventoryItemTitles(Guid inventoryItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemTitle>>(Factory.GetResponse("Inventory/GetInventoryItemTitles", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static String GetNewItemNumber(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Inventory/GetNewItemNumber", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<KeyGuidValue> GetPackageGroups(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyGuidValue>>(Factory.GetResponse("Inventory/GetPackageGroups", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<KeyGuidValue> GetPostalServices(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyGuidValue>>(Factory.GetResponse("Inventory/GetPostalServices", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<InventoryView> GetPreDefinedViews(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<InventoryView>>(Factory.GetResponse("Inventory/GetPreDefinedViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static GetScrapCategoriesResponse GetScrapCategories(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetScrapCategoriesResponse>(Factory.GetResponse("Inventory/GetScrapCategories", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static GetScrapHistoryResponse GetScrapHistory(GetScrapHistoryRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetScrapHistoryResponse>(Factory.GetResponse("Inventory/GetScrapHistory", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static GetStockItemBatchesByLocationResponse GetStockItemBatchesByLocation(GetStockItemBatchesByLocationRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetStockItemBatchesByLocationResponse>(Factory.GetResponse("Inventory/GetStockItemBatchesByLocation", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemLabel> GetStockItemLabels(List<Tuple<Int32,Int32>> selectedRegions,Guid token,Guid location,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLabel>>(Factory.GetResponse("Inventory/GetStockItemLabels", "selectedRegions=" + Newtonsoft.Json.JsonConvert.SerializeObject(selectedRegions, serializerSettings) + "&token=" + token + "&location=" + location + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockLocation> GetStockLocations(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockLocation>>(Factory.GetResponse("Inventory/GetStockLocations", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<StockItemSupplierStat> GetStockSupplierStat(Guid inventoryItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemSupplierStat>>(Factory.GetResponse("Inventory/GetStockSupplierStat", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Supplier GetSupplierDetails(Guid supplierId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Supplier>(Factory.GetResponse("Inventory/GetSupplierDetails", "supplierId=" + supplierId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<Supplier> GetSuppliers(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Supplier>>(Factory.GetResponse("Inventory/GetSuppliers", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<InventoryView> GetUserSpecificViews(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<InventoryView>>(Factory.GetResponse("Inventory/GetUserSpecificViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Boolean HasStockItemBatches(Guid stockItemId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("Inventory/HasStockItemBatches", "stockItemId=" + stockItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static HasStockItemStockLevelResponse HasStockItemStockLevel(HasStockItemStockLevelRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<HasStockItemStockLevelResponse>(Factory.GetResponse("Inventory/HasStockItemStockLevel", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static InsertUpdateEbayCompatibilityListResponse InsertUpdateEbayCompatibilityList(InsertUpdateEbayCompatibilityListRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<InsertUpdateEbayCompatibilityListResponse>(Factory.GetResponse("Inventory/InsertUpdateEbayCompatibilityList", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Boolean IsInventoryItemChannelSKULinked(String channelSKU,String source,String subSource,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("Inventory/IsInventoryItemChannelSKULinked", "channelSKU=" + channelSKU + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Boolean IsOwnedStockLocation(Guid locationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("Inventory/IsOwnedStockLocation", "locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static ScrapBatchedItemResponse ScrapBatchedItem(ScrapBatchedItemRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ScrapBatchedItemResponse>(Factory.GetResponse("Inventory/ScrapBatchedItem", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void SetInventoryItemImageAsMain(Guid inventoryItemId,Guid mainImageId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/SetInventoryItemImageAsMain", "inventoryItemId=" + inventoryItemId + "&mainImageId=" + mainImageId + "", ApiToken, ApiServer); 
		}

		public static void UnarchiveInventoryItems(InventoryParametersRequest parameters,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UnarchiveInventoryItems", "parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UnlinkChannelListing(String channelRefId,String source,String subSource,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UnlinkChannelListing", "channelRefId=" + channelRefId + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer); 
		}

		public static void UpdateBatchDetails(UpdateBatchDetailsRequest request,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateBatchDetails", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateBatchesWithInventory(IEnumerable<StockItemBatch> batches,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateBatchesWithInventory", "batches=" + Newtonsoft.Json.JsonConvert.SerializeObject(batches, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateCategory(Category category,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateCategory", "category=" + Newtonsoft.Json.JsonConvert.SerializeObject(category, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static Int32 UpdateCompositeParentStockLevel(Guid stockItemId,Guid locationId,Int32 fieldValue,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("Inventory/UpdateCompositeParentStockLevel", "stockItemId=" + stockItemId + "&locationId=" + locationId + "&fieldValue=" + fieldValue + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void UpdateCountries(IEnumerable<Country> countries,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateCountries", "countries=" + Newtonsoft.Json.JsonConvert.SerializeObject(countries, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateCountryRegions(UpdateCountryRegionsRequest request,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateCountryRegions", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateEbayCompatibilityList(List<StockItemEbayCompatibility> ebayCompatibilityList,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateEbayCompatibilityList", "ebayCompatibilityList=" + Newtonsoft.Json.JsonConvert.SerializeObject(ebayCompatibilityList, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateImages(List<StockItemImageSimple> images,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateImages", "images=" + Newtonsoft.Json.JsonConvert.SerializeObject(images, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateInventoryItem(StockItemInv inventoryItem,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUs, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateInventoryItemChannelSKUsWithLocation(List<StockItemChannelSKUWithLocation> inventoryItemChannelSKUsWithLocation,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItemChannelSKUsWithLocation", "inventoryItemChannelSKUsWithLocation=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUsWithLocation, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItemCompositions", "inventoryItemCompositions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositions, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItemDescriptions", "inventoryItemDescriptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptions, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedProperties, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static Dictionary<String,Object> UpdateInventoryItemField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Dictionary<Guid,Dictionary<String,Object>> UpdateInventoryItemLevels(Guid ApiToken, String ApiServer,Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<Guid,Dictionary<String,Object>>>(Factory.GetResponse("Inventory/UpdateInventoryItemLevels", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "&changeSource=" + changeSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Dictionary<String,Object> UpdateInventoryItemLocationField(Guid ApiToken, String ApiServer,Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemLocationField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "&changeSource=" + changeSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void UpdateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItemPrices", "inventoryItemPrices=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPrices, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateInventoryItemPricingRules(List<StockItemPricingRule> rules,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItemPricingRules", "rules=" + Newtonsoft.Json.JsonConvert.SerializeObject(rules, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static Dictionary<String,Object> UpdateInventoryItemStockField(Guid ApiToken, String ApiServer,Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemStockField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "&changeSource=" + changeSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void UpdateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateInventoryItemTitles", "inventoryItemTitles=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitles, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateItemLocations(List<StockItemLocation> itemLocations,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateItemLocations", "itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateScrapCategories(UpdateScrapCategoriesRequest request,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateScrapCategories", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateStockSupplierStat", "itemSuppliers=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSuppliers, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateSupplier(Supplier supplier,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateSupplier", "supplier=" + Newtonsoft.Json.JsonConvert.SerializeObject(supplier, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static void UpdateUserSpecificView(String viewName,InventoryView view,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("Inventory/UpdateUserSpecificView", "viewName=" + viewName + "&view=" + Newtonsoft.Json.JsonConvert.SerializeObject(view, serializerSettings) + "", ApiToken, ApiServer); 
		}

		public static List<PictureSource> UploadImagesToInventoryItem(Guid inventoryItemId,List<Guid> imageIds,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PictureSource>>(Factory.GetResponse("Inventory/UploadImagesToInventoryItem", "inventoryItemId=" + inventoryItemId + "&imageIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(imageIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		} 
	}
}