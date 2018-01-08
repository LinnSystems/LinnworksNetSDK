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
	public class ChannelAddress
	{ 
		public String MatchCountryCode;
		public String MatchCountryName;
		public String FullName;
		public String Company;
		public String Address1;
		public String Address2;
		public String Address3;
		public String Town;
		public String Region;
		public String PostCode;
		public String Country;
		public String PhoneNumber;
		public String EmailAddress;
		public Boolean isEmpty;
	} 
}