using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PurchaseOrderDeliveredItem : LinnObject
	{
		public Guid pkPurchaseItemId { get; set; }

		public Int32 QuantityDelivered { get; set; }
	} 
}