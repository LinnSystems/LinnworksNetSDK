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
{ 
	public class Filter
	{ 
		public FilterNameType FilterName;
		public String DisplayName;
		public List<String> FilterNameExact;
		public FieldType Field;
		public ConditionType Condition;
		public String ConditionDisplayName;
		public String Value;
	} 
}