using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Shipping quote response 
    /// </summary>
    public class GetShippingQuoteResponse : LinnObject
	{
        /// <summary>
        /// Unique order identifier 
        /// </summary>
		public Guid pkOrderId { get; set; }

        /// <summary>
        /// List of quotes 
        /// </summary>
		public List<ShippingQuoteVendor> Quotes { get; set; }

        /// <summary>
        /// List of errors 
        /// </summary>
		public List<ShippingQuoteVendorError> Errors { get; set; }
	} 
}