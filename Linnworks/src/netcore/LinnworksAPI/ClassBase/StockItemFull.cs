using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Stock item with full level and supplier information 
    /// </summary>
    public class StockItemFull
	{
        /// <summary>
        /// Suppliers 
        /// </summary>
		public List<StockItemSupplierStat> Suppliers;

        /// <summary>
        /// Stock Levels 
        /// </summary>
		public List<StockItemLevel> StockLevels;

        /// <summary>
        /// List of item descriptions 
        /// </summary>
		public List<StockItemDescription> ItemChannelDescriptions;

        /// <summary>
        /// List of extended properties 
        /// </summary>
		public List<StockItemExtendedProperty> ItemExtendedProperties;

        /// <summary>
        /// List item titles 
        /// </summary>
		public List<StockItemTitle> ItemChannelTitles;

        /// <summary>
        /// List of item prices 
        /// </summary>
		public List<StockItemPrice> ItemChannelPrices;

        /// <summary>
        /// Image urls 
        /// </summary>
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

		public Int32 StockItemIntId;
	} 
}