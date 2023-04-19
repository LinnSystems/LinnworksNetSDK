using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetAssignedOrderItemBatchesRequest : LinnObject
	{
		public List<Guid> OrderItemRows { get; set; }
	} 
}