using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents order item in the bin 
    /// </summary>
    public class CalcBinItem
	{
        /// <summary>
        /// Unique order item row id 
        /// </summary>
		public Guid fkOrderItemId;

        /// <summary>
        /// Quantity of items in the bin 
        /// </summary>
		public Int32 Quantity;
	} 
}