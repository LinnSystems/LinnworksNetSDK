using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemComposition
	{
        /// <summary>
        /// Stock item ID of linked product 
        /// </summary>
		public Guid LinkedStockItemId { get; set; }

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Product quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Item purchase price 
        /// </summary>
		public Double PurchasePrice { get; set; }

        /// <summary>
        /// Tracking type of an item 
        /// </summary>
		public Byte InventoryTrackingType { get; set; }

		public Double DimHeight { get; set; }

		public Double DimWidth { get; set; }

		public Double DimDepth { get; set; }

		public Double Weight { get; set; }

		public Guid PackageGroupId { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}