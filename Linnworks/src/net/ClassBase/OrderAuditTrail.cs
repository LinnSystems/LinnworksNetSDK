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
	public class OrderAuditTrail
	{ 
		public DateTime Date;
		public String Type;
		public String Note;
		public String User;
		public String fkOrderHistoryTypeId;
		public String Tag;
	} 
}