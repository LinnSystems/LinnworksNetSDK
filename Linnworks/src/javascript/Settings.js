var Settings =
{
	// http://apidoc.linnworks.net/#/Settings-DeleteCurrencyConversionRates
	DeleteCurrencyConversionRates: function(currencies,token, server)
	{
		return Factory.GetResponse("Settings/DeleteCurrencyConversionRates", token, server, "currencies=" + JSON.stringify(currencies) +"");
	},
	// http://apidoc.linnworks.net/#/Settings-GetCurrencyConversionRates
	GetCurrencyConversionRates: function(requestParams,token, server)
	{
		return Factory.GetResponse("Settings/GetCurrencyConversionRates", token, server, "requestParams=" + JSON.stringify(requestParams) +"");
	},
	// http://apidoc.linnworks.net/#/Settings-GetMeasures
	GetMeasures: function(token, server)
	{
		return Factory.GetResponse("Settings/GetMeasures", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Settings-InsertCurrencyConversionRates
	InsertCurrencyConversionRates: function(rates,token, server)
	{
		return Factory.GetResponse("Settings/InsertCurrencyConversionRates", token, server, "rates=" + JSON.stringify(rates) +"");
	},
	// http://apidoc.linnworks.net/#/Settings-UpdateCurrencyConversionRates
	UpdateCurrencyConversionRates: function(rates,token, server)
	{
		return Factory.GetResponse("Settings/UpdateCurrencyConversionRates", token, server, "rates=" + JSON.stringify(rates) +"");
	},
};
