using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ReturnOptions
	{
		public Boolean CanReturn { get; set; }

		public Boolean CanReturnInternally { get; set; }

		public Boolean MustHaveRefund { get; set; }

		public Boolean RefundAutoPopulated { get; set; }

		public Boolean CanHaveRefund { get; set; }

		public ISet<ChannelReason> ReturnReasons { get; set; }

		public ISet<PostSaleSubStatus> SubStatuses { get; set; }

		public RefundOptions RefundOptions { get; set; }

		public CannotReturnReasonType CannotReturnReason { get; set; }

		public OrderDetails Order { get; set; }

		public OrderRMAHeader RMAHeader { get; set; }

		public ISet<VerifiedRMAItem> AllExistingRMAs { get; set; }

		public List<String> Errors { get; set; }

		public List<String> Info { get; set; }
	} 
}