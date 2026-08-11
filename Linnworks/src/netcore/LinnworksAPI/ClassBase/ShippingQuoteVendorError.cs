using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ShippingQuoteVendorError : LinnObject
	{
		public String Vendor { get; set; }

		public String FriendlyName { get; set; }

		public String IconURL { get; set; }

		public String AccountId { get; set; }

		public String ErrorMessage { get; set; }
	} 
}