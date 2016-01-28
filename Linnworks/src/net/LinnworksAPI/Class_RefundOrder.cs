using System;

namespace LinnworksAPI
{
    public class RefundOrder
    {
        public Guid pkOrderID;
        public Int32 nOrderId;
        public String cFullName;
        public String Source;
        public Double Amount;
        public String IssueRefundUrl;
        public String cCurrency;
        public String ReferenceNum;
    }
}