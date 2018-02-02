using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Filters
	{
		public List<NumericFilter> NumericFilters;

		public BooleanFilter BooleanFilter;

		public List<DateRangeFilter> DateRangeFilters;

		public List<StringFilter> StringFilters;
	} 
}