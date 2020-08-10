using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateRefundResponse
	{
		public Int32? RefundHeaderId;

		public String RefundReference;

		public PostSaleStatus Status;

		public CannotRefundReasonType CannotRefundReason;

		public List<String> Errors;

		public ISet<VerifiedRefund> RefundLines;
	} 
}