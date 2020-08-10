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
		public Guid id { get; set; }

        /// <summary>
        /// If there is channel linking with shipping service 
        /// </summary>
		public Boolean hasMappedShippingService { get; set; }

        /// <summary>
        /// Channel information 
        /// </summary>
		public IEnumerable<Channel> Channels { get; set; }

        /// <summary>
        /// Shipping service information 
        /// </summary>
		public IEnumerable<ShippingService> ShippingServices { get; set; }

		public String PostalServiceName { get; set; }

		public String PostalServiceTag { get; set; }

		public String ServiceCountry { get; set; }

		public String PostalServiceCode { get; set; }

		public String Vendor { get; set; }

		public String PrintModule { get; set; }

		public String PrintModuleTitle { get; set; }

		public Guid pkPostalServiceId { get; set; }

		public Boolean TrackingNumberRequired { get; set; }

		public Boolean WeightRequired { get; set; }

		public Boolean IgnorePackagingGroup { get; set; }

		public Int32 fkShippingAPIConfigId { get; set; }

		public Guid? IntegratedServiceId { get; set; }
	} 
}