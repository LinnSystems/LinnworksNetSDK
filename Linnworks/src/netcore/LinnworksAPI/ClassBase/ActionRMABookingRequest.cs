using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionRMABookingRequest
	{
        /// <summary>
        /// The unique identifier for the RMA header to action 
        /// </summary>
		public Int32 RMAHeaderId { get; set; }

        /// <summary>
        /// The order ID this RMA header pertains to. Used as a double-step verification to ensure the right RMA header is being actioned 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// When actioning an RMA beyond the initial approval, the channel may require additional information, which can be passed via this field. Not required 
        /// </summary>
		public ActionForm Request { get; set; }
	} 
}