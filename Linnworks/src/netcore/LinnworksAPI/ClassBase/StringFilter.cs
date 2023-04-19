using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StringFilter : LinnObject
	{
		public StringFilterType Type { get; set; }

		public String Value { get; set; }
	} 
}