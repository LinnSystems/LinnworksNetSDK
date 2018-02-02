using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum PropertyRuleType
	{
		GreaterThan,
		GreaterThanOrZero,
		LessThan,
		NotEmpty,
		NotEmptyOrDisabled,
		Percent,
		PositiveNumber,
		Regexp,
		Enabled,
		Disabled,
		DisabledSimple,
		Action,
		IsFilledOnce,
		IsReadOnlyPassword,
		ListAtLeastOneSelected,
		ListAtLeastOneOf,
		Hidden,
	}
}