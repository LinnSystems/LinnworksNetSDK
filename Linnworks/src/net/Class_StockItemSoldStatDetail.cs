using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StockItemSoldStatDetail
    {
        public String Subsource;
        public Int32 Quantity;
        public Double Total;
        public Double Cost;
        public Double ProfitMargin;
        public List<StockItemSoldStatFinalDetail> Detail;
    }
}