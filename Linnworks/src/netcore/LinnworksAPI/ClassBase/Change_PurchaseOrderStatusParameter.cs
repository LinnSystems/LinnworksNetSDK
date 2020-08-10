using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Change purchase order status. You can change from PENDING to OPEN, from OPEN to DELIVERED, from PARTIAL to DELIVERED 
    /// </summary>
    public class Change_PurchaseOrderStatusParameter
	{
        /// <summary>
        /// Purchase order uniqueidentifier 
        /// </summary>
		public Guid pkPurchaseId { get; set; }

        /// <summary>
        /// Change purchase order status to the specified value 
        /// </summary>
		public PurchaseOrderStatus status { get; set; }
	} 
}