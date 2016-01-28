using System.Collections.Generic;

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