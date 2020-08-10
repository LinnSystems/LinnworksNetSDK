using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VerifiedRMAItem
	{
		public ReturnValidationErrorType ReturnValidationError { get; set; }

        /// <summary>
        /// A unique identifier for the RMA line 
        /// </summary>
		public Int32 RMARowId { get; set; }

        /// <summary>
        /// A unique identifier for the header this RMA line belongs to 
        /// </summary>
		public Int32 RMAHeaderId { get; set; }

        /// <summary>
        /// Identifies the type of RMA for this line 
        /// </summary>
		public RMAType Type { get; set; }

        /// <summary>
        /// A detailed description of this RMA line's status 
        /// </summary>
		public PostSaleStatus Status { get; set; }

        /// <summary>
        /// The channel reference number for this RMA 
        /// </summary>
		public String ExternalReference { get; set; }

        /// <summary>
        /// The timestamp for when the RMA was created 
        /// </summary>
		public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Line-level indicator of whether the refund has been actioned 
        /// </summary>
		public Boolean Actioned { get; set; }

        /// <summary>
        /// If an RMA has been actioned, this denotes the date it was actioned. For not actioned lines, this value is null 
        /// </summary>
		public DateTime? ActionedDate { get; set; }

        /// <summary>
        /// Identifies whether the line has been removed from the RMA, and is pending an update to the database to reflect this 
        /// </summary>
		public Boolean Deleted { get; set; }

		public Int32 ResendQuantity { get; set; }

        /// <summary>
        /// In the case of an exchange or resend line, this is the identifier for the created order 
        /// </summary>
		public Guid NewOrderId { get; set; }

        /// <summary>
        /// Identifies any validation or submission errors for this RMA item 
        /// </summary>
		public String ValidationError { get; set; }

		public String Error { get; set; }

		public List<RMAError> Errors { get; set; }

        /// <summary>
        /// Identifies any validation or submission information for this RMA item 
        /// </summary>
		public String Info { get; set; }

		public Guid ExchangeStockItemId { get; set; }

		public String ExchangeSKU { get; set; }

		public String ExchangeTitle { get; set; }

		public Int32 ExchangeQuantity { get; set; }

		public Guid DespatchLocationId { get; set; }

		public Decimal AdditionalCost { get; set; }

		public Guid OrderItemRowId { get; set; }

		public String ReturnItemSKU { get; set; }

		public String ReturnItemTitle { get; set; }

		public Int32? BatchInventoryId { get; set; }

		public Guid ReturnLocation { get; set; }

		public Int32 ReturnQuantity { get; set; }

		public Decimal RefundAmount { get; set; }

		public Guid? RefundRowId { get; set; }

		public Int32 ScrapQuantity { get; set; }

		public String ReasonCategory { get; set; }

		public Boolean IsFreeText { get; set; }

		public String Reason { get; set; }

		public String ReasonTag { get; set; }

		public String SubReasonTag { get; set; }

		public String BinrackOverride { get; set; }
	} 
}