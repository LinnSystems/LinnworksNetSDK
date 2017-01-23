using System;

namespace LinnworksAPI
{
    public class StockItemPricingRule
    {
        public Int32? pkRowId;
        public Guid fkStockPricingId;
        public String Type;
        public Int32 LowerBound;
        public Double Value;
    }
}