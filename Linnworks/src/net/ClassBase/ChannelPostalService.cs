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
	public class ChannelPostalService
	{ 
		public Int32 fkChannelId;
		public Int32 pkRowId;
		public String FriendlyName;
		public String Tag;
		public String Site;
		public Boolean IsChanged;
	} 
}