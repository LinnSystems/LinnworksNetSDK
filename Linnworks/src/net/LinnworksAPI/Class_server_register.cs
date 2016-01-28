using System;

namespace LinnworksAPI
{
    public class server_register
    {
        public Guid pkServerId;
        public String ControlEndPoint;
        public String ServerType;
        public String ServerIP;
        public String ServerUrl;
        public String Locale;
        public String FriendlyName;
        public String SQLServerVersion;
        public Int32 WarningCount;
        public Int32 WarningType;
        public DateTime BackupServiceCheckin;
        public Boolean Active;
    }
}