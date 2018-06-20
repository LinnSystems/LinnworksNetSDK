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
public enum PostSaleStatusType
{ NONE,
BOOKED,
CHANNEL_INITIATED,
PENDING,
SUBMITTED,
CONFIRMED,
INTERNAL,
ERROR_HANDLED,
ERROR_LOCKED,
ERROR_UNLOCKED,
OPEN
} 
}