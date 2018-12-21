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
		public Int32 pkDeliveryRecordId;

        /// <summary>
        /// Purchase item id 
        /// </summary>
		public Guid fkPurchaseItemId;

        /// <summary>
        /// Purchase item location id 
        /// </summary>
		public Guid fkStockLocationId;

        /// <summary>
        /// Unit cost 
        /// </summary>
		public Decimal UnitCost;

        /// <summary>
        /// Quantity delivered 
        /// </summary>
		public Int32 DeliveredQuantity;

        /// <summary>
        /// Record creation date 
        /// </summary>
		public DateTime CreatedDateTime;

        /// <summary>
        /// Record modification date 
        /// </summary>
		public DateTime? ModifiedDateTime;

        /// <summary>
        /// Purchase item batch Id (Optional) 
        /// </summary>
		public Int32? fkBatchInventoryId;
	} 
}