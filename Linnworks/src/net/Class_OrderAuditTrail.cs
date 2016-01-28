using System;

namespace LinnworksAPI
{
    public class OrderAuditTrail
    {
        public DateTime Date;
        public String Type;
        public String Note;
        public String User;
        public String fkOrderHistoryTypeId;
        public String Tag;
    }
}