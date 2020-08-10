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
		public Int32 Year;

        /// <summary>
        /// Month item was scraped 
        /// </summary>
		public Int32 Month;

        /// <summary>
        /// Reason item was scrapped 
        /// </summary>
		public String Reason;

        /// <summary>
        /// Scraped quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Cost of scraped item 
        /// </summary>
		public Double Cost;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}