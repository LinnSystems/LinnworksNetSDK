using System;

namespace LinnworksAPI
{
    public class JobAudit
    {
        public Int32 JobAuditId;
        public Int32 JobId;
        public JobAuditType Type;
        public DateTime Date;
        public String Note;
        public String User;
    }
}