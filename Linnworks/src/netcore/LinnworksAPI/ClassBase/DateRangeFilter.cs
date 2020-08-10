using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DateRangeFilter
	{
		public DateTime ValueFrom { get; set; }

		public DateTime ValueTo { get; set; }

		public Int32 Days { get; set; }

		public Boolean Enabled { get; set; }

		public String Type { get; set; }
	} 
}