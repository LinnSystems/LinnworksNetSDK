using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AcknowledgeRefundErrorsResponse
	{
        /// <summary>
        /// Determines whether the entire refund header was set to "ERROR_ACKED" state as a result of this call (will be found in the History tab) 
        /// </summary>
		public Boolean EntireRefundHeaderSetToErrorAcked { get; set; }

		public Int32? RefundHeaderId { get; set; }

		public String RefundReference { get; set; }

		public PostSaleStatus Status { get; set; }

		public CannotRefundReasonType CannotRefundReason { get; set; }

		public List<String> Errors { get; set; }

		public ISet<VerifiedRefund> RefundLines { get; set; }
	} 
}