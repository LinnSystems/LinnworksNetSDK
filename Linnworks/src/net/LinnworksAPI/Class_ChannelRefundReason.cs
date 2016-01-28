using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class ChannelRefundReason
    {
        public String Tag;
        public String DisplayName;
        public List<ChannelRefundSubReason> SubReasons;
    }
}