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
		public Int32 CostAllocationId;

		public Guid Id;

		public Int32 PurchaseAdditionalCostItemId;

		public Decimal AllocationPercentage;
	} 
}