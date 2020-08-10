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
		public List<OrderItemShippingBatchWithRow> AssignedBatches;

		public Guid RowId;

		public Int32? BoxId;

		public Int32 Quantity;

		public String TrackingNumber;

		public Decimal Weight;

		public String SKU;

		public String Title;

        /// <summary>
        /// Is the order item batched 
        /// </summary>
		public Boolean IsBatched;
	} 
}