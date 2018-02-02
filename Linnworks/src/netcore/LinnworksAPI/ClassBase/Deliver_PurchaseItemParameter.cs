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
		public String BatchNumber;

        /// <summary>
        /// If defined, this value will be used to apply the delivery to a batch 
        /// </summary>
		public String BinRack;

        /// <summary>
        /// If defined, this value will be used to apply the delivery to a batch 
        /// </summary>
		public Int32 PrioritySequence;

        /// <summary>
        /// If defined, this value will be used to apply the delivery to a batch 
        /// </summary>
		public String BatchStatus;

        /// <summary>
        /// Purchase order unique identifier 
        /// </summary>
		public Guid pkPurchaseId;

        /// <summary>
        /// Purchase order item unique record identifier 
        /// </summary>
		public Guid pkPurchaseItemId;

        /// <summary>
        /// Exact quantity of items delivered. If AddToDelivered is specified this value must be null 
        /// </summary>
		public Int32? Delivered;

        /// <summary>
        /// Add quantity to delivered. If Delivered is specified this value must be null 
        /// </summary>
		public Int32? AddToDelivered;
	} 
}