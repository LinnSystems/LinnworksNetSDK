using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderPackagingSplitItem
	{
        /// <summary>
        /// The batches that make up this row 
        /// </summary>
		public List<OrderItemShippingBatchWithRow> AssignedBatches { get; set; }

		public Guid RowId { get; set; }

		public Int32? BoxId { get; set; }

		public Int32 Quantity { get; set; }

		public String TrackingNumber { get; set; }

		public Decimal Weight { get; set; }

		public String SKU { get; set; }

		public String Title { get; set; }

        /// <summary>
        /// Is the order item batched 
        /// </summary>
		public Boolean IsBatched { get; set; }
	} 
}