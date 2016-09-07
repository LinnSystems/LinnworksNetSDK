using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PostalService_WithChannelAndShippingLinks
    {
        public Guid id;
        public Boolean hasMappedShippingService;
        public IEnumerable<Channel> Channels;
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