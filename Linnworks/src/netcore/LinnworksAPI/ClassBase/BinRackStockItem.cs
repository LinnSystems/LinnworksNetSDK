using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Bin Rack 
    /// </summary>
    public class BinRackStockItem
	{
        /// <summary>
        /// Unique id for the binrack 
        /// </summary>
		public Int32? BinRackId { get; set; }

        /// <summary>
        /// Bin Rack type name 
        /// </summary>
		public Int32? StandardType { get; set; }

        /// <summary>
        /// Batch id 
        /// </summary>
		public Int32? BatchId { get; set; }

        /// <summary>
        /// Batch inventory id 
        /// </summary>
		public Int32? BatchInventoryId { get; set; }

        /// <summary>
        /// Consume priority sequence 
        /// </summary>
		public Int32? PrioritySequence { get; set; }

        /// <summary>
        /// Batch status, "Available", "Restricted", "Damaged", "Expired" 
        /// </summary>
		public String BatchStatus { get; set; }

        /// <summary>
        /// BinRack name 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// Maximum volumetric capacity of the location WxDxH = volumetric 
        /// </summary>
		public Decimal CurrentFullPercentage { get; set; }

        /// <summary>
        /// Quantity available in the location 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Quantity of items currently in transit 
        /// </summary>
		public Int32? InTransit { get; set; }

        /// <summary>
        /// Indicate how many units are now allocated in open orders 
        /// </summary>
		public Int32? PickedQuantity { get; set; }

        /// <summary>
        /// 0 - None, 1 - Order by sell by date, 2 - Ordered by priority sequence 
        /// </summary>
		public Int32? InventoryTrackingType { get; set; }

        /// <summary>
        /// Product ID 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber { get; set; }

        /// <summary>
        /// Batch expiry date 
        /// </summary>
		public DateTime? ExpiresOn { get; set; }

        /// <summary>
        /// Batch sell by date 
        /// </summary>
		public DateTime? SellBy { get; set; }

		public String BinrackTypeName { get; set; }

		public Guid LocationId { get; set; }
	} 
}