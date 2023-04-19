using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum AmazonAttributeType
	{
		Unknown,
		String,
		Integer,
		Decimal,
		Enum,
		Boolean,
		DateTime,
	}
}