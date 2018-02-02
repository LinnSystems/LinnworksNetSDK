using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{
    public class SettingsController : BaseController, ISettingsController
    {
        public SettingsController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Delete currency conversion rates 
        /// </summary>
        /// <param name="currencies">Currencies to delete</param>
        public void DeleteCurrencyConversionRates(List<String> currencies)
		{
			GetResponse("Settings/DeleteCurrencyConversionRates", "currencies=" + JsonFormatter.ConvertToJson(currencies) + "");
		}

		/// <summary>
        /// Get Currency Conversion Rates 
        /// </summary>
        /// <param name="requestParams">GetCurrenciesFromOrders: Load currencies from the orders table and save before returning
        /// Currency: Get a specific currency rate. Leave empty to get all</param>
        public List<CurrencyConversionRate> GetCurrencyConversionRates(GetConversionRatesRequest requestParams)
		{
			var response = GetResponse("Settings/GetCurrencyConversionRates", "requestParams=" + JsonFormatter.ConvertToJson(requestParams) + "");
            return JsonFormatter.ConvertFromJson<List<CurrencyConversionRate>>(response);
		}

		/// <summary>
        /// Get user measures units from the database 
        /// </summary>
        public Measures GetMeasures()
		{
			var response = GetResponse("Settings/GetMeasures", "");
            return JsonFormatter.ConvertFromJson<Measures>(response);
		}

		/// <summary>
        /// Insert currency conversion rates 
        /// </summary>
        /// <param name="rates">Currencies to insert</param>
        public void InsertCurrencyConversionRates(List<CurrencyConversionRate> rates)
		{
			GetResponse("Settings/InsertCurrencyConversionRates", "rates=" + JsonFormatter.ConvertToJson(rates) + "");
		}

		/// <summary>
        /// Update Currency Conversion Rates 
        /// </summary>
        /// <param name="rates">Rates to update. Currency is the key</param>
        public void UpdateCurrencyConversionRates(List<CurrencyConversionRate> rates)
		{
			GetResponse("Settings/UpdateCurrencyConversionRates", "rates=" + JsonFormatter.ConvertToJson(rates) + "");
		} 
    }
}