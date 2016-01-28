using System;

namespace LinnworksAPI
{
    public class StockItemAuditTrail
    {
        public String AuditType;
        public DateTime AuditTrailDate;
        public String AuditText;
        public String UserName;
        public Guid StockItemId;
    }
}