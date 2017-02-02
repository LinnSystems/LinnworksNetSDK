using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StockItemPrice
    {
        public Guid pkRowId;
        public String Source;
        public String SubSource;
        public Double Price;
        public UpdateStatusType UpdateStatus;
        public String Tag;
        public List<StockItemPricingRule> Rules;
        public Guid StockItemId;
    }
}