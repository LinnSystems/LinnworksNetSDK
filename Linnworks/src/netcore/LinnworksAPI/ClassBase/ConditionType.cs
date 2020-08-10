using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ConditionType
	{
		Equals,
		Contains,
		Less,
		Greater,
		NotEquals,
		NotContains,
		Exists,
		Listed,
		NotListed,
		HasError,
		OnlyErrors,
		NoErrors,
		HasWarning,
		LastDays,
		OlderThan,
		Next,
		Is,
		InTheFeed,
		NotInTheFeed,
	}
}