using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Purchase order delivery record 
    /// </summary>
    public class PurchaseOrderDeliveredRecord
	{
        /// <summary>
        /// Delivery record Id 
        /// </summary>
		public Int32 pkDeliveryRecordId { get; set; }

        /// <summary>
        /// Purchase item id 
        /// </summary>
		public Guid fkPurchaseItemId { get; set; }

        /// <summary>
        /// Purchase item location id 
        /// </summary>
		public Guid fkStockLocationId { get; set; }

        /// <summary>
        /// Unit cost 
        /// </summary>
		public Decimal UnitCost { get; set; }

        /// <summary>
        /// Quantity delivered 
        /// </summary>
		public Int32 DeliveredQuantity { get; set; }

        /// <summary>
        /// Record creation date 
        /// </summary>
		public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// Record modification date 
        /// </summary>
		public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Purchase item batch Id (Optional) 
        /// </summary>
		public Int32? fkBatchInventoryId { get; set; }
	} 
}