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
		public Int32 ShippingOrderItemId;

        /// <summary>
        /// Package Id 
        /// </summary>
		public Guid BinId;

        /// <summary>
        /// Order Item Id 
        /// </summary>
		public Guid fkOrderItemId;

        /// <summary>
        /// Item Part Id 
        /// </summary>
		public Int32? BoxId;

		public Int32 Quantity;
	} 
}