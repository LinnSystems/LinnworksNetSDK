using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemSold : LinnObject
	{
        /// <summary>
        /// Sold quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Item SKU 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}