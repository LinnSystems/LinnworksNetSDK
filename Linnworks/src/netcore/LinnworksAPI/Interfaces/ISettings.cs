using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface ISettingsController
	{
		DataPurgeCheckTokenResponse DataPurgeCheckToken(DataPurgeCheckTokenRequest request);
		DataPurgeCreateTokenResponse DataPurgeCreateToken(DataPurgeBasicRequest request);
		void DataPurgeDelete(DataPurgeDeleteRequest request);
		List<DataPurgeFoundEntryResponse> DataPurgeFindEntries(DataPurgeFindEntriesRequest request);
		DateTime DataPurgeGetLatestDate(DataPurgeBasicRequest request);
		DataPurgeCreateTokenResponse DataPurgeGetToken(DataPurgeBasicRequest request);
		void DataPurgeObfuscate(DataPurgeObfuscateRequest request);
		void DataPurgeObfuscateOrderSet(DataPurgeObfuscateOrderSetRequest request);
		DateTime DataPurgeObfuscationGetLatestDate(DataPurgeBasicRequest request);
		void DataPurgeRevokeToken(DataPurgeBasicRequest request);
		void DeleteCurrencyConversionRates(List<String> currencies);
		List<CurrencyConversionRate> GetCurrencyConversionRates(GetConversionRatesRequest requestParams);
		Measures GetMeasures();
		void InsertCurrencyConversionRates(List<CurrencyConversionRate> rates);
		void UpdateCurrencyConversionRates(List<CurrencyConversionRate> rates);
	} 
}