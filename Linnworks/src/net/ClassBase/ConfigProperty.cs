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
	public class ConfigProperty<Boolean>
	{ 
		public Boolean Loaded;
		public Int32 pkPropertyId;
		public Boolean IsChanged;
		public Boolean PropertyValue;
		public String PropertyType;
	} 
}