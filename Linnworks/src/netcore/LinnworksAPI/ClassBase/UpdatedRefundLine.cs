using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatedRefundLine
	{
        /// <summary>
        /// Identifies the refund line 
        /// </summary>
		public Guid RefundRowId { get; set; }

        /// <summary>
        /// Determines whether to remove the line from the refund 
        /// </summary>
		public Boolean RemoveFromRefund { get; set; }

		public Boolean IsFreeText { get; set; }

		public String FreeTextOrNote { get; set; }

		public Decimal Amount { get; set; }

		public Int32 Quantity { get; set; }

		public String ReasonTag { get; set; }

		public String SubReasonTag { get; set; }

		public String InsufficientRefundTag { get; set; }

		public String InsufficientRefundNote { get; set; }
	} 
}