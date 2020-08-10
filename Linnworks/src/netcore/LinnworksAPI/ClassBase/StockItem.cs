using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Stock Item 
    /// </summary>
    public class StockItem
	{
        /// <summary>
        /// Item Description(Metadata) 
        /// </summary>
		public String ItemDescription;

        /// <summary>
        /// Quantity in stock 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Quantity in order book 
        /// </summary>
		public Int32 InOrder;

        /// <summary>
        /// Quantity due in purchase orders 
        /// </summary>
		public Int32 Due;

        /// <summary>
        /// Minimum level of stock item. -1 is not tracked 
        /// </summary>
		public Int32 MinimumLevel;

        /// <summary>
        /// Available level. Quantity - InOrder 
        /// </summary>
		public Int32 Available;

        /// <summary>
        /// Item is a composite parent 
        /// </summary>
		public Boolean? IsCompositeParent;

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