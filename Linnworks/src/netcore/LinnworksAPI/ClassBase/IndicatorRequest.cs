using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class IndicatorRequest
	{
		public Guid OrderItemId { get; set; }

		public Guid StockItemId { get; set; }
	} 
}