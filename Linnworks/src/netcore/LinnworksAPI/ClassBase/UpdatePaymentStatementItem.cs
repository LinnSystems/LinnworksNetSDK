using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatePaymentStatementItem
	{
        /// <summary>
        /// Payment Statement line row id, uniquely identifying each cost line 
        /// </summary>
		public Int32 PurchasePaymentStatementId;

        /// <summary>
        /// Each item in the request can have unique Id supplied (uniqueidentifier) this Id will be returned to you in the response so you can match request item with the response 
        /// </summary>
		public Guid Id;

		public String Reference;

		public Decimal ConversionRate;

		public String Currency;

		public Int32? fkPurchaseAdditionalCostItemId;

		public Decimal LineCost;

		public DateTime? PaymentDate;

		public DateTime CreationDate;
	} 
}