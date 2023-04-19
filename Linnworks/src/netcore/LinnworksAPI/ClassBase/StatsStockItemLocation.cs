using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StatsStockItemLocation : LinnObject
	{
		public Guid StockLocationId { get; set; }

		public String Location { get; set; }

		public Double StockLevel { get; set; }

		public Double StockValue { get; set; }
	} 
}