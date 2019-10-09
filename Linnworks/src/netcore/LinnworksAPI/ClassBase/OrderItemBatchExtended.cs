using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemBatchExtended
	{
		public Guid pkOrderId;

		public List<OrderItemBatch> Batches;
	} 
}