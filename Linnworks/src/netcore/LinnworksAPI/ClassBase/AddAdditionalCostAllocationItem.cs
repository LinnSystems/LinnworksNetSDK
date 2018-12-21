using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddAdditionalCostAllocationItem
	{
        /// <summary>
        /// Specific purchase order line id the cost is attributed to 
        /// </summary>
		public Guid PurchaseItemId;

		public Guid Id;

		public Int32 PurchaseAdditionalCostItemId;

		public Decimal AllocationPercentage;
	} 
}