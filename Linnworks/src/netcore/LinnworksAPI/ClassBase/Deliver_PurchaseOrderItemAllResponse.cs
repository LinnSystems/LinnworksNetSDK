using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response from delivering all items in an open/partial PO 
    /// </summary>
    public class Deliver_PurchaseOrderItemAllResponse : LinnObject
	{
        /// <summary>
        /// Delivered items 
        /// </summary>
		public List<CommonPurchaseOrderItem> PurchaseOrderItems { get; set; }

        /// <summary>
        /// Recalculated purchase order header 
        /// </summary>
		public CommonPurchaseOrderHeader PurchaseOrderHeader { get; set; }
	} 
}