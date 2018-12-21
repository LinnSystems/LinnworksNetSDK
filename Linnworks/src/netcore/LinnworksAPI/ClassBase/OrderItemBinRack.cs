using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// OrderItem BinRack 
    /// </summary>
    public class OrderItemBinRack
	{
        /// <summary>
        /// Quantity for BinRack per Location 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// BinRack 
        /// </summary>
		public String BinRack;

        /// <summary>
        /// LocationId of the BinRack 
        /// </summary>
		public Guid Location;

		public Int32? BatchId;

		public Int32? OrderItemBatchId;
	} 
}