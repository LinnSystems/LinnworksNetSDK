using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum OrderProcessedState
	{
		PROCESSED,
		NOT_FOUND,
		SCAN_REQUIRED,
		NOT_PROCESSED,
		NOTE_ACKNOWLEDGEMENT_REQUIRED,
		NOT_IN_WORKFLOW,
	}
}