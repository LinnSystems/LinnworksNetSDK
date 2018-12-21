using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class NewRefundLine
	{
		public Int32? ReturnRowId;

		public Guid? OrderItemRowId;

		public RefundUnitType RefundedUnit;

		public Int32? CancelledQuantity;

		public Boolean IsFreeText;

		public String FreeTextOrNote;

		public Decimal Amount;

		public String ReasonTag;

		public String SubReasonTag;

		public String InsufficientRefundTag;

		public String InsufficientRefundNote;
	} 
}