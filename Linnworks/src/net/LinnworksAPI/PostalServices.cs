using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class PostalServicesMethods
    {
        public static List<PostalService_WithChannelAndShippingLinks> GetPostalServices(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PostalService_WithChannelAndShippingLinks>>(Factory.GetResponse("PostalServices/GetPostalServices", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static PostalService CreatePostalService(PostalService_WithChannelAndShippingLinks PostalServiceDetails, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PostalService>(Factory.GetResponse("PostalServices/CreatePostalService", "PostalServiceDetails=" + Newtonsoft.Json.JsonConvert.SerializeObject(PostalServiceDetails) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdatePostalService(PostalService PostalServiceDetails, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("PostalServices/UpdatePostalService", "PostalServiceDetails=" + Newtonsoft.Json.JsonConvert.SerializeObject(PostalServiceDetails) + "", ApiToken, ApiServer);
        }

        public static void DeletePostalService(Guid idToDelete, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("PostalServices/DeletePostalService", "idToDelete=" + idToDelete + "", ApiToken, ApiServer);
        }

        public static List<ChannelServiceLinks> GetChannelLinks(Guid postalServiceId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ChannelServiceLinks>>(Factory.GetResponse("PostalServices/GetChannelLinks", "postalServiceId=" + postalServiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}