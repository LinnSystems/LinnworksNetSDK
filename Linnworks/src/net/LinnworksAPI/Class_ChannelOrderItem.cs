using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ChannelOrderItem
    {
        public Boolean TaxCostInclusive;
        public Boolean UseChannelTax;
        public Double PricePerUnit;
        public Int32 Qty;
        public Double TaxRate;
        public Double LineDiscount;
        public String ItemNumber;
        public String ChannelSKU;
        public Boolean IsService;
        public String ItemTitle;
        public List<ChannelOrderItemOption> Options;
    }
}