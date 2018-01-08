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
	public class RuleActionProperty
	{ 
		public Int32 ActionPropertyId;
		public Int32 ActionId;
		public String DisplayName;
		public String Value;
	} 
}