using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SiteFilter : LinnObject
	{
		public String Source { get; set; }

		public String SubSource { get; set; }

		public String Sites { get; set; }

		public HashSet<String> SelectedSites { get; set; }
	} 
}