using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ProductIdentifierType
	{
		EAN,
		MPN,
		GTIN,
		UPC,
		ASIN,
		ISBN,
		Google,
		CustomID,
		PZN,
		GCID,
		ePID,
		AMZNTRANS,
		SERIAL,
		IMEI,
	}
}