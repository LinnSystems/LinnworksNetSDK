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
		public Int32? ReturnRowId { get; set; }

        /// <summary>
        /// If the refund line pertains to an order item, this field should be populated with the unique identifier of that order item. Can be left null for shipping/additional refunds 
        /// </summary>
		public Guid? OrderItemRowId { get; set; }

        /// <summary>
        /// Identifies the type of refund for this line 
        /// </summary>
		public RefundUnitType RefundedUnit { get; set; }

        /// <summary>
        /// If the refund is being created as part of a cancellation request, this field denotes the number of the item that were cancelled 
        /// </summary>
		public Int32? CancelledQuantity { get; set; }

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