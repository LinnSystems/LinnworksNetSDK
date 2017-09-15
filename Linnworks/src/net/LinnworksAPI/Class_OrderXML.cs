using System;
using System.Xml;

namespace LinnworksAPI
{
    public class OrderXML
    {
        public Guid pkOrderId;
        public String LineTag;
        public String Type;
        public XmlDocument Document;
    }
}