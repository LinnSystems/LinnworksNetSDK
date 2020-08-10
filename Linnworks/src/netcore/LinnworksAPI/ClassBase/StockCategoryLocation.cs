using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockCategoryLocation
	{
		public Guid StockLocationId { get; set; }

		public String CategoryName { get; set; }

		public Guid CategoryId { get; set; }

		public Int32 StockLevel { get; set; }

		public Double StockValue { get; set; }
	} 
}