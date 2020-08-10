using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response from delivering all items in an open/partial PO except Batch itesm 
    /// </summary>
    public class Deliver_PurchaseOrderItemAllNoBatchResponse
	{
        /// <summary>
        /// Delivered items and Recalculated purchase order header 
        /// </summary>
		public Deliver_PurchaseOrderItemAllResponse poHeaderAndItems { get; set; }

        /// <summary>
        /// Set to true if all items in the PO have been marked as delivered 
        /// </summary>
		public Boolean allItemsDelivered { get; set; }

        /// <summary>
        /// Informs customers why not all items have been marked as delivered 
        /// </summary>
		public String message { get; set; }
	} 
}