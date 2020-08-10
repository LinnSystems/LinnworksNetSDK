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
		public Int32 RowId { get; set; }

        /// <summary>
        /// Open order number 
        /// </summary>
		public Int32 NumOrderId { get; set; }

        /// <summary>
        /// Open order customer name 
        /// </summary>
		public String FullName { get; set; }

        /// <summary>
        /// Open order dispatch date 
        /// </summary>
		public DateTime DispatchBy { get; set; }

        /// <summary>
        /// Open order id 
        /// </summary>
		public Guid pkOrderId { get; set; }

        /// <summary>
        /// Open order location 
        /// </summary>
		public Guid FulfillmentLocationId { get; set; }

        /// <summary>
        /// Order the items was bount to PO 
        /// </summary>
		public Int32 Order { get; set; }
	} 
}