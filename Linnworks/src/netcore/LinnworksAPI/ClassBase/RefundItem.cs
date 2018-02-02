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
		public Guid? pkRefundRowId;

        /// <summary>
        /// Manual refunds will never be passed to the channel validation routines 
        /// </summary>
		public Boolean IsManualRefund;

        /// <summary>
        /// The type of refund item 
        /// </summary>
		public RefundItemType Type;

        /// <summary>
        /// The order item or service to refund 
        /// </summary>
		public Guid? fkOrderItemId;

        /// <summary>
        /// In the case of item refunds, the number of items 
        /// </summary>
		public Int32 RefundQty;

        /// <summary>
        /// The amount of money the refund is for. 
        /// </summary>
		public Double RefundAmount;

        /// <summary>
        /// The seller's text reason for the refund 
        /// </summary>
		public String Reason;

        /// <summary>
        /// The primary channel reason 
        /// </summary>
		public String ChannelReason;

        /// <summary>
        /// The secondary channel reason 
        /// </summary>
		public String ChannelReasonSec;
	} 
}