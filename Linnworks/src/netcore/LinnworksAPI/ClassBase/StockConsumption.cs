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
		public DateTime Date;

        /// <summary>
        /// Sold quantity 
        /// </summary>
		public Int32 StockQuantity;

        /// <summary>
        /// Current stock value 
        /// </summary>
		public Double StockValue;

        /// <summary>
        /// Shipped stock 
        /// </summary>
		public Int32 Shipped;

		public Guid StockItemId;
	} 
}