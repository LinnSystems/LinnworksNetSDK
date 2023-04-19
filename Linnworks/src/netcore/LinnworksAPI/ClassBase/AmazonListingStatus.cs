using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum AmazonListingStatus
	{
		NOT_LISTED,
		OK,
		CREATING,
		UPDATING,
		UPDATING_PRICE,
		UPDATING_QUANTITY,
		UPDATING_IMAGES,
		CREATING_VARIATION,
		DELETING,
		SEARCHING_FOR_MATCHES,
		UPDATING_SHIPPING,
	}
}