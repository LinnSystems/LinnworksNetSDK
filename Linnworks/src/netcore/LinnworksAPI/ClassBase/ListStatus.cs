using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum ListStatus
	{
		NOT_LISTED,
		OK,
		WAITING_FOR_LISTING,
		UPDATING,
		CREATING,
		DELETING,
		WAITING_FOR_UPDATE,
		PROCESSING,
		UPDATE_ERROR,
	}
}