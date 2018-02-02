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
		public Guid? pkRefundRowId;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// If its an item that is refunded 
        /// </summary>
		public Boolean IsItem;

        /// <summary>
        /// If its a service that is refunded 
        /// </summary>
		public Boolean IsService;

        /// <summary>
        /// Refund amount 
        /// </summary>
		public Double Amount;

        /// <summary>
        /// Reason for a refund 
        /// </summary>
		public String Reason;

        /// <summary>
        /// If refund has been actioned 
        /// </summary>
		public Boolean Actioned;

        /// <summary>
        /// When refund was actioned 
        /// </summary>
		public DateTime? ActionDate;

        /// <summary>
        /// return reference number 
        /// </summary>
		public String ReturnReference;

        /// <summary>
        /// Cost 
        /// </summary>
		public Double? Cost;

		public PostSaleStatusType RefundStatus;

        /// <summary>
        /// Status of refund 
        /// </summary>
		public Boolean IgnoredValidation;

        /// <summary>
        /// Order item record ID 
        /// </summary>
		public Guid? fkOrderItemRowId;

		public Boolean ShouldSerializeChannelReason;

        /// <summary>
        /// Channel refund reason 
        /// </summary>
		public String ChannelReason;

		public Boolean ShouldSerializeChannelReasonSec;

        /// <summary>
        /// Secondary channel reason for a refund 
        /// </summary>
		public String ChannelReasonSec;

		public Boolean IsNew;
	} 
}