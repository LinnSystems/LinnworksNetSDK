using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemBatchExtended
	{
		public Guid pkOrderId { get; set; }

		public Guid OrderId { get; set; }

		public List<OrderItemBatch> Batches { get; set; }
	} 
}