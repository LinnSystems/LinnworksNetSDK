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
		public String ItemNumber { get; set; }

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Item quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// BinRack location 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber { get; set; }

		public Int32 BatchInventoryId { get; set; }

		public Guid LocationId { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}