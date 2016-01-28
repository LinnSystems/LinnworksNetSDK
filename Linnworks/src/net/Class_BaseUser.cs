using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class BaseUser
    {
        public String Email;
        public Guid Id;
        public String Token;
        public String GroupName;
        public LocalityType Locality;
        public Dictionary<String, String> Properties;
    }
}