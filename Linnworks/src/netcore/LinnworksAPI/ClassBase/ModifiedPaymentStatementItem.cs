using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ModifiedPaymentStatementItem
	{
		public Guid Id;

		public Int32 PurchasePaymentStatementId;

		public Decimal LineCost;

		public Decimal ConversionRate;

		public String Currency;

		public String Reference;

		public DateTime CreationDate;

		public DateTime? PaymentDate;

		public Int32? fkPurchaseAdditionalCostItemId;
	} 
}