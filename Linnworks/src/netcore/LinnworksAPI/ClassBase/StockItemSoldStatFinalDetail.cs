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
		public DateTime Date;

        /// <summary>
        /// Quantity of sold stock 
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
        /// Profit margin 
        /// </summary>
		public Double ProfitMargin;
	} 
}