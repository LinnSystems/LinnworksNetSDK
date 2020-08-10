using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RefundInfo
	{
        /// <summary>
        /// Refund record ID 
        /// </summary>
		public Guid? pkRefundRowId { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// If its an item that is refunded 
        /// </summary>
		public Boolean IsItem { get; set; }

        /// <summary>
        /// If its a service that is refunded 
        /// </summary>
		public Boolean IsService { get; set; }

        /// <summary>
        /// Refund amount 
        /// </summary>
		public Double Amount { get; set; }

        /// <summary>
        /// Reason for a refund 
        /// </summary>
		public String Reason { get; set; }

        /// <summary>
        /// If refund has been actioned 
        /// </summary>
		public Boolean Actioned { get; set; }

        /// <summary>
        /// When refund was actioned 
        /// </summary>
		public DateTime? ActionDate { get; set; }

        /// <summary>
        /// return reference number 
        /// </summary>
		public String ReturnReference { get; set; }

        /// <summary>
        /// Cost 
        /// </summary>
		public Double? Cost { get; set; }

		public PostSaleStatusType RefundStatus { get; set; }

        /// <summary>
        /// Status of refund 
        /// </summary>
		public Boolean IgnoredValidation { get; set; }

        /// <summary>
        /// Order item record ID 
        /// </summary>
		public Guid? fkOrderItemRowId { get; set; }

		public Boolean ShouldSerializeChannelReason { get; set; }

        /// <summary>
        /// Channel refund reason 
        /// </summary>
		public String ChannelReason { get; set; }

		public Boolean ShouldSerializeChannelReasonSec { get; set; }

        /// <summary>
        /// Secondary channel reason for a refund 
        /// </summary>
		public String ChannelReasonSec { get; set; }

		public Boolean IsNew { get; set; }
	} 
}