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
	public class StockCategoryLocation
	{ 
		public Guid StockLocationId;
		public String CategoryName;
		public Guid CategoryId;
		public Int32 StockLevel;
		public Double StockValue;
	} 
}