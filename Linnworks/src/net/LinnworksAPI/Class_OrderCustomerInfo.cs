using System;

namespace LinnworksAPI
{
    [Serializable]
    public class OrderCustomerInfo
    {
        public String ChannelBuyerName;
        public CustomerAddress Address;
        public Address BillingAddress;
    }
}