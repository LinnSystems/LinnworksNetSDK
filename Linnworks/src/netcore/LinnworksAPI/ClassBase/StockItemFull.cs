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
		public List<StockItemSupplierStat> Suppliers { get; set; }

        /// <summary>
        /// Stock Levels 
        /// </summary>
		public List<StockItemLevel> StockLevels { get; set; }

        /// <summary>
        /// List of item descriptions 
        /// </summary>
		public List<StockItemDescription> ItemChannelDescriptions { get; set; }

        /// <summary>
        /// List of extended properties 
        /// </summary>
		public List<StockItemExtendedProperty> ItemExtendedProperties { get; set; }

        /// <summary>
        /// List item titles 
        /// </summary>
		public List<StockItemTitle> ItemChannelTitles { get; set; }

        /// <summary>
        /// List of item prices 
        /// </summary>
		public List<StockItemPrice> ItemChannelPrices { get; set; }

        /// <summary>
        /// Image urls 
        /// </summary>
		public List<StockItemImage> Images { get; set; }

		public String ItemNumber { get; set; }

		public String ItemTitle { get; set; }

		public String BarcodeNumber { get; set; }

		public String MetaData { get; set; }

		public Boolean isBatchedStockType { get; set; }

		public Double PurchasePrice { get; set; }

		public Double? RetailPrice { get; set; }

		public Double TaxRate { get; set; }

		public Guid PostalServiceId { get; set; }

		public String PostalServiceName { get; set; }

		public Guid CategoryId { get; set; }

		public String CategoryName { get; set; }

		public Guid PackageGroupId { get; set; }

		public String PackageGroupName { get; set; }

		public Double Height { get; set; }

		public Double Width { get; set; }

		public Double Depth { get; set; }

		public Double Weight { get; set; }

		public DateTime? CreationDate { get; set; }

		public Int32 InventoryTrackingType { get; set; }

		public Boolean BatchNumberScanRequired { get; set; }

		public Boolean SerialNumberScanRequired { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}