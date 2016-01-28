using System;

namespace LinnworksAPI
{
    public class WarehouseTransferAudit
    {
        public Guid PkTransferAuditId;
        public AuditType AuditType;
        public Int32 nAuditType;
        public DateTime AuditDate;
        public String AuditNote;
    }
}