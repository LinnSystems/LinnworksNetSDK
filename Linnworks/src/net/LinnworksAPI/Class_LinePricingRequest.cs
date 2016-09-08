using System;

namespace LinnworksAPI
{
    public class LinePricingRequest
    {
        public Double PricePerUnit;
        public Double DiscountPercentage;
        public Double TaxRatePercentage;
        public Boolean TaxInclusive;
    }
}