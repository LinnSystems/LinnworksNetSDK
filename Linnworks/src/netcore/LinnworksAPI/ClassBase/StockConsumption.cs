using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockConsumption
	{
        /// <summary>
        /// When stock was sold 
        /// </summary>
		public DateTime Date { get; set; }

        /// <summary>
        /// Sold quantity 
        /// </summary>
		public Int32 StockQuantity { get; set; }

        /// <summary>
        /// Current stock value 
        /// </summary>
		public Double StockValue { get; set; }

        /// <summary>
        /// Shipped stock 
        /// </summary>
		public Int32 Shipped { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}