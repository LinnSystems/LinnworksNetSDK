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
		public Int32 Quantity { get; set; }

        /// <summary>
        /// BinRack 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// LocationId of the BinRack 
        /// </summary>
		public Guid Location { get; set; }

        /// <summary>
        /// If the item is batched, identifies the batch number 
        /// </summary>
		public Int32? BatchId { get; set; }

        /// <summary>
        /// If the item is batched, identifies the unique order item batch row 
        /// </summary>
		public Int32? OrderItemBatchId { get; set; }
	} 
}