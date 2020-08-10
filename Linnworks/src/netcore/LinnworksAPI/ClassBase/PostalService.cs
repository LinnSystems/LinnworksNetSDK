using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PostalService
	{
		public String PostalServiceName { get; set; }

		public String PostalServiceTag { get; set; }

		public String ServiceCountry { get; set; }

		public String PostalServiceCode { get; set; }

		public String Vendor { get; set; }

		public String PrintModule { get; set; }

		public String PrintModuleTitle { get; set; }

        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid pkPostalServiceId { get; set; }

        /// <summary>
        /// If tracking number required for this service 
        /// </summary>
		public Boolean TrackingNumberRequired { get; set; }

        /// <summary>
        /// If weight required for this service 
        /// </summary>
		public Boolean WeightRequired { get; set; }

        /// <summary>
        /// If packaging group can be ignored 
        /// </summary>
		public Boolean IgnorePackagingGroup { get; set; }

		public Int32 fkShippingAPIConfigId { get; set; }

		public Guid? IntegratedServiceId { get; set; }
	} 
}