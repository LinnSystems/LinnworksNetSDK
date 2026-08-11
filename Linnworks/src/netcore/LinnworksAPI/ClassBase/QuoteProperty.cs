using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Shipping quote property 
    /// </summary>
    public class QuoteProperty : LinnObject
	{
        /// <summary>
        /// Property title 
        /// </summary>
		public String Title { get; set; }

        /// <summary>
        /// Property value 
        /// </summary>
		public String Value { get; set; }
	} 
}