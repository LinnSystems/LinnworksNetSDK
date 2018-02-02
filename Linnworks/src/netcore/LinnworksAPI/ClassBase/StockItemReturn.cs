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
		public Int32 Year;

        /// <summary>
        /// what month item was returned 
        /// </summary>
		public Int32 Month;

        /// <summary>
        /// Return reason 
        /// </summary>
		public String Reason;

        /// <summary>
        /// Quantity returned 
        /// </summary>
		public Int32 Quantity;

		public Guid StockItemId;
	} 
}