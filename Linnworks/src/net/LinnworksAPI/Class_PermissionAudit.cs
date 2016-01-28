using System;

namespace LinnworksAPI
{
    public class PermissionAudit
    {
        public Int32 LogId;
        public DateTime AuditDate;
        public PermissionAuditType AuditType;
        public String AuditSource;
        public Int32 UserId;
        public String EmailAddress;
        public Int32 GroupId;
        public String GroupName;
        public String HeaderInfo;
        public String Description;
        public BasePermissionListHeader ListHeader;
        public Boolean IsListItem;
        public Boolean IsPermissionList;
    }
}