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
		public Guid LinkedStockItemId;

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Product quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Item purchase price 
        /// </summary>
		public Double PurchasePrice;

        /// <summary>
        /// Tracking type of an item 
        /// </summary>
		public Byte InventoryTrackingType;

		public Double DimHeight;

		public Double DimWidth;

		public Double DimDepth;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}