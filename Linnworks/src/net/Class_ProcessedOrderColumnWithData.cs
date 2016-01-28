using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ProcessedOrderColumnWithData
    {
        public ProcessedOrderColumnCollection ColumnData;
        public List<String> NewColumns;
        public List<ProcessedOrderWeb> PartialOrders;
    }
}