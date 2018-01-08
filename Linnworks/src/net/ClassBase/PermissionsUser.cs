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
	public class PermissionsUser
	{ 
		public Int32 UserId;
		public Boolean SuperAdmin;
		public Guid fkUserId;
		public String EmailAddress;
		public String UserType;
	} 
}