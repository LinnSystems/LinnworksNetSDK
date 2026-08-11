using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum RulesEngineActionType
	{
		Unknown,
		AssignShippingService,
		AssignToFolder,
		AssignToLocation,
		SplitOrderByWeight,
		SplitOrderByValue,
		SplitOrderSingle,
		AssignOrderExtendedProperty,
		ChangeOrderLockStatus,
		ChangeOrderParkStatus,
		AssignTagToOrder,
		ExecuteMacro,
		AssignIdentifierToOrder,
		BlockOrderFromMerging,
		SendToFulfillmentNetwork,
		SetDispatchDate,
		AddItemToOrder,
		AddServiceToOrder,
		AddNoteToOrder,
	}
}