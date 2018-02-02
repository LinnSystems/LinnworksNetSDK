using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemInv
	{
        /// <summary>
        /// Variation parent group name 
        /// </summary>
		public String VariationGroupName;

		public Int32 Quantity;

		public Int32 InOrder;

		public Int32 Due;

		public Int32 MinimumLevel;

		public Int32 Available;

		public DateTime? CreationDate;

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

		public Int32 InventoryTrackingType;

		public Boolean BatchNumberScanRequired;

		public Boolean SerialNumberScanRequired;

		public Guid StockItemId;
	} 
}