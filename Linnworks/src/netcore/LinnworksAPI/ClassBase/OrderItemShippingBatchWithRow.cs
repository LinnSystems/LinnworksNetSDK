using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemShippingBatchWithRow
	{
		public Guid OrderItemRowId;

		public String BatchNumber;

		public Guid fkBinId;

		public Int32 fkOrderItemBatchId;

		public Int32 Quantity;
	} 
}