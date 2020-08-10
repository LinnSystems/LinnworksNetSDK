using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Purchase order payment statement 
    /// </summary>
    public class PurchaseOrderPaymentStatement
	{
        /// <summary>
        /// Unique record id 
        /// </summary>
		public Int32 PurchasePaymentStatementId { get; set; }

        /// <summary>
        /// Cost of the purchase order the payment contributes to 
        /// </summary>
		public Decimal LineCost { get; set; }

        /// <summary>
        /// Conversion rate from system currency, i.e. system currency rate to additional cost currency.
        /// For example if your system currency is GBP and payment statement cost is in USD the converted value is USD / Rate, example calculation, Rate 1.27, Additional cost total is 100, converted value = 100 USD / 1.27 = 78.98 GBP 
        /// </summary>
		public Decimal ConversionRate { get; set; }

        /// <summary>
        /// Currency code 
        /// </summary>
		public String Currency { get; set; }

        /// <summary>
        /// Payment Statement reference 
        /// </summary>
		public String Reference { get; set; }

        /// <summary>
        /// Date when the payment statement was added 
        /// </summary>
		public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date when payment statement was marked as paid 
        /// </summary>
		public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Relation to additional cost line. If no value is set then the payment statement relates to PO supplier 
        /// </summary>
		public Int32? fkPurchaseAdditionalCostItemId { get; set; }
	} 
}