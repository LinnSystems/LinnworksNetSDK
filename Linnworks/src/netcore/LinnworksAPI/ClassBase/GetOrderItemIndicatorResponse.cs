using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOrderItemIndicatorResponse : LinnObject
	{
		public OrderItemIndicator[] Items { get; set; }
	} 
}