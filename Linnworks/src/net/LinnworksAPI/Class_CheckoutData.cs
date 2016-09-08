using System;

namespace LinnworksAPI
{
    public class CheckoutData
    {
        public String CurrencyCode;
        public String CurrencySymbol;
        public CheckoutItem Item;
        public TotalsInformation TotalsInformation;
        public Double TaxRate;
    }
}