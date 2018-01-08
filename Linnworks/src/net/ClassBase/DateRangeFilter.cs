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
	public class DateRangeFilter
	{ 
		public DateTime ValueFrom;
		public DateTime ValueTo;
		public Int32 Days;
		public Boolean Enabled;
		public String Type;
	} 
}