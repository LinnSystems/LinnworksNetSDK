using System;

namespace LinnworksAPI
{
    public class PurchaseOrderAudit
    {
        public Guid pkPurchaseAuditTrailId;
        public DateTime AuditTrailDateTimeStamp;
        public Guid fkPurchaseId;
        public String AuditTrailType;
        public String AuditTrailTag;
        public String AuditTrailNote;
        public String UserName;
        public String AuditTrailDate;
        public String AuditTrailTime;
    }
}