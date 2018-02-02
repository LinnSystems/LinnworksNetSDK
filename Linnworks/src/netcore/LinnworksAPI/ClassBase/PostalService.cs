using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PostalService
	{
		public String PostalServiceName;

		public String PostalServiceTag;

		public String ServiceCountry;

		public String PostalServiceCode;

		public String Vendor;

		public String PrintModule;

		public String PrintModuleTitle;

        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid pkPostalServiceId;

        /// <summary>
        /// If tracking number required for this service 
        /// </summary>
		public Boolean TrackingNumberRequired;

        /// <summary>
        /// If weight required for this service 
        /// </summary>
		public Boolean WeightRequired;

        /// <summary>
        /// If packaging group can be ignored 
        /// </summary>
		public Boolean IgnorePackagingGroup;

		public Int32 fkShippingAPIConfigId;

		public Guid? IntegratedServiceId;
	} 
}