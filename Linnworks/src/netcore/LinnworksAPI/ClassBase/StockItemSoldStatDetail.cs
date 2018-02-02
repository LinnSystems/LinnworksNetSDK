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
		public String Subsource;

        /// <summary>
        /// Quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Total price stock was sold for 
        /// </summary>
		public Double Total;

        /// <summary>
        /// Total cost of sold stock 
        /// </summary>
		public Double Cost;

        /// <summary>
        /// Profit margine 
        /// </summary>
		public Double ProfitMargin;

        /// <summary>
        /// List of sold stock item information details 
        /// </summary>
		public List<StockItemSoldStatFinalDetail> Detail;
	} 
}