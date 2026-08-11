using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FilterNotProcessedOpenOrdersResponse : LinnObject
	{
		public List<Int32> OrderIds { get; set; }
	} 
}