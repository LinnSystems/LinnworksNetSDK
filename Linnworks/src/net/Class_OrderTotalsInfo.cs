using System;

namespace LinnworksAPI
{
    public class OrderTotalsInfo
    {
        public Double Subtotal;
        public Double PostageCost;
        public Double Tax;
        public Double TotalCharge;
        public String PaymentMethod;
        public Guid PaymentMethodId;
        public Double ProfitMargin;
        public Double TotalDiscount;
        public String Currency;
        public Double CountryTaxRate;
    }
}