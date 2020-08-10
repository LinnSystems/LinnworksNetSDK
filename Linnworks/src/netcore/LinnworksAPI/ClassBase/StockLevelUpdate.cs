using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockLevelUpdate
	{
		public String SKU { get; set; }

		public Guid LocationId { get; set; }

		public Int32 Level { get; set; }
	} 
}