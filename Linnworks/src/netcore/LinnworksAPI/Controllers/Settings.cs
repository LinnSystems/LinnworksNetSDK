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

        public DataPurgeCheckTokenResponse DataPurgeCheckToken(DataPurgeCheckTokenRequest request)
		{
			var response = GetResponse("Settings/DataPurgeCheckToken", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<DataPurgeCheckTokenResponse>(response);
		}

		public DataPurgeCreateTokenResponse DataPurgeCreateToken(DataPurgeBasicRequest request)
		{
			var response = GetResponse("Settings/DataPurgeCreateToken", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<DataPurgeCreateTokenResponse>(response);
		}

		public void DataPurgeDelete(DataPurgeDeleteRequest request)
		{
			GetResponse("Settings/DataPurgeDelete", "request=" + JsonFormatter.ConvertToJson(request) + "");
		}

		public List<DataPurgeFoundEntryResponse> DataPurgeFindEntries(DataPurgeFindEntriesRequest request)
		{
			var response = GetResponse("Settings/DataPurgeFindEntries", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<List<DataPurgeFoundEntryResponse>>(response);
		}

		public DateTime DataPurgeGetLatestDate(DataPurgeBasicRequest request)
		{
			var response = GetResponse("Settings/DataPurgeGetLatestDate", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<DateTime>(response);
		}

		public DataPurgeCreateTokenResponse DataPurgeGetToken(DataPurgeBasicRequest request)
		{
			var response = GetResponse("Settings/DataPurgeGetToken", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<DataPurgeCreateTokenResponse>(response);
		}

		public void DataPurgeObfuscate(DataPurgeObfuscateRequest request)
		{
			GetResponse("Settings/DataPurgeObfuscate", "request=" + JsonFormatter.ConvertToJson(request) + "");
		}

		public void DataPurgeObfuscateOrderSet(DataPurgeObfuscateOrderSetRequest request)
		{
			GetResponse("Settings/DataPurgeObfuscateOrderSet", "request=" + JsonFormatter.ConvertToJson(request) + "");
		}

		public DateTime DataPurgeObfuscationGetLatestDate(DataPurgeBasicRequest request)
		{
			var response = GetResponse("Settings/DataPurgeObfuscationGetLatestDate", "request=" + JsonFormatter.ConvertToJson(request) + "");
            return JsonFormatter.ConvertFromJson<DateTime>(response);
		}

		public void DataPurgeRevokeToken(DataPurgeBasicRequest request)
		{
			GetResponse("Settings/DataPurgeRevokeToken", "request=" + JsonFormatter.ConvertToJson(request) + "");
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