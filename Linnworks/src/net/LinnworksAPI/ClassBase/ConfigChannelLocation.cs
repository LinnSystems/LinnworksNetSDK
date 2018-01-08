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
	public class ConfigChannelLocation
	{ 
		public Int32 pkChannelLocationId;
		public Boolean Deleted;
		public String Identifier;
		public String Name;
		public Guid OrderDownloadLocation;
		public List<Guid> InventorySyncLocations;
	} 
}