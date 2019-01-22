using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VerifiedRefund
	{
		public RefundValidationErrorType RefundValidationError;

        /// <summary>
        /// A unique identifier for the refund line 
        /// </summary>
		public Guid RefundRowId;

        /// <summary>
        /// A unique identifier for the refund header this line belongs to 
        /// </summary>
		public Int32 RefundHeaderId;

        /// <summary>
        /// A detailed description of this refund line's status 
        /// </summary>
		public PostSaleStatus Status;

        /// <summary>
        /// Identifies the type of refund for this line 
        /// </summary>
		public RefundUnitType RefundedUnit;

        /// <summary>
        /// Identifies whether the refund is a shipping refund 
        /// </summary>
		public Boolean IsShippingRefund;

		public Boolean IsAdditionalRefund;

        /// <summary>
        /// Used mainly to associate an item with an error, this identifies the order item to which the refund line applies 
        /// </summary>
		public VerifiedRefundItem RefundedItem;

        /// <summary>
        /// If validation has failed for this item, the field will be populated with the appropriate error message 
        /// </summary>
		public String Error;

        /// <summary>
        /// The channel reference number for this refund 
        /// </summary>
		public String ExternalReference;

        /// <summary>
        /// Line-level indicator of whether the refund has been actioned 
        /// </summary>
		public Boolean Actioned;

        /// <summary>
        /// If a refund has been actioned, this denotes the date it was actioned. For not actioned lines, this value is null 
        /// </summary>
		public DateTime? ActionedDate;

        /// <summary>
        /// Identifies whether the refund was created manually in Linnworks, or downloaded from the channel automatically 
        /// </summary>
		public Boolean ChannelInitiated;

        /// <summary>
        /// Identifies whether the line has been removed from the refund, and is pending an update to the database to reflect this 
        /// </summary>
		public Boolean Deleted;

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