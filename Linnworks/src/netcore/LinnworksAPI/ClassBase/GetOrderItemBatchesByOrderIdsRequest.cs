using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderItemBatchesByOrderIdsRequest : LinnObject
	{
		public List<Guid> pkOrderIds { get; set; }
	} 
}