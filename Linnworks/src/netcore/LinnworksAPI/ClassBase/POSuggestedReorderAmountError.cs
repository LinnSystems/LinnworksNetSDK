using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum POSuggestedReorderAmountError
	{
		NO_ERROR,
		ABOVE_MIN_LEVEL,
		SUPPLIER_NOT_FOUND,
		NO_DEFAULT_SUPPLIER,
		STOCK_LEVEL_UNKNOWN,
		UNSPECIFIED_RP_ERROR,
		NO_PREVIOUS_POS,
		BELOW_SUPPLIER_MINIMUM,
		NO_MINIMUM_LEVEL,
		ITEM_UNTRACKED,
		UNSUPPORTED_OO_REQUEST,
		UNSUPPORTED_CALC_TYPE,
	}
}