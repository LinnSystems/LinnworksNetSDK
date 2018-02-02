using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemLabel
	{
        /// <summary>
        /// Product SKU 
        /// </summary>
		public String ItemNumber;

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Item quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// BinRack location 
        /// </summary>
		public String BinRack;

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber;

		public Int32 BatchInventoryId;

		public Guid StockItemId;
	} 
}