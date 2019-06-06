using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ValidatedCancellation
	{
		public PostSaleStatusType Status;

		public Boolean NeedsConfirmation;

		public List<ChannelExistingCancellation> ChannelExistingCancellations;

		public String RefundReference;

		public List<String> Errors;

		public OrderDetails Order;

		public Boolean AllowRefundOnCancel;

		public Boolean OrderIsLockedOnUnhandledError;
	} 
}