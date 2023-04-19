using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class NumericFilter : LinnObject
	{
		public NumericFilterType Type { get; set; }

		public Decimal Value { get; set; }
	} 
}