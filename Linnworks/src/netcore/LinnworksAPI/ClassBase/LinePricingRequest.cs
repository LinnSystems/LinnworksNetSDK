using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LinePricingRequest
	{
        /// <summary>
        /// Price per unit (default from stock item) 
        /// </summary>
		public Double PricePerUnit { get; set; }

        /// <summary>
        /// Discount percentage (default 0) 
        /// </summary>
		public Double DiscountPercentage { get; set; }

        /// <summary>
        /// Tax rate percentage 
        /// </summary>
		public Double TaxRatePercentage { get; set; }

        /// <summary>
        /// Tax inclusive (default true) 
        /// </summary>
		public Boolean TaxInclusive { get; set; }
	} 
}