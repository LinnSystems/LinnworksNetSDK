using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SearchProcessedOrdersResponse : LinnObject
	{
		public GenericPagedResult<ProcessedOrderWeb> ProcessedOrders { get; set; }
	} 
}