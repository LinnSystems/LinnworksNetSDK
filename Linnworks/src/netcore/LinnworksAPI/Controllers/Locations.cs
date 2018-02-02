using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class LocationsController : BaseController, ILocationsController
    {
        public LocationsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Use this call to add a new location. 
        /// </summary>
        /// <param name="location">The StockLocation object describing the StockLocation to be added.</param>
        public void AddLocation(StockLocation location)
		{
			GetResponse("Locations/AddLocation", "location=" + JsonFormatter.ConvertToJson(location) + "");
		}

		/// <summary>
        /// Use this call to delete a location by its id 
        /// </summary>
        /// <param name="pkStockLocationId">Id of the location to delete</param>
        public void DeleteLocation(Guid pkStockLocationId)
		{
			GetResponse("Locations/DeleteLocation", "pkStockLocationId=" + pkStockLocationId + "");
		}

		/// <summary>
        /// Use this call to retrieve a location and basic information about it from your Linnworks account. 
        /// </summary>
        /// <param name="pkStockLocationId">The pkStockLocationId which identifies the location</param>
        /// <returns>location</returns>
        public StockLocation GetLocation(Guid pkStockLocationId)
		{
			var response = GetResponse("Locations/GetLocation", "pkStockLocationId=" + pkStockLocationId + "");
            return JsonFormatter.ConvertFromJson<StockLocation>(response);
		}

		/// <summary>
        /// Use this call to update a location's name and/or details 
        /// </summary>
        /// <param name="location">Stock location information to update</param>
        public void UpdateLocation(StockLocation location)
		{
			GetResponse("Locations/UpdateLocation", "location=" + JsonFormatter.ConvertToJson(location) + "");
		} 
    }
}