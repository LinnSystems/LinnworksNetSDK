using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateAdditionalCostAllocationItem
	{
        /// <summary>
        /// Allocation row id that will be updated with the new AllocationPercentage 
        /// </summary>
		public Int32 CostAllocationId { get; set; }

		public Guid Id { get; set; }

		public Int32 PurchaseAdditionalCostItemId { get; set; }

		public Decimal AllocationPercentage { get; set; }
	} 
}