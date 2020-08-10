using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PostageService
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
        /// If tracking number is required for this service 
        /// </summary>
		public Boolean TrackingNumberRequired { get; set; }

		public String Vendor { get; set; }

		public Guid? IntegratedServiceID { get; set; }
	} 
}