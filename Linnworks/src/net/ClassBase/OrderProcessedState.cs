using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{ [JsonConverter(typeof(StringEnumConverter))]
public enum OrderProcessedState
{ PROCESSED,
NOT_FOUND,
SCAN_REQUIRED,
NOT_PROCESSED,
NOTE_ACKNOWLEDGEMENT_REQUIRED,
NOT_IN_WORKFLOW,
 
} 
}