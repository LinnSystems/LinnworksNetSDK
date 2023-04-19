using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatePaymentStatementItem : LinnObject
	{
        /// <summary>
        /// Payment Statement line row id, uniquely identifying each cost line 
        /// </summary>
		public Int32 PurchasePaymentStatementId { get; set; }

        /// <summary>
        /// Each item in the request can have unique Id supplied (uniqueidentifier) this Id will be returned to you in the response so you can match request item with the response 
        /// </summary>
		public Guid Id { get; set; }

		public String Reference { get; set; }

		public Decimal ConversionRate { get; set; }

		public String Currency { get; set; }

		public Int32? fkPurchaseAdditionalCostItemId { get; set; }

		public Decimal LineCost { get; set; }

		public DateTime? PaymentDate { get; set; }

		public DateTime CreationDate { get; set; }
	} 
}