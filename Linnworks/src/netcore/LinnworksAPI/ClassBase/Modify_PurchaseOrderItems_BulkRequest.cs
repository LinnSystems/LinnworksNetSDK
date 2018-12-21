using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request that contains lists to delete, add and update purchase order items 
    /// </summary>
    public class Modify_PurchaseOrderItems_BulkRequest
	{
        /// <summary>
        /// Purchase order id 
        /// </summary>
		public Guid PurchaseId;

        /// <summary>
        /// New purchase order items to add 
        /// </summary>
		public List<AddPurchaseOrderItem> ItemsToAdd;

        /// <summary>
        /// Purchase order items to update 
        /// </summary>
		public List<UpdatePurchaseOrderItem> ItemsToUpdate;

        /// <summary>
        /// Purchase order items to delete. PurchaseOrderItemId(s) 
        /// </summary>
		public List<Guid> ItemsToDelete;
	} 
}