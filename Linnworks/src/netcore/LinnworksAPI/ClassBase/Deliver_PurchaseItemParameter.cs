using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Add/change delivered quantity on the purchase order item. The PO status will automatically be changed to PARTIAL or DELIVERED 
        /// You can use Delivered parameter to specify exact quantity of items delivered or 
        /// AddToDelivered to add quantity to delivered 
    /// </summary>
    public class Deliver_PurchaseItemParameter
	{
        /// <summary>
        /// If defined, this value will be used to apply the delivery to a batch 
        /// </summary>
		public String BatchNumber { get; set; }

        /// <summary>
        /// If defined, this value will be used to apply the delivery to a batch 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// If defined, this value will be used to apply the delivery to a batch only when the batch in the provided binrack did not exist before. 
        /// </summary>
		public Int32 PrioritySequence { get; set; }

        /// <summary>
        /// If defined, this value will be used to apply the delivery to a batch 
        /// </summary>
		public String BatchStatus { get; set; }

        /// <summary>
        /// Purchase order unique identifier 
        /// </summary>
		public Guid pkPurchaseId { get; set; }

        /// <summary>
        /// Purchase order item unique record identifier 
        /// </summary>
		public Guid pkPurchaseItemId { get; set; }

        /// <summary>
        /// Exact quantity of items delivered. If AddToDelivered is specified this value must be null 
        /// </summary>
		public Int32? Delivered { get; set; }

        /// <summary>
        /// Add quantity to delivered. If Delivered is specified this value must be null 
        /// </summary>
		public Int32? AddToDelivered { get; set; }
	} 
}