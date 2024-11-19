using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeliverPurchaseOrderItemRequest : LinnObject
	{
		public String BatchNumber { get; set; }

		public String BinRack { get; set; }

		public Int32 PrioritySequence { get; set; }

		public String BatchStatus { get; set; }

		public Guid pkPurchaseId { get; set; }

		public Guid pkPurchaseItemId { get; set; }

		public Int32? Delivered { get; set; }

		public Int32? AddToDelivered { get; set; }

		public Int32? DeliveryId { get; set; }
	} 
}