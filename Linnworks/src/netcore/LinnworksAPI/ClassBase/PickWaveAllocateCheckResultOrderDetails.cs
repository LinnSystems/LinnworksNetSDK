using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Order details return, flat data for order lines that can be used to create pickwaves 
    /// </summary>
    public class PickWaveAllocateCheckResultOrderDetails
	{
        /// <summary>
        /// Location the order resides in 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// Order item row id 
        /// </summary>
		public Guid OrderItemRowId { get; set; }

        /// <summary>
        /// Batch inventory id, if the order item contains batches. 
        /// </summary>
		public Int32? BatchInventoryId { get; set; }

        /// <summary>
        /// Stock item id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Binrack 
        /// </summary>
		public String Binrack { get; set; }

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber { get; set; }

        /// <summary>
        /// Quantity on either order item row or allocated batch row. 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// (WMS only) Routing sequence of the binrack. 
        /// </summary>
		public Int32 RoutingSequence { get; set; }
	} 
}