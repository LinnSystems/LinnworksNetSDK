using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetSerialisedValuesForOrdersResponse : LinnObject
	{
		public Dictionary<Guid,List<OrderItemSerialModel>> OrderItemRowSerialValuesByOrderIds { get; set; }
	} 
}