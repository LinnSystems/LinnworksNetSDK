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
public enum PropertyRuleType
{ GreaterThan,
GreaterThanOrZero,
LessThan,
NotEmpty,
NotEmptyOrDisabled,
Percent,
PositiveNumber,
Regexp,
Enabled,
Disabled,
DisabledSimple,
Action,
IsFilledOnce,
IsReadOnlyPassword,
ListAtLeastOneSelected,
ListAtLeastOneOf,
Hidden,
 
} 
}