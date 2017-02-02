using Newtonsoft.Json;
using System;

namespace LinnworksAPI
{
    public static class LocationsMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static StockLocation GetLocation(Guid pkStockLocationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StockLocation>(Factory.GetResponse("Locations/GetLocation", "pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AddLocation(StockLocation location, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/AddLocation", "location=" + Newtonsoft.Json.JsonConvert.SerializeObject(location, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void UpdateLocation(StockLocation location, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/UpdateLocation", "location=" + Newtonsoft.Json.JsonConvert.SerializeObject(location, serializerSettings) + "", ApiToken, ApiServer);
        }

        public static void DeleteLocation(Guid pkStockLocationId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/DeleteLocation", "pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer);
        }
    }
}