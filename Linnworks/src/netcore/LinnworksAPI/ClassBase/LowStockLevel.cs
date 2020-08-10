using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LowStockLevel
	{
		public String ItemTitle { get; set; }

		public String ItemNumber { get; set; }

		public Int32 Quantity { get; set; }

		public Int32 MinimumLevel { get; set; }

		public Int32 InBooks { get; set; }

		public String Location { get; set; }
	} 
}