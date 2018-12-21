using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RefundOptions
	{
		public Boolean CanRefund;

		public Boolean CanRefundInternally;

		public Boolean CanRefundItems;

		public Boolean CanRefundServices;

		public Boolean CanRefundShipping;

		public Boolean CanRefundShippingIndependently;

		public Boolean CanRefundAdditionally;

		public Boolean CanRefundFreeText;

		public Boolean CanInsufficientRefundFreeText;

		public Int32 RefundFreeTextOrNoteMaxLength;

		public List<PostSaleSubStatus> SubStatuses;

		public List<ChannelReason> InsufficientRefundReasons;

		public List<ChannelReason> ItemRefundReasons;

		public List<ChannelReason> ServiceRefundReasons;

		public List<ChannelReason> ShippingRefundReasons;

		public CannotRefundReasonType CannotRefundReason;

		public OrderDetails Order;

		public OrderRefundHeader RefundHeader;

		public List<VerifiedRefund> AllExistingRefunds;

		public List<String> Errors;
	} 
}