using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemReturn
	{
        /// <summary>
        /// What year it was returned 
        /// </summary>
		public Int32 Year { get; set; }

        /// <summary>
        /// what month item was returned 
        /// </summary>
		public Int32 Month { get; set; }

        /// <summary>
        /// Return reason 
        /// </summary>
		public String Reason { get; set; }

        /// <summary>
        /// Quantity returned 
        /// </summary>
		public Int32 Quantity { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}