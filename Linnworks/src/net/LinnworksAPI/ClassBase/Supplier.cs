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
	public class Supplier
	{ 
		public Guid pkSupplierID;
		public String SupplierName;
		public String ContactName;
		public String Address;
		public String AlternativeAddress;
		public String City;
		public String Region;
		public String Country;
		public String PostCode;
		public String TelephoneNumber;
		public String SecondaryTelNumber;
		public String FaxNumber;
		public String Email;
		public String WebPage;
		public String Currency;
	} 
}