using System;

namespace LinnworksAPI
{
    public class customer_invoice_payment
    {
        public Guid id;
        public Guid fkInvoiceId;
        public DateTime PaymentDate;
        public Double Amount;
        public String PaymentReference;
        public String PaymentAccount;
        public String Currency;
    }
}