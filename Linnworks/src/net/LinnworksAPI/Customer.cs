using Newtonsoft.Json;
using System;

namespace LinnworksAPI
{
    public static class CustomerMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static void CreateNewCustomer(CustomerAddress customerDetails, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Customer/CreateNewCustomer", "customerDetails=" + Newtonsoft.Json.JsonConvert.SerializeObject(customerDetails, serializerSettings) + "", ApiToken, ApiServer);
        }
    }
}