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
	public class Country
	{ 
		public Guid CountryId;
		public String CountryName;
		public String CountryCode;
		public String Continent;
		public String Currency;
		public Boolean CustomsRequired;
		public Double? TaxRate;
		public String AddressFormat;
		public List<CountryRegion> Regions;
		public Int32 RegionsCount;
	} 
}