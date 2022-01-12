using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseMoveDetailed
	{
        /// <summary>
        /// Moving from bin rack 
        /// </summary>
		public WarehouseBinRack BinrackFrom { get; set; }

        /// <summary>
        /// Destination if known, otherwise will be null 
        /// </summary>
		public WarehouseBinRack BinrackDestination { get; set; }

        /// <summary>
        /// Detailed batch information, batch inventory is in Inventory class 
        /// </summary>
		public StockItemBatch Batch { get; set; }

		public Int32 MoveId { get; set; }

		public Int32 BatchInventoryId { get; set; }

		public Int32 Quantity { get; set; }

		public Guid UserId { get; set; }

		public String UserName { get; set; }

		public Int32 BinrackIdFrom { get; set; }

		public Int32? BinrackIdDestination { get; set; }

		public TransactionType TxType { get; set; }

		public Int32? JobId { get; set; }

		public DateTime CreateDate { get; set; }

		public Int32 BatchId { get; set; }

		public Guid StockLocationId { get; set; }

		public Int32? TotId { get; set; }
	} 
}