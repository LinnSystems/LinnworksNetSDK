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
	public class InventoryView
	{ 
		public Guid Id;
		public String Name;
		public ModeType Mode;
		public String Source;
		public String SubSource;
		public String CountryCode;
		public String CountryName;
		public ListingType Listing;
		public Boolean ShowOnlyChanged;
		public IncludeArchived IncludeProducts;
		public List<Filter> Filters;
		public List<Column> Columns;
		public List<Channel> Channels;
	} 
}