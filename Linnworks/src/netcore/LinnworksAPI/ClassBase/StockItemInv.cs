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
		public String VariationGroupName { get; set; }

		public String ItemDescription { get; set; }

		public Int32 Quantity { get; set; }

		public Int32 InOrder { get; set; }

		public Int32 Due { get; set; }

		public Int32 MinimumLevel { get; set; }

		public Int32 Available { get; set; }

		public Boolean? IsCompositeParent { get; set; }

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