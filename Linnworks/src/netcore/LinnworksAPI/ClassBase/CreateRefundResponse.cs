using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateRefundResponse
	{
		public Int32? RefundHeaderId { get; set; }

		public String RefundReference { get; set; }

		public PostSaleStatus Status { get; set; }

		public CannotRefundReasonType CannotRefundReason { get; set; }

		public List<String> Errors { get; set; }

		public ISet<VerifiedRefund> RefundLines { get; set; }
	} 
}