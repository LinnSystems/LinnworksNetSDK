using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Stock Item header information 
    /// </summary>
    public class StockItemHeader
	{
        /// <summary>
        /// SKU 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Barcode number 
        /// </summary>
		public String BarcodeNumber { get; set; }

        /// <summary>
        /// Item description 
        /// </summary>
		public String MetaData { get; set; }

        /// <summary>
        /// Returns true is the stock item is tracked by batch 
        /// </summary>
		public Boolean isBatchedStockType { get; set; }

        /// <summary>
        /// Default item purchase price 
        /// </summary>
		public Double PurchasePrice { get; set; }

        /// <summary>
        /// Default item retail price 
        /// </summary>
		public Double? RetailPrice { get; set; }

        /// <summary>
        /// Default item tax rate. Set -1 to use country tax rate 
        /// </summary>
		public Double TaxRate { get; set; }

        /// <summary>
        /// Default postal service id 
        /// </summary>
		public Guid PostalServiceId { get; set; }

        /// <summary>
        /// Default postal service name 
        /// </summary>
		public String PostalServiceName { get; set; }

        /// <summary>
        /// Default category id 
        /// </summary>
		public Guid CategoryId { get; set; }

        /// <summary>
        /// Default category name 
        /// </summary>
		public String CategoryName { get; set; }

        /// <summary>
        /// Default package group id 
        /// </summary>
		public Guid PackageGroupId { get; set; }

        /// <summary>
        /// Default package group name 
        /// </summary>
		public String PackageGroupName { get; set; }

        /// <summary>
        /// Item height 
        /// </summary>
		public Double Height { get; set; }

        /// <summary>
        /// Item width 
        /// </summary>
		public Double Width { get; set; }

        /// <summary>
        /// Item depth 
        /// </summary>
		public Double Depth { get; set; }

        /// <summary>
        /// Item weight 
        /// </summary>
		public Double Weight { get; set; }

        /// <summary>
        /// Stock item creation date 
        /// </summary>
		public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Stock item tracking type. 0 = none. 1 = Ordered by Sell by Date. 2 = Ordered by Priority Sequence 
        /// </summary>
		public Int32 InventoryTrackingType { get; set; }

        /// <summary>
        /// User must scan batch number when procesing orders 
        /// </summary>
		public Boolean BatchNumberScanRequired { get; set; }

        /// <summary>
        /// User must scan item serial number when processing ordesr 
        /// </summary>
		public Boolean SerialNumberScanRequired { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}