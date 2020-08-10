using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemSoldStatFinalDetail
	{
        /// <summary>
        /// When stock was sold 
        /// </summary>
		public DateTime Date { get; set; }

        /// <summary>
        /// Quantity of sold stock 
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
        /// Profit margin 
        /// </summary>
		public Double ProfitMargin { get; set; }
	} 
}