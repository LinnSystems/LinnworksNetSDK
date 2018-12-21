using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum FilterType
	{
		HEADER_ID,
		ORDER_ID,
		HEADER_REFERENCE,
		ORDER_REFERENCES,
		ORDER_TRACKING,
		ITEM_INFO,
		CUSTOMER_INFO,
	}
}