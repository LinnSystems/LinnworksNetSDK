using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class PostalServicesMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static PostalService CreatePostalService(PostalService_WithChannelAndShippingLinks PostalServiceDetails,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<PostalService>(Factory.GetResponse("PostalServices/CreatePostalService", "PostalServiceDetails=" + Newtonsoft.Json.JsonConvert.SerializeObject(PostalServiceDetails, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void DeletePostalService(Guid idToDelete,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("PostalServices/DeletePostalService", "idToDelete=" + idToDelete + "", ApiToken, ApiServer); 
		}

		public static List<ChannelServiceLinks> GetChannelLinks(Guid postalServiceId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChannelServiceLinks>>(Factory.GetResponse("PostalServices/GetChannelLinks", "postalServiceId=" + postalServiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<PostalService_WithChannelAndShippingLinks> GetPostalServices(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PostalService_WithChannelAndShippingLinks>>(Factory.GetResponse("PostalServices/GetPostalServices", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void UpdatePostalService(PostalService PostalServiceDetails,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("PostalServices/UpdatePostalService", "PostalServiceDetails=" + Newtonsoft.Json.JsonConvert.SerializeObject(PostalServiceDetails, serializerSettings) + "", ApiToken, ApiServer); 
		} 
	}
}