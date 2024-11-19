using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CommonPurchaseOrderDeliveredRecord : LinnObject
	{
		public Int32 pkDeliveryRecordId { get; set; }

		public Guid fkPurchaseItemId { get; set; }

		public Guid fkStockLocationId { get; set; }

		public Decimal UnitCost { get; set; }

		public Int32 DeliveredQuantity { get; set; }

		public DateTime CreatedDateTime { get; set; }

		public DateTime? ModifiedDateTime { get; set; }

		public Int32? fkBatchInventoryId { get; set; }
	} 
}