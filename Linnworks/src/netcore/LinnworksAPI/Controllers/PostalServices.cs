using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class PostalServicesController : BaseController, IPostalServicesController
    {
        public PostalServicesController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Adds a new postal service to the database 
        /// </summary>
        /// <param name="PostalServiceDetails">Information about postal service</param>
        /// <returns>The data of the created service</returns>
        public PostalService CreatePostalService(PostalService_WithChannelAndShippingLinks PostalServiceDetails)
		{
			var response = GetResponse("PostalServices/CreatePostalService", "PostalServiceDetails=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(PostalServiceDetails)) + "");
            return JsonFormatter.ConvertFromJson<PostalService>(response);
		}

		/// <summary>
        /// Changes an existing postal service in the database 
        /// </summary>
        /// <param name="idToDelete">Postal service ID to delete</param>
        /// <returns>The data of the created service</returns>
        public void DeletePostalService(Guid idToDelete)
		{
			GetResponse("PostalServices/DeletePostalService", "idToDelete=" + idToDelete + "");
		}

		/// <summary>
        /// Returns Channel Service Link Information 
        /// </summary>
        /// <param name="postalServiceId">Postal service ID</param>
        /// <returns>The data used for showing assoiated Channel Services in Postal Services.</returns>
        public List<ChannelServiceLinks> GetChannelLinks(Guid postalServiceId)
		{
			var response = GetResponse("PostalServices/GetChannelLinks", "postalServiceId=" + postalServiceId + "");
            return JsonFormatter.ConvertFromJson<List<ChannelServiceLinks>>(response);
		}

		/// <summary>
        /// Gets a list of the users postal services and information on channels and couriers linked to each service 
        /// </summary>
        /// <returns>List of data</returns>
        public List<PostalService_WithChannelAndShippingLinks> GetPostalServices()
		{
			var response = GetResponse("PostalServices/GetPostalServices", "");
            return JsonFormatter.ConvertFromJson<List<PostalService_WithChannelAndShippingLinks>>(response);
		}

		/// <summary>
        /// Changes an existing postal service in the database 
        /// </summary>
        /// <param name="PostalServiceDetails">Information about postal service</param>
        /// <returns>The data of the created service</returns>
        public void UpdatePostalService(PostalService PostalServiceDetails)
		{
			GetResponse("PostalServices/UpdatePostalService", "PostalServiceDetails=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(PostalServiceDetails)) + "");
		} 
    }
}