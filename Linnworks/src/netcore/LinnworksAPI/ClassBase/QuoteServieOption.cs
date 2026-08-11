using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Shipping quote service options 
    /// </summary>
    public class QuoteServieOption : LinnObject
	{
        /// <summary>
        /// Options name 
        /// </summary>
		public String OptionName { get; set; }

        /// <summary>
        /// Options value 
        /// </summary>
		public String OptionValue { get; set; }
	} 
}