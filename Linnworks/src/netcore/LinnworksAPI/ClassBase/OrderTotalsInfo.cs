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
		public Double Subtotal;

        /// <summary>
        /// Order postage cost 
        /// </summary>
		public Double PostageCost;

        /// <summary>
        /// Tax 
        /// </summary>
		public Double Tax;

        /// <summary>
        /// Total charge 
        /// </summary>
		public Double TotalCharge;

        /// <summary>
        /// Payment method 
        /// </summary>
		public String PaymentMethod;

        /// <summary>
        /// Payment method ID 
        /// </summary>
		public Guid PaymentMethodId;

        /// <summary>
        /// Profit margin 
        /// </summary>
		public Double ProfitMargin;

        /// <summary>
        /// Total discount applied to the order 
        /// </summary>
		public Double TotalDiscount;

        /// <summary>
        /// Order currency 
        /// </summary>
		public String Currency;

        /// <summary>
        /// Country tax rate 
        /// </summary>
		public Double CountryTaxRate;
	} 
}