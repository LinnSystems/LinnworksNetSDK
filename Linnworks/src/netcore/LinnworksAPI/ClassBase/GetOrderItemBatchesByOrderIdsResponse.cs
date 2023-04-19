using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderItemBatchesByOrderIdsResponse : LinnObject
	{
		public List<OrderItemBatchExtended> OrderBatches { get; set; }
	} 
}