using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SearchFilters : LinnObject
	{
		public SearchFieldTypes? SearchField { get; set; }

		public String SearchTerm { get; set; }
	} 
}