using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetLatestCurrencyRateResponse
	{
		public String BaseCurrency { get; set; }

		public List<CurrencyRate> Rates { get; set; }
	} 
}