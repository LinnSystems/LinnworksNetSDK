using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SearchOrdersResponse : LinnObject
	{
		public OrderViewIds[] OpenOrders { get; set; }

		public HashSet<Guid> ProcessedOrders { get; set; }
	} 
}