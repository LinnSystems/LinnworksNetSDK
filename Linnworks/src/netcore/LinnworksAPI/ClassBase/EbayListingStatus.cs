using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum EbayListingStatus
	{
		NOT_LISTED,
		OK,
		CREATING,
		UPDATING,
		DELETING,
		LISTING,
		ENDING,
		MANUALLY_ENDED,
		MIGRATING,
	}
}