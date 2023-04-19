using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum OrderStatus
	{
		Unknown,
		Pending,
		Unshipped,
		PartiallyShipped,
		Shipped,
		PartiallyCancelled,
		Cancelled,
		PartiallyRefunded,
		Refunded,
	}
}