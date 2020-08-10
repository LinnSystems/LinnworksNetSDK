using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ValidatedCancellation
	{
		public PostSaleStatusType Status;

		public PostSaleSubStatus SubStatus;

		public ISet<ChannelExistingCancellation> ChannelExistingCancellations;

		public Boolean NeedsConfirmation;

		public String RefundReference;

		public List<String> Errors;

		public OrderDetails Order;

		public Boolean AllowRefundOnCancel;

		public Boolean OrderIsLockedOnUnhandledError;
	} 
}