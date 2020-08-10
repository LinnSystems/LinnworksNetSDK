using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderItemBatchesByOrderIdsResponse
	{
		public List<OrderItemBatchExtended> OrderBatches { get; set; }
	} 
}