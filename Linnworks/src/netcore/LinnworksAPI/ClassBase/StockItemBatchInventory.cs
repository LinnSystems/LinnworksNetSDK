using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemBatchInventory
	{
        /// <summary>
        /// Stock item batch record ID 
        /// </summary>
		public Int32 BatchInventoryId;

        /// <summary>
        /// Batch ID 
        /// </summary>
		public Int32 BatchId;

        /// <summary>
        /// Location ID 
        /// </summary>
		public Guid StockLocationId;

        /// <summary>
        /// BinRack 
        /// </summary>
		public String BinRack;

        /// <summary>
        /// Pick order 
        /// </summary>
		public Int16 PrioritySequence;

        /// <summary>
        /// Quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Current stock value 
        /// </summary>
		public Decimal StockValue;

        /// <summary>
        /// Quantity originally booked in 
        /// </summary>
		public Int32 StartQuantity;

        /// <summary>
        /// Indicate how many units are now allocated in open orders 
        /// </summary>
		public Int32 PickedQuantity;

        /// <summary>
        /// Batch Status 
        /// </summary>
		public String BatchStatus;

        /// <summary>
        /// Is BatchInventory deleted 
        /// </summary>
		public Boolean IsDeleted;
	} 
}