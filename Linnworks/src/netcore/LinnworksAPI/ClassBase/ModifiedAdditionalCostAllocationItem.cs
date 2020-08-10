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
		public Guid Id { get; set; }

		public Int32 CostAllocationId { get; set; }

		public Int32 PurchaseAdditionalCostItemId { get; set; }

		public Guid PurchaseItemId { get; set; }

		public Decimal AllocationPercentage { get; set; }
	} 
}