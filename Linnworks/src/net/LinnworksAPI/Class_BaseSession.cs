using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class BaseSession
    {
        public DateTime LastActivity;
        public String Device;
        public String DeviceType;
        public String Server;
        public StatusDetails Status;
        public String BsonId;
        public Guid Id;
        public String Email;
        public Guid UserId;
        public String UserName;
        public String UserType;
        public string Token;
        public Guid EntityId;
        public String GroupName;
        public LocalityType Locality;
        public Dictionary<String, String> Properties;
        public DataCache Cache;
    }
}