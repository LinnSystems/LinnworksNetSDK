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
        /// Bin Item Id 
        /// </summary>
		public Int32 ShippingOrderItemId { get; set; }

        /// <summary>
        /// Package Id 
        /// </summary>
		public Guid BinId { get; set; }

        /// <summary>
        /// Order Item Id 
        /// </summary>
		public Guid fkOrderItemId { get; set; }

        /// <summary>
        /// Item Part Id 
        /// </summary>
		public Int32? BoxId { get; set; }

		public Int32 Quantity { get; set; }
	} 
}