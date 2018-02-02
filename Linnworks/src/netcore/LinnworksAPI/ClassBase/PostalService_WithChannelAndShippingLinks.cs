using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class which exposes only those elements required by linnworks.net front end 
    /// </summary>
    public class PostalService_WithChannelAndShippingLinks
	{
        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid id;

        /// <summary>
        /// If there is channel linking with shipping service 
        /// </summary>
		public Boolean hasMappedShippingService;

        /// <summary>
        /// Channel information 
        /// </summary>
		public IEnumerable<Channel> Channels;

        /// <summary>
        /// Shipping service information 
        /// </summary>
		public IEnumerable<ShippingService> ShippingServices;

		public String PostalServiceName;

		public String PostalServiceTag;

		public String ServiceCountry;

		public String PostalServiceCode;

		public String Vendor;

		public String PrintModule;

		public String PrintModuleTitle;

		public Guid pkPostalServiceId;

		public Boolean TrackingNumberRequired;

		public Boolean WeightRequired;

		public Boolean IgnorePackagingGroup;

		public Int32 fkShippingAPIConfigId;

		public Guid? IntegratedServiceId;
	} 
}