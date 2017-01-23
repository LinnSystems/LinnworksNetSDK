using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class SettingsMethods
    {
        public static List<CurrencyConversionRate> GetCurrencyConversionRates(GetConversionRatesRequest requestParams, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<CurrencyConversionRate>>(Factory.GetResponse("Settings/GetCurrencyConversionRates", "requestParams=" + Newtonsoft.Json.JsonConvert.SerializeObject(requestParams) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UpdateCurrencyConversionRates(List<CurrencyConversionRate> rates, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Settings/UpdateCurrencyConversionRates", "rates=" + Factory.SerializeAndUrlEscape(rates) + "", ApiToken, ApiServer);
        }

        public static void InsertCurrencyConversionRates(List<CurrencyConversionRate> rates, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Settings/InsertCurrencyConversionRates", "rates=" + Newtonsoft.Json.JsonConvert.SerializeObject(rates) + "", ApiToken, ApiServer);
        }

        public static void DeleteCurrencyConversionRates(List<String> currencies, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Settings/DeleteCurrencyConversionRates", "currencies=" + Newtonsoft.Json.JsonConvert.SerializeObject(currencies) + "", ApiToken, ApiServer);
        }

        public static Measures GetMeasures(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Measures>(Factory.GetResponse("Settings/GetMeasures", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}