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
	public class System_Channel_Setting_Property
	{ 
		public Int32 pkPropertyId;
		public Int32 fkChannelId;
		public String PropertyName;
		public String PropertyValue;
		public String PropertyType;
		public Object Source;
	} 
}