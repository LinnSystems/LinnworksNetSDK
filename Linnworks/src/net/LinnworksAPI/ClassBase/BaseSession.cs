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
	public class BaseSession
	{ 
		public DateTime LastActivity;
		public String Device;
		public String DeviceType;
		public String Server;
		public StatusDetails Status;
		public String BsonId;
		public Guid Id;
		public String Email;
		public Guid UserId;
		public String UserName;
		public String UserType;
		public Guid Token;
		public Guid EntityId;
		public String GroupName;
		public LocalityType Locality;
		public Dictionary<String,String> Properties;
	} 
}