using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemBatchExtended
	{
		public Guid pkOrderId;

		public Guid OrderId;

		public List<OrderItemBatch> Batches;
	} 
}