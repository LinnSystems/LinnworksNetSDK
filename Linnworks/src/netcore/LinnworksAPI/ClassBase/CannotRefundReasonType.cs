using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum CannotRefundReasonType
	{
		None,
		NotImplemented,
		DisabledInConfig,
		MissingOrderInLinnworks,
		OpenOrderInLinnworks,
		OrderIsFullyRefundedInLinnworks,
		NoNewRefundsSpecified,
		NoUpdatedRefundsSpecified,
		MultipleReferences,
		SubStatusTagNotInTheSystem,
		SubStatusTagIsNotActionable,
		MultipleSubStatusTags,
		RefundNotInSystem,
		Other,
	}
}