using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RefundItem
	{
        /// <summary>
        /// For updating refund amounts 
        /// </summary>
		public Guid? pkRefundRowId { get; set; }

        /// <summary>
        /// Manual refunds will never be passed to the channel validation routines 
        /// </summary>
		public Boolean IsManualRefund { get; set; }

        /// <summary>
        /// The type of refund item 
        /// </summary>
		public RefundItemType Type { get; set; }

        /// <summary>
        /// The order item or service to refund 
        /// </summary>
		public Guid? fkOrderItemId { get; set; }

        /// <summary>
        /// In the case of item refunds, the number of items 
        /// </summary>
		public Int32 RefundQty { get; set; }

        /// <summary>
        /// The amount of money the refund is for. 
        /// </summary>
		public Double RefundAmount { get; set; }

        /// <summary>
        /// The seller's text reason for the refund 
        /// </summary>
		public String Reason { get; set; }

        /// <summary>
        /// The primary channel reason 
        /// </summary>
		public String ChannelReason { get; set; }

        /// <summary>
        /// The secondary channel reason 
        /// </summary>
		public String ChannelReasonSec { get; set; }
	} 
}