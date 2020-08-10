using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Additional cost allocation item. Absence of an item means the cost is auto allocated equaly. If the cost allocation is specified the percentage is allocated to a specific PO line. If the cost allocation is 0%, means the cost not contribuiting to PO line 
    /// </summary>
    public class PurchaseOrderAdditionalCostAllocation
	{
        /// <summary>
        /// Allocation row id. Use this Id to update or delete specific record. 
        /// </summary>
		public Int32 CostAllocationId { get; set; }

        /// <summary>
        /// Relation to additional cost line 
        /// </summary>
		public Int32 PurchaseAdditionalCostItemId { get; set; }

        /// <summary>
        /// Specific purchase order line id the cost is attributed to 
        /// </summary>
		public Guid PurchaseItemId { get; set; }

        /// <summary>
        /// Percentage of the cost that will be attributed to Purchase order item id 
        /// </summary>
		public Decimal AllocationPercentage { get; set; }
	} 
}