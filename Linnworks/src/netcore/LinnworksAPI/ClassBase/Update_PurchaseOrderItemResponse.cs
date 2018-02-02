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
		public PurchaseOrderItem NewPurchaseOrderItem;

        /// <summary>
        /// Recalculated purchase order header 
        /// </summary>
		public PurchaseOrderHeader PurchaseOrderHeader;
	} 
}