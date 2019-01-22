using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class NewRefundLine
	{
        /// <summary>
        /// If the refund line pertains to an existing order return, this field should be populated with the unique identifier for the relevant return line 
        /// </summary>
		public Int32? ReturnRowId;

        /// <summary>
        /// If the refund line pertains to an order item, this field should be populated with the unique identifier of that order item. Can be left null for shipping/additional refunds 
        /// </summary>
		public Guid? OrderItemRowId;

        /// <summary>
        /// Identifies the type of refund for this line 
        /// </summary>
		public RefundUnitType RefundedUnit;

        /// <summary>
        /// If the refund is being created as part of a cancellation request, this field denotes the number of the item that were cancelled 
        /// </summary>
		public Int32? CancelledQuantity;

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