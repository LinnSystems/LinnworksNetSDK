using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ReturnOptions
	{
		public Boolean CanReturn;

		public Boolean CanReturnInternally;

		public Boolean MustHaveRefund;

		public Boolean RefundAutoPopulated;

		public Boolean CanHaveRefund;

		public ISet<ChannelReason> ReturnReasons;

		public ISet<PostSaleSubStatus> SubStatuses;

		public RefundOptions RefundOptions;

		public CannotReturnReasonType CannotReturnReason;

		public OrderDetails Order;

		public OrderRMAHeader RMAHeader;

		public ISet<VerifiedRMAItem> AllExistingRMAs;

		public List<String> Errors;

		public List<String> Info;
	} 
}