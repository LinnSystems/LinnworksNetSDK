using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ModifiedAdditionalCostAllocationItem
	{
        /// <summary>
        /// Relation to the initial request. This Id will match to what was specified in the request so that the client side can be updated with new CostAllocationIds 
        /// </summary>
		public Guid Id;

		public Int32 CostAllocationId;

		public Int32 PurchaseAdditionalCostItemId;

		public Guid PurchaseItemId;

		public Decimal AllocationPercentage;
	} 
}