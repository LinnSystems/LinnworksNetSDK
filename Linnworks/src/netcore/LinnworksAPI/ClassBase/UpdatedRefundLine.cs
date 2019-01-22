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
		public Guid RefundRowId;

        /// <summary>
        /// Determines whether to remove the line from the refund 
        /// </summary>
		public Boolean RemoveFromRefund;

		public Boolean IsFreeText;

		public String FreeTextOrNote;

		public Decimal Amount;

		public Int32 Quantity;

		public String ReasonTag;

		public String SubReasonTag;

		public String InsufficientRefundTag;

		public String InsufficientRefundNote;
	} 
}