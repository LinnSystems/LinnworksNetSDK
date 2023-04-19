using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum JTokenType
	{
		None,
		Object,
		Array,
		Constructor,
		Property,
		Comment,
		Integer,
		Float,
		String,
		Boolean,
		Null,
		Undefined,
		Date,
		Raw,
		Bytes,
		Guid,
		Uri,
		TimeSpan,
	}
}