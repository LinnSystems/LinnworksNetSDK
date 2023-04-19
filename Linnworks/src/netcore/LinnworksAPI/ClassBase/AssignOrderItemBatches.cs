using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AssignOrderItemBatches : LinnObject
	{
		public List<OrderItemBatch> Batches { get; set; }

		public Guid OrderId { get; set; }
	} 
}