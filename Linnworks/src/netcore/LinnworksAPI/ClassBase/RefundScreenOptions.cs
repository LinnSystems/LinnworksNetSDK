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
		public FreeTextResponseType FreeTextOption { get; set; }

        /// <summary>
        /// If shipping can be refunded 
        /// </summary>
		public Boolean CanRefundShipping { get; set; }

        /// <summary>
        /// If order got service items 
        /// </summary>
		public Boolean OrderHasServiceItems { get; set; }

        /// <summary>
        /// If order shipping cost refund automated 
        /// </summary>
		public Boolean IsShippingRefundAutomated { get; set; }

        /// <summary>
        /// AIf order service refund autoamted 
        /// </summary>
		public Boolean IsServiceRefundAutomated { get; set; }

        /// <summary>
        /// If automated refund is supported 
        /// </summary>
		public Boolean SupportsAutomatedRefunds { get; set; }
	} 
}