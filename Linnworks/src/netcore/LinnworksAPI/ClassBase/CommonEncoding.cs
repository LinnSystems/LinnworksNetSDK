using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum CommonEncoding
	{
		UTF8,
		UTF16,
		UTF16BE,
		SHIFTJIS,
	}
}