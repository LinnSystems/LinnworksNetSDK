using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Integration account for shipping quote request 
    /// </summary>
    public class ShippingQuoteAccounts : LinnObject
	{
        /// <summary>
        /// Vendor name 
        /// </summary>
		public String Vendor { get; set; }

        /// <summary>
        /// Account Id 
        /// </summary>
		public String AccountId { get; set; }

        /// <summary>
        /// VendorFriendlyName 
        /// </summary>
		public String VendorFriendlyName { get; set; }
	} 
}