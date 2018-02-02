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
		public Guid pkPostalServiceId;

        /// <summary>
        /// Postal service name 
        /// </summary>
		public String PostalServiceName;

        /// <summary>
        /// If tracking number is required for this service 
        /// </summary>
		public Boolean TrackingNumberRequired;

		public String Vendor;

		public Guid? IntegratedServiceID;
	} 
}