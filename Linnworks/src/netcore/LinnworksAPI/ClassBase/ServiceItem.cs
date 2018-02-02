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
		public Guid pkOrderItemRowId;

        /// <summary>
        /// Service name 
        /// </summary>
		public String ServiceName;

        /// <summary>
        /// Service cost 
        /// </summary>
		public Double ServiceCost;

        /// <summary>
        /// Channel refund reason 
        /// </summary>
		public ChannelRefundReason DefaultChannelReason;

        /// <summary>
        /// Channel refund subreason 
        /// </summary>
		public ChannelRefundSubReason DefaultChannelSubReason;

        /// <summary>
        /// Item number 
        /// </summary>
		public String ItemNumber;

        /// <summary>
        /// If automatic refunds allowed 
        /// </summary>
		public Boolean AllowsAutomatedRefund;
	} 
}