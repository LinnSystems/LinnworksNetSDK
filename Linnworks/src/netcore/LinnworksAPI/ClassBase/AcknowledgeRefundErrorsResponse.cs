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
		public Boolean EntireRefundHeaderSetToErrorAcked;

		public Int32? RefundHeaderId;

		public String RefundReference;

		public PostSaleStatus Status;

		public CannotRefundReasonType CannotRefundReason;

		public List<String> Errors;

		public List<VerifiedRefund> RefundLines;
	} 
}