using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents currency conversion rate to base currency 
    /// </summary>
    public class CurrencyRate
	{
        /// <summary>
        /// Currency code 
        /// </summary>
		public String Currency { get; set; }

        /// <summary>
        /// Currency rate to Base Currency. CurrencyRate / BaseCurrencyRate = Converted value 
        /// </summary>
		public Decimal? Rate { get; set; }

        /// <summary>
        /// UTC time when the currency rate was updated 
        /// </summary>
		public DateTime? AccurateAsOf { get; set; }
	} 
}