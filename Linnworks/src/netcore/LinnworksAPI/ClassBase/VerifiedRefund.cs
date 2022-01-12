using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VerifiedRefund
	{
        /// <summary>
        /// A unique identifier for the refund line 
        /// </summary>
		public Guid RefundRowId { get; set; }

        /// <summary>
        /// A unique identifier for the refund header this line belongs to 
        /// </summary>
		public Int32 RefundHeaderId { get; set; }

        /// <summary>
        /// A detailed description of this refund line's status 
        /// </summary>
		public PostSaleStatus Status { get; set; }

        /// <summary>
        /// Identifies the type of refund for this line 
        /// </summary>
		public RefundUnitType RefundedUnit { get; set; }

        /// <summary>
        /// Identifies whether the refund is a shipping refund 
        /// </summary>
		public Boolean IsShippingRefund { get; set; }

        /// <summary>
        /// Identifies whether the refund is an additional refund 
        /// </summary>
		public Boolean IsAdditionalRefund { get; set; }

        /// <summary>
        /// Identifies whether the refund row is a cancellation 
        /// </summary>
		public Boolean IsCancellation { get; set; }

        /// <summary>
        /// Used mainly to associate an item with an error, this identifies the order item to which the refund line applies 
        /// </summary>
		public VerifiedRefundItem RefundedItem { get; set; }

		public RefundValidationErrorType RefundValidationError { get; set; }

        /// <summary>
        /// If validation has failed for this item, the field will be populated with the appropriate error message 
        /// </summary>
		public String ValidationError { get; set; }

		public String Error { get; set; }

		public List<RefundError> Errors { get; set; }

        /// <summary>
        /// The channel reference number for this refund 
        /// </summary>
		public String ExternalReference { get; set; }

        /// <summary>
        /// Line-level indicator of whether the refund has been actioned 
        /// </summary>
		public Boolean Actioned { get; set; }

        /// <summary>
        /// If a refund has been actioned, this denotes the date it was actioned. For not actioned lines, this value is null 
        /// </summary>
		public DateTime? ActionedDate { get; set; }

        /// <summary>
        /// Identifies whether the refund was created manually in Linnworks, or downloaded from the channel automatically 
        /// </summary>
		public Boolean ChannelInitiated { get; set; }

        /// <summary>
        /// Identifies whether the line has been removed from the refund, and is pending an update to the database to reflect this 
        /// </summary>
		public Boolean Deleted { get; set; }

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