using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PurchaseOrderItemOpenOrder
	{
        /// <summary>
        /// Bound id 
        /// </summary>
		public Int32 RowId;

        /// <summary>
        /// Open order number 
        /// </summary>
		public Int32 NumOrderId;

        /// <summary>
        /// Open order customer name 
        /// </summary>
		public String FullName;

        /// <summary>
        /// Open order dispatch date 
        /// </summary>
		public DateTime DispatchBy;

        /// <summary>
        /// Open order id 
        /// </summary>
		public Guid pkOrderId;

        /// <summary>
        /// Open order location 
        /// </summary>
		public Guid FulfillmentLocationId;

        /// <summary>
        /// Order the items was bount to PO 
        /// </summary>
		public Int32 Order;
	} 
}