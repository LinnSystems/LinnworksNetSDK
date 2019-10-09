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
		public Guid pkPostalServiceId;

        /// <summary>
        /// Postal service name 
        /// </summary>
		public String PostalServiceName;

        /// <summary>
        /// Courier name (e.g. Royal Mail) 
        /// </summary>
		public String vendor;

        /// <summary>
        /// Shipping account ID 
        /// </summary>
		public String accountid;

        /// <summary>
        /// Courier Friendly Name (e.g. FedEx (US) for ShipEngine) 
        /// </summary>
		public String vendorFriendlyName;
	} 
}