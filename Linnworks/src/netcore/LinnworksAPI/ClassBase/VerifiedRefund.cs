using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VerifiedRefund
	{
		public RefundValidationErrorType RefundValidationError;

		public Guid RefundRowId;

		public Int32 RefundHeaderId;

		public PostSaleStatus Status;

		public RefundUnitType RefundedUnit;

		public Boolean IsShippingRefund;

		public Boolean IsAdditionalRefund;

		public VerifiedRefundItem RefundedItem;

		public String Error;

		public String ExternalReference;

		public Boolean Actioned;

		public DateTime? ActionedDate;

		public Boolean ChannelInitiated;

		public Boolean Deleted;

		public Boolean IsFreeText;

		public String FreeTextOrNote;

		public Decimal Amount;

		public String ReasonTag;

		public String SubReasonTag;

		public String InsufficientRefundTag;

		public String InsufficientRefundNote;
	} 
}