using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeliverAllPurchaseOrderItemsRequest : LinnObject
	{
		public Guid pkPurchaseId { get; set; }

		public Int32? DeliveryId { get; set; }

		public List<PurchaseOrderDeliveredItem> Items { get; set; }
	} 
}