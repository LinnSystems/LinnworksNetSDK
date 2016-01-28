using System;

namespace LinnworksAPI
{
    public class AuditEntry
    {
        public Int32 sid_history;
        public Guid fkOrderId;
        public String HistoryNote;
        public String fkOrderHistoryTypeId;
        public DateTime DateStamp;
        public String Tag;
        public String UpdatedBy;
        public String TypeDescription;
    }
}