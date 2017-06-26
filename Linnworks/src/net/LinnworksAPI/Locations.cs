using Newtonsoft.Json;
using System;

namespace LinnworksAPI
{
    public static class LocationsMethods
    {
        public static StockLocation GetLocation(Guid pkStockLocationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StockLocation>(Factory.GetResponse("Locations/GetLocation", "pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AddLocation(StockLocation location, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/AddLocation", "location=" + Factory.SerializeAndUrlEscape(location) + "", ApiToken, ApiServer);
        }

        public static void UpdateLocation(StockLocation location, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/UpdateLocation", "location=" + Factory.SerializeAndUrlEscape(location) + "", ApiToken, ApiServer);
        }

        public static void DeleteLocation(Guid pkStockLocationId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/DeleteLocation", "pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer);
        }
    }
}