using System;

namespace LinnworksAPI
{
    public class RefundOrder
    {
        public Guid pkOrderID;
        public Int32 nOrderId;
        public String cFullName;
        public String Source;
        public String SubSource;
        public Double Amount;
        public String IssueRefundUrl;
        public String cCurrency;
        public String ReferenceNum;
        public String SecondaryReference;
        public DateTime RefundDate;
        public Double SubTotal;
        public Double Total;
        public Double TaxRate;
    }
}