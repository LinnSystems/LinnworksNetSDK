using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class CheckoutRequest
    {
        public PaymentType PaymentType;
        public List<CheckoutRequestParameter> Parameters;
        public String CurrencyCode;
    }
}