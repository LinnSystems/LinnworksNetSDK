using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeliverPurchaseOrderItemResponse : LinnObject
	{
		public PurchaseOrderItem NewPurchaseOrderItem { get; set; }

		public PurchaseOrderHeader PurchaseOrderHeader { get; set; }

		public Int32? BatchInventoryId { get; set; }
	} 
}