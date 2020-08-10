using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Delete purchase order item parameter. Purchase order items can only be deleted from PENDING Purchase Orders. Once PO is open, no modifications can be done 
    /// </summary>
    public class Delete_PurchaseOrderItemParameter
	{
        /// <summary>
        /// Purchase order item unique row identifier 
        /// </summary>
		public Guid pkPurchaseItemId { get; set; }

        /// <summary>
        /// Purchase order id 
        /// </summary>
		public Guid pkPurchaseId { get; set; }
	} 
}