using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VerifiedRMAItem
	{
		public ReturnValidationErrorType ReturnValidationError;

        /// <summary>
        /// A unique identifier for the RMA line 
        /// </summary>
		public Int32 RMARowId;

        /// <summary>
        /// A unique identifier for the header this RMA line belongs to 
        /// </summary>
		public Int32 RMAHeaderId;

        /// <summary>
        /// Identifies the type of RMA for this line 
        /// </summary>
		public RMAType Type;

        /// <summary>
        /// A detailed description of this RMA line's status 
        /// </summary>
		public PostSaleStatus Status;

        /// <summary>
        /// The channel reference number for this RMA 
        /// </summary>
		public String ExternalReference;

        /// <summary>
        /// The timestamp for when the RMA was created 
        /// </summary>
		public DateTime CreatedDate;

        /// <summary>
        /// Line-level indicator of whether the refund has been actioned 
        /// </summary>
		public Boolean Actioned;

        /// <summary>
        /// If an RMA has been actioned, this denotes the date it was actioned. For not actioned lines, this value is null 
        /// </summary>
		public DateTime? ActionedDate;

        /// <summary>
        /// Identifies whether the line has been removed from the RMA, and is pending an update to the database to reflect this 
        /// </summary>
		public Boolean Deleted;

		public Int32 ResendQuantity;

        /// <summary>
        /// In the case of an exchange or resend line, this is the identifier for the created order 
        /// </summary>
		public Guid NewOrderId;

        /// <summary>
        /// Identifies any validation or submission errors for this RMA item 
        /// </summary>
		public String ValidationError;

		public String Error;

		public List<RMAError> Errors;

        /// <summary>
        /// Identifies any validation or submission information for this RMA item 
        /// </summary>
		public String Info;

		public Guid ExchangeStockItemId;

		public String ExchangeSKU;

		public String ExchangeTitle;

		public Int32 ExchangeQuantity;

		public Guid DespatchLocationId;

		public Decimal AdditionalCost;

		public Guid OrderItemRowId;

		public String ReturnItemSKU;

		public String ReturnItemTitle;

		public Int32? BatchInventoryId;

		public Guid ReturnLocation;

		public Int32 ReturnQuantity;

		public Decimal RefundAmount;

		public Guid? RefundRowId;

		public Int32 ScrapQuantity;

		public String ReasonCategory;

		public Boolean IsFreeText;

		public String Reason;

		public String ReasonTag;

		public String SubReasonTag;

		public String BinrackOverride;
	} 
}