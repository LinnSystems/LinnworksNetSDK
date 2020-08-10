using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemSold
	{
        /// <summary>
        /// Sold quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Item SKU 
        /// </summary>
		public String ItemNumber;

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}