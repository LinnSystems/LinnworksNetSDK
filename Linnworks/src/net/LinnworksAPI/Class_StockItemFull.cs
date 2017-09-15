using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StockItemFull
    {
        public List<StockItemSupplierStat> Suppliers;
        public List<StockItemLevel> StockLevels;
        public List<StockItemDescription> ItemChannelDescriptions;
        public List<StockItemExtendedProperty> ItemExtendedProperties;
        public List<StockItemTitle> ItemChannelTitles;
        public List<StockItemPrice> ItemChannelPrices;
        public List<StockItemImage> Images;
        public String ItemNumber;
        public String ItemTitle;
        public String BarcodeNumber;
        public String MetaData;
        public Boolean isBatchedStockType;
        public Double PurchasePrice;
        public Double? RetailPrice;
        public Double TaxRate;
        public Guid PostalServiceId;
        public String PostalServiceName;
        public Guid CategoryId;
        public String CategoryName;
        public Guid PackageGroupId;
        public String PackageGroupName;
        public Double Height;
        public Double Width;
        public Double Depth;
        public Double Weight;
        public DateTime? CreationDate;
        public Int32 InventoryTrackingType;
        public Boolean BatchNumberScanRequired;
        public Boolean SerialNumberScanRequired;
        public Guid StockItemId;
    }
}