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
	public class CountryRegion
	{ 
		public Int32 pkRegionRowId;
		public String RegionCode;
		public String RegionName;
		public Double? TaxRate;
		public Guid fkCountryId;
		public CountryRegionReplaceWith ReplaceWith;
		public Boolean IsHomeRegion;
		public Int32 TagsCount;
	} 
}