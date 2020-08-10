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
		public String ItemNumber;

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Barcode number 
        /// </summary>
		public String BarcodeNumber;

        /// <summary>
        /// Item description 
        /// </summary>
		public String MetaData;

        /// <summary>
        /// Returns true is the stock item is tracked by batch 
        /// </summary>
		public Boolean isBatchedStockType;

        /// <summary>
        /// Default item purchase price 
        /// </summary>
		public Double PurchasePrice;

        /// <summary>
        /// Default item retail price 
        /// </summary>
		public Double? RetailPrice;

        /// <summary>
        /// Default item tax rate. Set -1 to use country tax rate 
        /// </summary>
		public Double TaxRate;

        /// <summary>
        /// Default postal service id 
        /// </summary>
		public Guid PostalServiceId;

        /// <summary>
        /// Default postal service name 
        /// </summary>
		public String PostalServiceName;

        /// <summary>
        /// Default category id 
        /// </summary>
		public Guid CategoryId;

        /// <summary>
        /// Default category name 
        /// </summary>
		public String CategoryName;

        /// <summary>
        /// Default package group id 
        /// </summary>
		public Guid PackageGroupId;

        /// <summary>
        /// Default package group name 
        /// </summary>
		public String PackageGroupName;

        /// <summary>
        /// Item height 
        /// </summary>
		public Double Height;

        /// <summary>
        /// Item width 
        /// </summary>
		public Double Width;

        /// <summary>
        /// Item depth 
        /// </summary>
		public Double Depth;

        /// <summary>
        /// Item weight 
        /// </summary>
		public Double Weight;

        /// <summary>
        /// Stock item creation date 
        /// </summary>
		public DateTime? CreationDate;

        /// <summary>
        /// Stock item tracking type. 0 = none. 1 = Ordered by Sell by Date. 2 = Ordered by Priority Sequence 
        /// </summary>
		public Int32 InventoryTrackingType;

        /// <summary>
        /// User must scan batch number when procesing orders 
        /// </summary>
		public Boolean BatchNumberScanRequired;

        /// <summary>
        /// User must scan item serial number when processing ordesr 
        /// </summary>
		public Boolean SerialNumberScanRequired;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}