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
		public Guid PurchaseItemId { get; set; }

		public Guid Id { get; set; }

		public Int32 PurchaseAdditionalCostItemId { get; set; }

		public Decimal AllocationPercentage { get; set; }
	} 
}