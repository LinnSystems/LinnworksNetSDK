using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Product Identifiers 
    /// </summary>
    public class ProductIdentifier : LinnObject
	{
        /// <summary>
        /// Product identifier type 
        /// </summary>
		public String Type { get; set; }

        /// <summary>
        /// Product identifier value 
        /// </summary>
		public String Value { get; set; }

        /// <summary>
        /// Product identifier site 
        /// </summary>
		public String Site { get; set; }
	} 
}