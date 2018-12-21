using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum CannotReturnReasonType
	{
		None,
		NotImplemented,
		DisabledInConfig,
		MissingOrderInLinnworks,
		OpenOrderInLinnworks,
		AlreadyReturnedOnChannel,
		AlreadyReturnedInLinnworks,
		NoNewRMAsSpecified,
		SubStatusTagNotInTheSystem,
		SubStatusTagIsNotActionable,
		MultipleSubStatusTags,
		Other,
	}
}