using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemScrap
	{
        /// <summary>
        /// Year item was scraped 
        /// </summary>
		public Int32 Year { get; set; }

        /// <summary>
        /// Month item was scraped 
        /// </summary>
		public Int32 Month { get; set; }

        /// <summary>
        /// Reason item was scrapped 
        /// </summary>
		public String Reason { get; set; }

        /// <summary>
        /// Scraped quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Cost of scraped item 
        /// </summary>
		public Double Cost { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}