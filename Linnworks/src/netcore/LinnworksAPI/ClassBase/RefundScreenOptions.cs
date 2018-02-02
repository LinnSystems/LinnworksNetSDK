using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RefundScreenOptions
	{
        /// <summary>
        /// Information about channel refund functionality 
        /// </summary>
		public FreeTextResponseType FreeTextOption;

        /// <summary>
        /// If shipping can be refunded 
        /// </summary>
		public Boolean CanRefundShipping;

        /// <summary>
        /// If order got service items 
        /// </summary>
		public Boolean OrderHasServiceItems;

        /// <summary>
        /// If order shipping cost refund automated 
        /// </summary>
		public Boolean IsShippingRefundAutomated;

        /// <summary>
        /// AIf order service refund autoamted 
        /// </summary>
		public Boolean IsServiceRefundAutomated;

        /// <summary>
        /// If automated refund is supported 
        /// </summary>
		public Boolean SupportsAutomatedRefunds;
	} 
}