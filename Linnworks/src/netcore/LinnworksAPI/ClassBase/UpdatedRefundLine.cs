using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatedRefundLine
	{
		public Guid RefundRowId;

		public Boolean RemoveFromRefund;

		public Boolean IsFreeText;

		public String FreeTextOrNote;

		public Decimal Amount;

		public String ReasonTag;

		public String SubReasonTag;

		public String InsufficientRefundTag;

		public String InsufficientRefundNote;
	} 
}