using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ModifiedPaymentStatementItem
	{
		public Guid Id { get; set; }

		public Int32 PurchasePaymentStatementId { get; set; }

		public Decimal LineCost { get; set; }

		public Decimal ConversionRate { get; set; }

		public String Currency { get; set; }

		public String Reference { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime? PaymentDate { get; set; }

		public Int32? fkPurchaseAdditionalCostItemId { get; set; }
	} 
}