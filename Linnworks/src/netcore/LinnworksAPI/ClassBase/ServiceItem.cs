using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ServiceItem
	{
        /// <summary>
        /// Order item record row ID 
        /// </summary>
		public Guid pkOrderItemRowId { get; set; }

        /// <summary>
        /// Service name 
        /// </summary>
		public String ServiceName { get; set; }

        /// <summary>
        /// Service cost 
        /// </summary>
		public Double ServiceCost { get; set; }

        /// <summary>
        /// Channel refund reason 
        /// </summary>
		public ChannelRefundReason DefaultChannelReason { get; set; }

        /// <summary>
        /// Channel refund subreason 
        /// </summary>
		public ChannelRefundSubReason DefaultChannelSubReason { get; set; }

        /// <summary>
        /// Item number 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// If automatic refunds allowed 
        /// </summary>
		public Boolean AllowsAutomatedRefund { get; set; }
	} 
}