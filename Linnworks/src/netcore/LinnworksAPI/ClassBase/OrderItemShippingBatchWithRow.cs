using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemShippingBatchWithRow
	{
		public Guid OrderItemRowId { get; set; }

		public String BatchNumber { get; set; }

		public Guid fkBinId { get; set; }

		public Int32 fkOrderItemBatchId { get; set; }

		public Int32 Quantity { get; set; }
	} 
}