using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Deliver_PurchaseItems_WithQuantityRequest
	{
		public Guid pkPurchaseId;

		public List<PODeliveredItems> Items;
	} 
}