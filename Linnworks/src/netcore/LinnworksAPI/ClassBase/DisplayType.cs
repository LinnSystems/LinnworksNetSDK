using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum DisplayType
	{
		None,
		FreeText,
		AutoComplete,
		Dropdown,
		Time,
		NumberOfDays,
		Timezone,
		Currency,
		Percentage,
		Toggle,
		Paragraph,
	}
}