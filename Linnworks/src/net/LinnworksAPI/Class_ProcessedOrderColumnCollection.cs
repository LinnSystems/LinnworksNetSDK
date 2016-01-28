using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ProcessedOrderColumnCollection
    {
        public String DefaultSortColumn;
        public Boolean DefaultSortAsc;
        public String SortColumn;
        public Boolean SortAsc;
        public Boolean NewSortOrder;
        public List<ProcessedOrderColumn> Columns;
    }
}