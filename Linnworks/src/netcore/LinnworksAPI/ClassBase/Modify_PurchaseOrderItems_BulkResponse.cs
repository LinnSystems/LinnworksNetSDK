using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response class for Modify_PurchaseOrderItems_Bulk 
    /// </summary>
    public class Modify_PurchaseOrderItems_BulkResponse
	{
        /// <summary>
        /// Modified purchase order items. Newly added items, updated items. Deleted items not returned back to the client. 
        /// </summary>
		public List<ModifiedPurchaseOrderItem> ModifiedItems { get; set; }

        /// <summary>
        /// Recalculated purchase order header 
        /// </summary>
		public PurchaseOrderHeader PurchaseOrderHeader { get; set; }
	} 
}