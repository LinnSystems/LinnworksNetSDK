using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Add payment statement item Id 
    /// </summary>
    public class AddPaymentStatementItem
	{
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