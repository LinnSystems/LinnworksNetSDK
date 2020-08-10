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
		public Int32 BatchInventoryId { get; set; }

        /// <summary>
        /// Batch ID 
        /// </summary>
		public Int32 BatchId { get; set; }

        /// <summary>
        /// Location ID 
        /// </summary>
		public Guid StockLocationId { get; set; }

        /// <summary>
        /// BinRack 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// Pick order 
        /// </summary>
		public Int32 PrioritySequence { get; set; }

        /// <summary>
        /// Quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Current stock value 
        /// </summary>
		public Decimal StockValue { get; set; }

        /// <summary>
        /// Quantity originally booked in 
        /// </summary>
		public Int32 StartQuantity { get; set; }

        /// <summary>
        /// Indicate how many units are now allocated in open orders 
        /// </summary>
		public Int32 PickedQuantity { get; set; }

        /// <summary>
        /// Batch Status 
        /// </summary>
		public String BatchStatus { get; set; }

        /// <summary>
        /// Is BatchInventory deleted 
        /// </summary>
		public Boolean IsDeleted { get; set; }

        /// <summary>
        /// Warehouse binrack standard type 
        /// </summary>
		public Int32? WarehouseBinrackStandardType { get; set; }

        /// <summary>
        /// Warehouse binrack type friendly name 
        /// </summary>
		public String WarehouseBinrackTypeName { get; set; }

        /// <summary>
        /// Number of items in Transfer phase. 
        /// </summary>
		public Int32? InTransfer { get; set; }

        /// <summary>
        /// Binrack Id (Use for WMS) 
        /// </summary>
		public Int32? BinRackId { get; set; }

        /// <summary>
        /// Warehouse binrack type unique id. 
        /// </summary>
		public Int32? WarehouseBinrackTypeId { get; set; }
	} 
}