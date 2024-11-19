using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VariationsAttributesPrices : LinnObject
	{
		public String SelectValue { get; set; }

		public String SelectLabel { get; set; }

		public Double PriceDiff { get; set; }

		public Boolean IsFixed { get; set; }
	} 
}