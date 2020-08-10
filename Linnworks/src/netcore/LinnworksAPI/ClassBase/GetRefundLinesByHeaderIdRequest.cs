using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetRefundLinesByHeaderIdRequest
	{
        /// <summary>
        /// The unique identifier for the refund header to load 
        /// </summary>
		public Int32 RefundHeaderId { get; set; }

        /// <summary>
        /// The unique identifier for the order this refund pertains to. Used as a safety to ensure the correct refund is being worked with 
        /// </summary>
		public Guid OrderId { get; set; }
	} 
}