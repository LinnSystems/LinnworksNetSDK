using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderItemOption
    {
        public Guid pkOptionId;
        public String Property;
        public String Value;
    }
}