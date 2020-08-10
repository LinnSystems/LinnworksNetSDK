using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response from update/add purchase order item, contains newly added purchase order item line and Purchase order header with recaluclated totals 
    /// </summary>
    public class Update_PurchaseOrderItemResponse
	{
        /// <summary>
        /// Newly added purchase order line 
        /// </summary>
		public PurchaseOrderItem NewPurchaseOrderItem { get; set; }

        /// <summary>
        /// Recalculated purchase order header 
        /// </summary>
		public PurchaseOrderHeader PurchaseOrderHeader { get; set; }

        /// <summary>
        /// If the item was batched or booked into a WMS location, this is the batch inventory id for the booked in stock. 
        /// If an item was not delivered or was a non batched item, this will be null. 
        /// </summary>
		public Int32? BatchInventoryId { get; set; }
	} 
}