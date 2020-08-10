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
		public Int32? BinRackId;

        /// <summary>
        /// Bin Rack type name 
        /// </summary>
		public Int32? StandardType;

        /// <summary>
        /// Batch id 
        /// </summary>
		public Int32? BatchId;

        /// <summary>
        /// Batch inventory id 
        /// </summary>
		public Int32? BatchInventoryId;

        /// <summary>
        /// Consume priority sequence 
        /// </summary>
		public Int32? PrioritySequence;

        /// <summary>
        /// Batch status, "Available", "Restricted", "Damaged", "Expired" 
        /// </summary>
		public String BatchStatus;

        /// <summary>
        /// BinRack name 
        /// </summary>
		public String BinRack;

        /// <summary>
        /// Maximum volumetric capacity of the location WxDxH = volumetric 
        /// </summary>
		public Decimal CurrentFullPercentage;

        /// <summary>
        /// Quantity available in the location 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Quantity of items currently in transit 
        /// </summary>
		public Int32? InTransit;

        /// <summary>
        /// Indicate how many units are now allocated in open orders 
        /// </summary>
		public Int32? PickedQuantity;

        /// <summary>
        /// 0 - None, 1 - Order by sell by date, 2 - Ordered by priority sequence 
        /// </summary>
		public Int32? InventoryTrackingType;

        /// <summary>
        /// Product ID 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber;

        /// <summary>
        /// Batch expiry date 
        /// </summary>
		public DateTime? ExpiresOn;

        /// <summary>
        /// Batch sell by date 
        /// </summary>
		public DateTime? SellBy;

		public String BinrackTypeName;

		public Guid LocationId;
	} 
}