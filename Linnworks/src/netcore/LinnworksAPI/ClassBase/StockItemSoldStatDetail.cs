using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemSoldStatDetail
	{
        /// <summary>
        /// Subsource (e.g EBAY1) 
        /// </summary>
		public String Subsource { get; set; }

        /// <summary>
        /// Quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Total price stock was sold for 
        /// </summary>
		public Double Total { get; set; }

        /// <summary>
        /// Total cost of sold stock 
        /// </summary>
		public Double Cost { get; set; }

        /// <summary>
        /// Profit margine 
        /// </summary>
		public Double ProfitMargin { get; set; }

        /// <summary>
        /// List of sold stock item information details 
        /// </summary>
		public List<StockItemSoldStatFinalDetail> Detail { get; set; }
	} 
}