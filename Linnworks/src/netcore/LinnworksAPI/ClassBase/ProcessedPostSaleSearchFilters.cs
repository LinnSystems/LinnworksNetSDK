using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ProcessedPostSaleSearchFilters : LinnObject
	{
		public Boolean Actionable { get; set; }

		public FilterType Type { get; set; }

		public String Value { get; set; }
	} 
}