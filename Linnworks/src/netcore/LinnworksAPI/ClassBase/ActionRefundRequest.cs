using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionRefundRequest
	{
        /// <summary>
        /// The unique identifier for the refund header to action 
        /// </summary>
		public Int32 RefundHeaderId { get; set; }

        /// <summary>
        /// The order ID this refund header pertains to. Used as a double-step verification to ensure the right refund header is being actioned 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// When actioning a refund beyond the initial approval, the channel may require additional information, which can be passed via this field. Not required 
        /// </summary>
		public ActionForm Request { get; set; }
	} 
}