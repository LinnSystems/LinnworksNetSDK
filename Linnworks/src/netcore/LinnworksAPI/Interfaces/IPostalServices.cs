using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IPostalServicesController
	{
		PostalService CreatePostalService(PostalService_WithChannelAndShippingLinks PostalServiceDetails);
		void DeletePostalService(Guid idToDelete);
		List<ChannelServiceLinks> GetChannelLinks(Guid postalServiceId);
		List<PostalService_WithChannelAndShippingLinks> GetPostalServices();
		void UpdatePostalService(PostalService PostalServiceDetails);
	} 
}