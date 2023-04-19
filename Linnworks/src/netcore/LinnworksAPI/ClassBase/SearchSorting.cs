using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SearchSorting : LinnObject
	{
		public String SortField { get; set; }

		public SortDirection SortDirection { get; set; }
	} 
}