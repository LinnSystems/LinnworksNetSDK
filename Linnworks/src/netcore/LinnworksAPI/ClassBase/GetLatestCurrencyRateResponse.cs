using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetLatestCurrencyRateResponse
	{
		public String BaseCurrency;

		public List<CurrencyRate> Rates;
	} 
}