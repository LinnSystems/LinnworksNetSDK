using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VerifiedRMAItem
	{
		public ReturnValidationErrorType ReturnValidationError;

		public Int32 RMARowId;

		public Int32 RMAHeaderId;

		public RMAType Type;

		public PostSaleStatus Status;

		public String ExternalReference;

		public Boolean Actioned;

		public DateTime? ActionedDate;

		public Boolean Deleted;

		public Int32 ResendQuantity;

		public Guid NewOrderId;

		public String Error;

		public String Info;

		public Guid ExchangeStockItemId;

		public String ExchangeSKU;

		public Int32 ExchangeQuantity;

		public Guid DespatchLocationId;

		public Decimal AdditionalCost;

		public Guid OrderItemRowId;

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
	} 
}