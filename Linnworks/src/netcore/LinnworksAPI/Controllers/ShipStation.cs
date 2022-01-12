using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class ShipStationController : BaseController, IShipStationController
    {
        public ShipStationController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Used for ShipStation to create a new ShipStation integration 
        /// </summary>
        /// <param name="integration">An integration object to create</param>
        /// <returns>Create integration with updated id</returns>
        public ShipStationConfig CreateShipStationIntegration(ShipStationConfig integration)
		{
			var response = GetResponse("ShipStation/CreateShipStationIntegration", "integration=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(integration)) + "");
            return JsonFormatter.ConvertFromJson<ShipStationConfig>(response);
		}

		/// <summary>
        /// Used for ShipStation to delete a ShipStation integration by its id 
        /// </summary>
        /// <param name="integrationId">Id of the integration to delete</param>
        public void DeleteShipStationIntegration(String integrationId)
		{
			GetResponse("ShipStation/DeleteShipStationIntegration", "integrationId=" + System.Net.WebUtility.UrlEncode(integrationId) + "");
		}

		/// <summary>
        /// Used for ShipStation to update a ShipStation integration 
        /// </summary>
        /// <param name="integration">An integration object to update</param>
        /// <returns>True if succesfully updated</returns>
        public Boolean EditShipStationIntegration(ShipStationConfig integration)
		{
			var response = GetResponse("ShipStation/EditShipStationIntegration", "integration=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(integration)) + "");
            return JsonFormatter.ConvertFromJson<Boolean>(response);
		}

		/// <summary>
        /// Used for ShipStation to get single ShipStation integration by its id 
        /// </summary>
        /// <param name="integrationId">Id of the integration to retrieve</param>
        /// <returns>An integration if found</returns>
        public ShipStationConfig GetShipStationIntegration(String integrationId)
		{
			var response = GetResponse("ShipStation/GetShipStationIntegration", "integrationId=" + System.Net.WebUtility.UrlEncode(integrationId) + "");
            return JsonFormatter.ConvertFromJson<ShipStationConfig>(response);
		}

		/// <summary>
        /// Used for ShipStation to get all ShipStation integrations 
        /// </summary>
        /// <returns>List of all integrations if any</returns>
        public List<ShipStationConfig> GetShipStationIntegrations()
		{
			var response = GetResponse("ShipStation/GetShipStationIntegrations", "");
            return JsonFormatter.ConvertFromJson<List<ShipStationConfig>>(response);
		} 
    }
}