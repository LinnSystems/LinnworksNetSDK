using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateSerialisedValuesForOrderItemsRequest : LinnObject
	{
		public List<OrderItemSerialModel> OrderItemSerialData { get; set; }
	} 
}