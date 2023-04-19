using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ShippingMethod : LinnObject
	{
        /// <summary>
        /// Courier name 
        /// </summary>
		public String Vendor { get; set; }

        /// <summary>
        /// List of postal services 
        /// </summary>
		public List<PostageService> PostalServices { get; set; }
	} 
}