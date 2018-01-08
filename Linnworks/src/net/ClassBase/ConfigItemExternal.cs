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
	public class ConfigItemExternal
	{ 
		public Int32 Length;
		public Int64 LongLength;
		public Int32 Rank;
		public Object SyncRoot;
		public Boolean IsReadOnly;
		public Boolean IsFixedSize;
		public Boolean IsSynchronized;
	} 
}