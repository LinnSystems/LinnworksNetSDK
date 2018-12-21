using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ChannelReasonTypes
	{
		None,
		Cancellation,
		ItemRefund,
		ShippingRefund,
		ServiceRefund,
		ItemReturn,
		InsufficientRefund,
		AdditionalRefund,
	}
}