using System;

namespace LinnworksAPI
{
    public class PaymentResponse
    {
        public PaymentStatus CurrentStatus;
        public String Message;
        public String TransactionId;
        public String ProfileId;
        public CheckoutRequest CheckoutRequest;
        public CheckoutData CheckoutData;
    }
}