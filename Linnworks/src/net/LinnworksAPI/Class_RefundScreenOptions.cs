using System;

namespace LinnworksAPI
{
    public class RefundScreenOptions
    {
        public FreeTextResponseType FreeTextOption;
        public Boolean CanRefundShipping;
        public Boolean OrderHasServiceItems;
        public Boolean IsShippingRefundAutomated;
        public Boolean IsServiceRefundAutomated;
        public Boolean SupportsAutomatedRefunds;
    }
}