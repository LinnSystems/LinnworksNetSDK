using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ShippingService
	{
        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid pkPostalServiceId { get; set; }

        /// <summary>
        /// Postal service name 
        /// </summary>
		public String PostalServiceName { get; set; }

        /// <summary>
        /// Courier name (e.g. Royal Mail) 
        /// </summary>
		public String vendor { get; set; }

        /// <summary>
        /// Shipping account ID 
        /// </summary>
		public String accountid { get; set; }

        /// <summary>
        /// Courier Friendly Name (e.g. FedEx (US) for ShipEngine) 
        /// </summary>
		public String vendorFriendlyName { get; set; }
	} 
}