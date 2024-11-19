using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CommonPurchaseOrderAdditionalCostAllocation : LinnObject
	{
		public Int32 CostAllocationId { get; set; }

		public Int32 PurchaseAdditionalCostItemId { get; set; }

		public Guid PurchaseItemId { get; set; }

		public Decimal AllocationPercentage { get; set; }
	} 
}