using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ConfigValueType
	{
		STRING,
		INT,
		DOUBLE,
		BOOLEAN,
		PASSWORD,
		LIST,
		URL,
		BUTTON,
	}
}