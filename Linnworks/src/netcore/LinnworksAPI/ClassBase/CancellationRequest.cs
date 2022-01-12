using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CancellationRequest
	{
		public Boolean IsChannelCancellation { get; set; }

		public Boolean IsChannelInitiated { get; set; }

		public Boolean IsChannelCancellationConfirmed { get; set; }

		public Boolean IsFreeText { get; set; }

		public String FreeTextOrNote { get; set; }

		public String ReasonTag { get; set; }

		public String SubReasonTag { get; set; }

		public Boolean CreateFullRefund { get; set; }

		public Boolean RefundAlreadyProcessed { get; set; }

		public String RefundStatusTag { get; set; }

		public String RefundReference { get; set; }

		public Int32 HeaderId { get; set; }

		public Guid OrderId { get; set; }

		public Boolean IsRetry { get; set; }

		public ActionForm ActionForm { get; set; }
	} 
}