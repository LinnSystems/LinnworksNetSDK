using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class InventoryMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static void UpdateSupplier(Supplier supplier, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateSupplier", "supplier=" + Newtonsoft.Json.JsonConvert.SerializeObject(supplier, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteSuppliers(List<Guid> suppliersIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteSuppliers", "suppliersIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(suppliersIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemSupplierStat> GetStockSupplierStat(Guid inventoryItemId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemSupplierStat>>(Factory.GetResponse("Inventory/GetStockSupplierStat", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateStockSupplierStat", "itemSuppliers=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSuppliers, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateStockSupplierStat", "itemSuppliers=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSuppliers, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteStockSupplierStat(Guid stockItemId, List<Guid> itemSupplierIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteStockSupplierStat", "stockItemId=" + stockItemId + "&itemSupplierIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSupplierIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemPrice> GetInventoryItemPrices(Guid inventoryItemId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemPrice>>(Factory.GetResponse("Inventory/GetInventoryItemPrices", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemPrices", "inventoryItemPrices=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPrices, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemPrices", "inventoryItemPrices=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPrices, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemPrices(List<Guid> inventoryItemPriceIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemPrices", "inventoryItemPriceIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPriceIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemPricingRule> GetInventoryItemPriceRulesById(Guid stockItemPriceId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemPricingRule>>(Factory.GetResponse("Inventory/GetInventoryItemPriceRulesById", "stockItemPriceId=" + stockItemPriceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemPricingRule> GetInventoryItemPriceRulesBySource(Guid stockItemId, String source, String subSource, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemPricingRule>>(Factory.GetResponse("Inventory/GetInventoryItemPriceRulesBySource", "stockItemId=" + stockItemId + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemPricingRules(List<StockItemPricingRule> rules, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemPricingRules", "rules=" + Newtonsoft.Json.JsonConvert.SerializeObject(rules, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemPricingRules(List<Int32> pricingRuleIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemPricingRules", "pricingRuleIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(pricingRuleIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemPricingRules(List<StockItemPricingRule> rules, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemPricingRules", "rules=" + Newtonsoft.Json.JsonConvert.SerializeObject(rules, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemDescription> GetInventoryItemDescriptions(Guid inventoryItemId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemDescription>>(Factory.GetResponse("Inventory/GetInventoryItemDescriptions", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemDescriptions", "inventoryItemDescriptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemDescriptions", "inventoryItemDescriptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemDescriptions(List<Guid> inventoryItemDescriptionIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemDescriptions", "inventoryItemDescriptionIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptionIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemLabel> GetStockItemLabels(List<Tuple<Int32, Int32>> selectedRegions, Guid token, Guid location, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLabel>>(Factory.GetResponse("Inventory/GetStockItemLabels", "selectedRegions=" + Newtonsoft.Json.JsonConvert.SerializeObject(selectedRegions, serializerSettings) + "&token=" + token + "&location=" + location + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<AnyConfig> GetChannels(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<AnyConfig>>(Factory.GetResponse("Inventory/GetChannels", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<HeaderConfig> GetChannelsBySource(String source, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<HeaderConfig>>(Factory.GetResponse("Inventory/GetChannelsBySource", "source=" + source + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<String> GetExtendedPropertyNames(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Inventory/GetExtendedPropertyNames", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<String> GetExtendedPropertyTypes(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Inventory/GetExtendedPropertyTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<KeyGuidValue> GetPackageGroups(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyGuidValue>>(Factory.GetResponse("Inventory/GetPackageGroups", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<KeyGuidValue> GetPostalServices(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyGuidValue>>(Factory.GetResponse("Inventory/GetPostalServices", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AddImageToInventoryItemResponse AddImageToInventoryItem(AddImageToInventoryItemRequest addImageToInventoryItemRequest, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AddImageToInventoryItemResponse>(Factory.GetResponse("Inventory/AddImageToInventoryItem", "addImageToInventoryItemRequest=" + Newtonsoft.Json.JsonConvert.SerializeObject(addImageToInventoryItemRequest, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PortionResult<InventoryItem> GetInventoryItems(InventoryView view, List<Guid> stockLocationIds, Int32 startIndex, Int32 itemsCount, Boolean preloadChilds, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PortionResult<InventoryItem>>(Factory.GetResponse("Inventory/GetInventoryItems", "view=" + Newtonsoft.Json.JsonConvert.SerializeObject(view, serializerSettings) + "&stockLocationIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockLocationIds, serializerSettings) + "&startIndex=" + startIndex + "&itemsCount=" + itemsCount + "&preloadChilds=" + preloadChilds + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<Guid, List<InventoryItem>> GetInventoryItemsChilds(InventoryView view, List<Guid> stockLocationIds, List<Guid> itemIds, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<Guid, List<InventoryItem>>>(Factory.GetResponse("Inventory/GetInventoryItemsChilds", "view=" + Newtonsoft.Json.JsonConvert.SerializeObject(view, serializerSettings) + "&stockLocationIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockLocationIds, serializerSettings) + "&itemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<String, Object> UpdateInventoryItemField(Guid inventoryItemId, ColumnNameType fieldName, String fieldValue, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<String, Object> UpdateInventoryItemStockField(Guid inventoryItemId, ColumnNameType fieldName, String fieldValue, Guid locationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemStockField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Dictionary<String, Object> UpdateInventoryItemLocationField(Guid inventoryItemId, ColumnNameType fieldName, String fieldValue, Guid locationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemLocationField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static StockItemInv GetInventoryItemById(Guid id, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StockItemInv>(Factory.GetResponse("Inventory/GetInventoryItemById", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<InventoryView> GetUserSpecificViews(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<InventoryView>>(Factory.GetResponse("Inventory/GetUserSpecificViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateUserSpecificView(InventoryView view, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateUserSpecificView", "view=" + Newtonsoft.Json.JsonConvert.SerializeObject(view, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateUserSpecificView(String viewName, InventoryView view, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateUserSpecificView", "viewName=" + viewName + "&view=" + Newtonsoft.Json.JsonConvert.SerializeObject(view, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteUserSpecificView(String viewName, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteUserSpecificView", "viewName=" + viewName + "", ApiToken, ApiServer);
        }

        public static List<InventoryView> GetPreDefinedViews(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<InventoryView>>(Factory.GetResponse("Inventory/GetPreDefinedViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Int32 GetInventoryItemsCount(Boolean? includeDeleted, Boolean? includeArchived, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("Inventory/GetInventoryItemsCount", "includeDeleted=" + Newtonsoft.Json.JsonConvert.SerializeObject(includeDeleted, serializerSettings) + "&includeArchived=" + Newtonsoft.Json.JsonConvert.SerializeObject(includeArchived, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AddInventoryItem(StockItem inventoryItem, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/AddInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DuplicateInventoryItem(StockItem inventoryItem, Guid sourceItemId, Boolean copyImages, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DuplicateInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "&sourceItemId=" + sourceItemId + "&copyImages=" + copyImages + "", ApiToken, ApiServer);
        }

        public static void ArchiveInventoryItems(InventoryParameters parameters, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/ArchiveInventoryItems", "parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UnarchiveInventoryItems(InventoryParameters parameters, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UnarchiveInventoryItems", "parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static String GetNewItemNumber(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Inventory/GetNewItemNumber", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateInventoryItem(StockItemInv inventoryItem, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItems(IEnumerable<Guid> inventoryItemIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItems", "inventoryItemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void AdjustTemplatesInstant(IEnumerable<Guid> inventoryItemIds, String source, String subSource, AdjustmentOptions adjustmentOptions, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/AdjustTemplatesInstant", "inventoryItemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemIds, serializerSettings) + "&source=" + source + "&subSource=" + subSource + "&adjustmentOptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(adjustmentOptions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemChannelSKU> GetInventoryItemChannelSKUs(Guid inventoryItemId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemChannelSKU>>(Factory.GetResponse("Inventory/GetInventoryItemChannelSKUs", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUs, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void CreateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUs, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemChannelSKUs(List<Guid> inventoryItemChannelSKUIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemChannelSKUs", "inventoryItemChannelSKUIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UnlinkChannelListing(String channelRefId, String source, String subSource, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UnlinkChannelListing", "channelRefId=" + channelRefId + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer);
        }

        public static List<StockItemAuditTrail> GetInventoryItemAuditTrail(Guid inventoryItemId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemAuditTrail>>(Factory.GetResponse("Inventory/GetInventoryItemAuditTrail", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemImage> GetInventoryItemImages(Guid inventoryItemId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemImage>>(Factory.GetResponse("Inventory/GetInventoryItemImages", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetInventoryItemImageAsMain(Guid inventoryItemId, Guid mainImageId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/SetInventoryItemImageAsMain", "inventoryItemId=" + inventoryItemId + "&mainImageId=" + mainImageId + "", ApiToken, ApiServer);
        }

        public static List<PictureSource> UploadImagesToInventoryItem(Guid inventoryItemId, List<Guid> imageIds, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PictureSource>>(Factory.GetResponse("Inventory/UploadImagesToInventoryItem", "inventoryItemId=" + inventoryItemId + "&imageIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(imageIds, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateImages(List<StockItemImageSimple> images, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateImages", "images=" + Newtonsoft.Json.JsonConvert.SerializeObject(images, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteImagesFromInventoryItem(Dictionary<Guid, List<String>> inventoryItemImages, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteImagesFromInventoryItem", "inventoryItemImages=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemImages, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<Category> GetCategories(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Category>>(Factory.GetResponse("Inventory/GetCategories", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Category CreateCategory(String categoryName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Category>(Factory.GetResponse("Inventory/CreateCategory", "categoryName=" + categoryName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateCategory(Category category, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateCategory", "category=" + Newtonsoft.Json.JsonConvert.SerializeObject(category, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteCategoryById(Guid categoryId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteCategoryById", "categoryId=" + categoryId + "", ApiToken, ApiServer);
        }

        public static Dictionary<String, String> GetCountryCodes(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, String>>(Factory.GetResponse("Inventory/GetCountryCodes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static IEnumerable<Country> GetCountries(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Country>>(Factory.GetResponse("Inventory/GetCountries", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateCountries(IEnumerable<Country> countries, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateCountries", "countries=" + Newtonsoft.Json.JsonConvert.SerializeObject(countries, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateCountries(IEnumerable<Country> countries, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateCountries", "countries=" + Newtonsoft.Json.JsonConvert.SerializeObject(countries, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockLocation> GetStockLocations(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockLocation>>(Factory.GetResponse("Inventory/GetStockLocations", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Boolean IsOwnedStockLocation(Guid locationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("Inventory/IsOwnedStockLocation", "locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<StockItemLocation> GetInventoryItemLocations(Guid inventoryItemId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLocation>>(Factory.GetResponse("Inventory/GetInventoryItemLocations", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AddItemLocations(List<StockItemLocation> itemLocations, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/AddItemLocations", "itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateItemLocations(List<StockItemLocation> itemLocations, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateItemLocations", "itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteItemLocations(Guid inventoryItemId, List<Guid> itemLocations, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteItemLocations", "inventoryItemId=" + inventoryItemId + "&itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemComposition> GetInventoryItemCompositions(Guid inventoryItemId, Boolean getFullDetail, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemComposition>>(Factory.GetResponse("Inventory/GetInventoryItemCompositions", "inventoryItemId=" + inventoryItemId + "&getFullDetail=" + getFullDetail + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemCompositions", "inventoryItemCompositions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemCompositions", "inventoryItemCompositions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositions, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemCompositions(Guid stockItemId, List<Guid> inventoryItemCompositionIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemCompositions", "stockItemId=" + stockItemId + "&inventoryItemCompositionIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositionIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemExtendedProperty> GetInventoryItemExtendedProperties(Guid inventoryItemId, GetExtendedPropertyFilter propertyParams, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemExtendedProperty>>(Factory.GetResponse("Inventory/GetInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&propertyParams=" + Newtonsoft.Json.JsonConvert.SerializeObject(propertyParams, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedProperties, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedProperties, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemExtendedProperties(Guid inventoryItemId, List<Guid> inventoryItemExtendedPropertyIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&inventoryItemExtendedPropertyIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedPropertyIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<StockItemTitle> GetInventoryItemTitles(Guid inventoryItemId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemTitle>>(Factory.GetResponse("Inventory/GetInventoryItemTitles", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CreateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/CreateInventoryItemTitles", "inventoryItemTitles=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitles, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/UpdateInventoryItemTitles", "inventoryItemTitles=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitles, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryItemTitles(List<Guid> inventoryItemTitleIds, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Inventory/DeleteInventoryItemTitles", "inventoryItemTitleIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitleIds, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static List<Supplier> GetSuppliers(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Supplier>>(Factory.GetResponse("Inventory/GetSuppliers", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Supplier GetSupplierDetails(Guid supplierId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Supplier>(Factory.GetResponse("Inventory/GetSupplierDetails", "supplierId=" + supplierId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Supplier AddSupplier(Supplier supplier, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Supplier>(Factory.GetResponse("Inventory/AddSupplier", "supplier=" + Newtonsoft.Json.JsonConvert.SerializeObject(supplier, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}