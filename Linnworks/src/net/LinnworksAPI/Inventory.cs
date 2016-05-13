using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace LinnworksAPI
{public static class InventoryMethods 
{ public static List<AnyConfig> GetChannels(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<AnyConfig>>(Factory.GetResponse("Inventory/GetChannels", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<String> GetExtendedPropertyNames(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Inventory/GetExtendedPropertyNames", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<String> GetExtendedPropertyTypes(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("Inventory/GetExtendedPropertyTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<KeyGuidValue> GetPackageGroups(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyGuidValue>>(Factory.GetResponse("Inventory/GetPackageGroups", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<KeyGuidValue> GetPostalServices(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<KeyGuidValue>>(Factory.GetResponse("Inventory/GetPostalServices", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static PortionResult<InventoryItem> GetInventoryItems(InventoryView view,List<Guid> stockLocationIds,Int32 startIndex,Int32 itemsCount,Boolean preloadChilds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<PortionResult<InventoryItem>>(Factory.GetResponse("Inventory/GetInventoryItems", "view=" + Newtonsoft.Json.JsonConvert.SerializeObject(view) + "&stockLocationIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockLocationIds) + "&startIndex=" + startIndex + "&itemsCount=" + itemsCount + "&preloadChilds=" + preloadChilds + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Dictionary<Guid,List<InventoryItemSingle>> GetInventoryItemsChilds(InventoryView view,List<Guid> stockLocationIds,List<Guid> itemIds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<Guid,List<InventoryItemSingle>>>(Factory.GetResponse("Inventory/GetInventoryItemsChilds", "view=" + Newtonsoft.Json.JsonConvert.SerializeObject(view) + "&stockLocationIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(stockLocationIds) + "&itemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemIds) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Dictionary<String,Object> UpdateInventoryItemField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Dictionary<String,Object> UpdateInventoryItemStockField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemStockField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Dictionary<String,Object> UpdateInventoryItemLocationField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,Object>>(Factory.GetResponse("Inventory/UpdateInventoryItemLocationField", "inventoryItemId=" + inventoryItemId + "&fieldName=" + fieldName + "&fieldValue=" + fieldValue + "&locationId=" + locationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static StockItemInv GetInventoryItemById(Guid id,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<StockItemInv>(Factory.GetResponse("Inventory/GetInventoryItemById", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<InventoryView> GetInventoryViews(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<InventoryView>>(Factory.GetResponse("Inventory/GetInventoryViews", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void UpdateInventoryViews(List<InventoryView> views,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateInventoryViews", "views=" + Newtonsoft.Json.JsonConvert.SerializeObject(views) + "", ApiToken, ApiServer); 
}

public static void AddInventoryItem(StockItem inventoryItem,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/AddInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem) + "", ApiToken, ApiServer); 
}

public static void DuplicateInventoryItem(StockItem inventoryItem,Guid sourceItemId,Boolean copyImages,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DuplicateInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem) + "&sourceItemId=" + sourceItemId + "&copyImages=" + copyImages + "", ApiToken, ApiServer); 
}

public static String GetNewItemNumber(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Inventory/GetNewItemNumber", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void UpdateInventoryItem(StockItemInv inventoryItem,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateInventoryItem", "inventoryItem=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItem) + "", ApiToken, ApiServer); 
}

public static void DeleteInventoryItems(IEnumerable<Guid> inventoryItemIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteInventoryItems", "inventoryItemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemIds) + "", ApiToken, ApiServer); 
}

public static void AdjustTemplatesInstant(IEnumerable<Guid> inventoryItemIds,String source,String subSource,AdjustmentOptions adjustmentOptions,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/AdjustTemplatesInstant", "inventoryItemIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemIds) + "&source=" + source + "&subSource=" + subSource + "&adjustmentOptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(adjustmentOptions) + "", ApiToken, ApiServer); 
}

public static List<StockItemChannelSKU> GetInventoryItemChannelSKUs(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemChannelSKU>>(Factory.GetResponse("Inventory/GetInventoryItemChannelSKUs", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void UpdateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUs) + "", ApiToken, ApiServer); 
}

public static void CreateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/CreateInventoryItemChannelSKUs", "inventoryItemChannelSKUs=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUs) + "", ApiToken, ApiServer); 
}

public static void DeleteInventoryItemChannelSKUs(List<Guid> inventoryItemChannelSKUIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteInventoryItemChannelSKUs", "inventoryItemChannelSKUIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemChannelSKUIds) + "", ApiToken, ApiServer); 
}

public static void UnlinkChannelListing(String channelRefId,String source,String subSource,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UnlinkChannelListing", "channelRefId=" + channelRefId + "&source=" + source + "&subSource=" + subSource + "", ApiToken, ApiServer); 
}

public static List<StockItemAuditTrail> GetInventoryItemAuditTrail(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemAuditTrail>>(Factory.GetResponse("Inventory/GetInventoryItemAuditTrail", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<StockItemImage> GetInventoryItemImages(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemImage>>(Factory.GetResponse("Inventory/GetInventoryItemImages", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void SetInventoryItemImageAsMain(Guid inventoryItemId,Guid mainImageId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/SetInventoryItemImageAsMain", "inventoryItemId=" + inventoryItemId + "&mainImageId=" + mainImageId + "", ApiToken, ApiServer); 
}

public static List<PictureSource> UploadImagesToInventoryItem(Guid inventoryItemId,List<Guid> imageIds,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PictureSource>>(Factory.GetResponse("Inventory/UploadImagesToInventoryItem", "inventoryItemId=" + inventoryItemId + "&imageIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(imageIds) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void DeleteImagesFromInventoryItem(Dictionary<Guid,List<String>> inventoryItemImages,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteImagesFromInventoryItem", "inventoryItemImages=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemImages) + "", ApiToken, ApiServer); 
}

public static List<Category> GetCategories(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Category>>(Factory.GetResponse("Inventory/GetCategories", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Category CreateCategory(String categoryName,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Category>(Factory.GetResponse("Inventory/CreateCategory", "categoryName=" + categoryName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void UpdateCategory(Category category,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateCategory", "category=" + Newtonsoft.Json.JsonConvert.SerializeObject(category) + "", ApiToken, ApiServer); 
}

public static void DeleteCategoryById(Guid categoryId,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteCategoryById", "categoryId=" + categoryId + "", ApiToken, ApiServer); 
}

public static Dictionary<String,String> GetCountryCodes(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,String>>(Factory.GetResponse("Inventory/GetCountryCodes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static IEnumerable<Country> GetCountries(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Country>>(Factory.GetResponse("Inventory/GetCountries", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void CreateCountries(IEnumerable<Country> countries,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/CreateCountries", "countries=" + Newtonsoft.Json.JsonConvert.SerializeObject(countries) + "", ApiToken, ApiServer); 
}

public static void UpdateCountries(IEnumerable<Country> countries,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateCountries", "countries=" + Newtonsoft.Json.JsonConvert.SerializeObject(countries) + "", ApiToken, ApiServer); 
}

public static List<StockLocation> GetStockLocations(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockLocation>>(Factory.GetResponse("Inventory/GetStockLocations", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<StockItemLocation> GetInventoryItemLocations(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemLocation>>(Factory.GetResponse("Inventory/GetInventoryItemLocations", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void AddItemLocations(List<StockItemLocation> itemLocations,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/AddItemLocations", "itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations) + "", ApiToken, ApiServer); 
}

public static void UpdateItemLocations(List<StockItemLocation> itemLocations,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateItemLocations", "itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations) + "", ApiToken, ApiServer); 
}

public static void DeleteItemLocations(Guid inventoryItemId,List<Guid> itemLocations,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteItemLocations", "inventoryItemId=" + inventoryItemId + "&itemLocations=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemLocations) + "", ApiToken, ApiServer); 
}

public static List<StockItemComposition> GetInventoryItemCompositions(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemComposition>>(Factory.GetResponse("Inventory/GetInventoryItemCompositions", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void CreateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/CreateInventoryItemCompositions", "inventoryItemCompositions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositions) + "", ApiToken, ApiServer); 
}

public static void UpdateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateInventoryItemCompositions", "inventoryItemCompositions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositions) + "", ApiToken, ApiServer); 
}

public static void DeleteInventoryItemCompositions(Guid stockItemId,List<Guid> inventoryItemCompositionIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteInventoryItemCompositions", "stockItemId=" + stockItemId + "&inventoryItemCompositionIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemCompositionIds) + "", ApiToken, ApiServer); 
}

public static List<StockItemExtendedProperty> GetInventoryItemExtendedProperties(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemExtendedProperty>>(Factory.GetResponse("Inventory/GetInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void CreateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/CreateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedProperties) + "", ApiToken, ApiServer); 
}

public static void UpdateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateInventoryItemExtendedProperties", "inventoryItemExtendedProperties=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedProperties) + "", ApiToken, ApiServer); 
}

public static void DeleteInventoryItemExtendedProperties(Guid inventoryItemId,List<Guid> inventoryItemExtendedPropertyIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteInventoryItemExtendedProperties", "inventoryItemId=" + inventoryItemId + "&inventoryItemExtendedPropertyIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemExtendedPropertyIds) + "", ApiToken, ApiServer); 
}

public static List<StockItemTitle> GetInventoryItemTitles(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemTitle>>(Factory.GetResponse("Inventory/GetInventoryItemTitles", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void CreateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/CreateInventoryItemTitles", "inventoryItemTitles=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitles) + "", ApiToken, ApiServer); 
}

public static void UpdateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateInventoryItemTitles", "inventoryItemTitles=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitles) + "", ApiToken, ApiServer); 
}

public static void DeleteInventoryItemTitles(List<Guid> inventoryItemTitleIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteInventoryItemTitles", "inventoryItemTitleIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemTitleIds) + "", ApiToken, ApiServer); 
}

public static List<Supplier> GetSuppliers(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Supplier>>(Factory.GetResponse("Inventory/GetSuppliers", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Supplier GetSupplierDetails(Guid supplierId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Supplier>(Factory.GetResponse("Inventory/GetSupplierDetails", "supplierId=" + supplierId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static Supplier AddSupplier(Supplier supplier,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<Supplier>(Factory.GetResponse("Inventory/AddSupplier", "supplier=" + Newtonsoft.Json.JsonConvert.SerializeObject(supplier) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void UpdateSupplier(Supplier supplier,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateSupplier", "supplier=" + Newtonsoft.Json.JsonConvert.SerializeObject(supplier) + "", ApiToken, ApiServer); 
}

public static void DeleteSuppliers(List<Guid> suppliersIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteSuppliers", "suppliersIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(suppliersIds) + "", ApiToken, ApiServer); 
}

public static List<StockItemSupplierStat> GetStockSupplierStat(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemSupplierStat>>(Factory.GetResponse("Inventory/GetStockSupplierStat", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void CreateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/CreateStockSupplierStat", "itemSuppliers=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSuppliers) + "", ApiToken, ApiServer); 
}

public static void UpdateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateStockSupplierStat", "itemSuppliers=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSuppliers) + "", ApiToken, ApiServer); 
}

public static void DeleteStockSupplierStat(Guid stockItemId,List<Guid> itemSupplierIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteStockSupplierStat", "stockItemId=" + stockItemId + "&itemSupplierIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(itemSupplierIds) + "", ApiToken, ApiServer); 
}

public static List<StockItemPrice> GetInventoryItemPrices(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemPrice>>(Factory.GetResponse("Inventory/GetInventoryItemPrices", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void CreateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/CreateInventoryItemPrices", "inventoryItemPrices=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPrices) + "", ApiToken, ApiServer); 
}

public static void UpdateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateInventoryItemPrices", "inventoryItemPrices=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPrices) + "", ApiToken, ApiServer); 
}

public static void DeleteInventoryItemPrices(List<Guid> inventoryItemPriceIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteInventoryItemPrices", "inventoryItemPriceIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemPriceIds) + "", ApiToken, ApiServer); 
}

public static List<StockItemDescription> GetInventoryItemDescriptions(Guid inventoryItemId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockItemDescription>>(Factory.GetResponse("Inventory/GetInventoryItemDescriptions", "inventoryItemId=" + inventoryItemId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static void CreateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/CreateInventoryItemDescriptions", "inventoryItemDescriptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptions) + "", ApiToken, ApiServer); 
}

public static void UpdateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/UpdateInventoryItemDescriptions", "inventoryItemDescriptions=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptions) + "", ApiToken, ApiServer); 
}

public static void DeleteInventoryItemDescriptions(List<Guid> inventoryItemDescriptionIds,String ApiToken, String ApiServer)
{
 Factory.GetResponse("Inventory/DeleteInventoryItemDescriptions", "inventoryItemDescriptionIds=" + Newtonsoft.Json.JsonConvert.SerializeObject(inventoryItemDescriptionIds) + "", ApiToken, ApiServer); 
} 
}
}