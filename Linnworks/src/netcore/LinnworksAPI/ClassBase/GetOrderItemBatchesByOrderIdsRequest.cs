using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderItemBatchesByOrderIdsRequest
	{
		public List<Guid> pkOrderIds { get; set; }
	} 
}