using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RefundOptions
	{
		public Boolean CanRefund { get; set; }

		public Boolean CanRefundInternally { get; set; }

		public Boolean CanRefundItems { get; set; }

		public Boolean CanRefundServices { get; set; }

		public Boolean CanRefundShipping { get; set; }

		public Boolean CanRefundShippingIndependently { get; set; }

		public Boolean CanRefundAdditionally { get; set; }

		public Boolean CanRefundFreeText { get; set; }

		public Boolean CanInsufficientRefundFreeText { get; set; }

		public Int32 RefundFreeTextOrNoteMaxLength { get; set; }

		public List<PostSaleSubStatus> SubStatuses { get; set; }

		public ISet<ChannelReason> InsufficientRefundReasons { get; set; }

		public ISet<ChannelReason> ItemRefundReasons { get; set; }

		public ISet<ChannelReason> ServiceRefundReasons { get; set; }

		public ISet<ChannelReason> ShippingRefundReasons { get; set; }

		public CannotRefundReasonType CannotRefundReason { get; set; }

		public OrderDetails Order { get; set; }

		public OrderRefundHeader RefundHeader { get; set; }

		public ISet<VerifiedRefund> AllExistingRefunds { get; set; }

		public List<String> Errors { get; set; }
	} 
}