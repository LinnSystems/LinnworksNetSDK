using System;

namespace LinnworksAPI
{
    public class ServiceItem
    {
        public Guid pkOrderItemRowId;
        public String ServiceName;
        public Double ServiceCost;
        public ChannelRefundReason DefaultChannelReason;
        public ChannelRefundSubReason DefaultChannelSubReason;
        public String ItemNumber;
        public Boolean AllowsAutomatedRefund;
    }
}