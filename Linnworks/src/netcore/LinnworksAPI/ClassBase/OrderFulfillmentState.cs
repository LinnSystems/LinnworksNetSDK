using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderFulfillmentState : LinnObject
	{
		public FulfillmentState FulfillmentState { get; set; }

		public PurchaseOrderState? PurchaseOrderState { get; set; }
	} 
}