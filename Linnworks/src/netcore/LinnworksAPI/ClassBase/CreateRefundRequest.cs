using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateRefundRequest
	{
        /// <summary>
        /// Determines whether the refund was initiated on the channel, or within Linnworks 
        /// </summary>
		public Boolean ChannelInitiated { get; set; }

        /// <summary>
        /// The unique identifier for the order this refund is associated with 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// A collection of line-level refunds detailing the refund as a whole 
        /// </summary>
		public List<NewRefundLine> RefundLines { get; set; }
	} 
}