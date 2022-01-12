using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum FulfillmentState
	{
		Unknown,
		Insufficient_Stock,
		Insufficient_To_Fulfill_All,
		Sufficient_Stock,
	}
}