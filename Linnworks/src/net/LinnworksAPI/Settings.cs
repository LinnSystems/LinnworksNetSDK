using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class SettingsMethods
    {
        public static List<CurrencyConversionRate> GetCurrencyConversionRates(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<CurrencyConversionRate>>(Factory.GetResponse("Settings/GetCurrencyConversionRates", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateCurrencyConversionRates(List<CurrencyConversionRate> rates, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Settings/UpdateCurrencyConversionRates", "rates=" + Newtonsoft.Json.JsonConvert.SerializeObject(rates) + "", ApiToken, ApiServer);
        }

        public static Measures GetMeasures(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Measures>(Factory.GetResponse("Settings/GetMeasures", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}