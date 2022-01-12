using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderTotalsInfo
	{
        /// <summary>
        /// Order subtotal 
        /// </summary>
		public Double Subtotal { get; set; }

        /// <summary>
        /// Order postage cost 
        /// </summary>
		public Double PostageCost { get; set; }

        /// <summary>
        /// Order postage cost ex. tax 
        /// </summary>
		public Double PostageCostExTax { get; set; }

        /// <summary>
        /// Tax 
        /// </summary>
		public Double Tax { get; set; }

        /// <summary>
        /// Total charge 
        /// </summary>
		public Double TotalCharge { get; set; }

        /// <summary>
        /// Payment method 
        /// </summary>
		public String PaymentMethod { get; set; }

        /// <summary>
        /// Payment method ID 
        /// </summary>
		public Guid PaymentMethodId { get; set; }

        /// <summary>
        /// Profit margin 
        /// </summary>
		public Double ProfitMargin { get; set; }

        /// <summary>
        /// Total discount applied to the order 
        /// </summary>
		public Double TotalDiscount { get; set; }

        /// <summary>
        /// Order currency 
        /// </summary>
		public String Currency { get; set; }

        /// <summary>
        /// Country tax rate 
        /// </summary>
		public Double CountryTaxRate { get; set; }

        /// <summary>
        /// Currency conversion rate. Set at point of save by the currency 
        /// </summary>
		public Double ConversionRate { get; set; }
	} 
}