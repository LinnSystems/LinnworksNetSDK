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
	public class StockItemEbayCompatibility
	{ 
		public Guid FkStockItemId;
		public Guid FkCompatibilityListId;
		public String CompatibilityNotes;
		public String Value;
		public String IncludeYears;
		public String ExcludeYears;
	} 
}