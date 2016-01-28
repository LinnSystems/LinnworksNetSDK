using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class BaseSession
    {
        public DataCache Cache;
        public String Server;
        public StatusDetails Status;
        public String Email;
        public Guid Id;
        public String Token;
        public String GroupName;
        public LocalityType Locality;
        public Dictionary<String, String> Properties;
    }
}