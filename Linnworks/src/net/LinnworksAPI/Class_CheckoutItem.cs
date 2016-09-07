using System;

namespace LinnworksAPI
{
    public class CheckoutItem
    {
        public String Name;
        public Double Total;
        public Double DiscountAmount;
        public String DiscountMessage;
        public DateTime NextPaymentDate;
        public ChargeType ChargeType;
    }
}