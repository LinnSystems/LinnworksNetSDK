using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ValidatedCancellation
	{
		public PostSaleStatusType Status { get; set; }

		public PostSaleSubStatus SubStatus { get; set; }

		public ISet<ChannelExistingCancellation> ChannelExistingCancellations { get; set; }

		public Boolean NeedsConfirmation { get; set; }

		public String RefundReference { get; set; }

		public List<String> Errors { get; set; }

		public OrderDetails Order { get; set; }

		public Boolean AllowRefundOnCancel { get; set; }

		public Boolean OrderIsLockedOnUnhandledError { get; set; }
	} 
}