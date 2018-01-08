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
	public class LowStockLevel
	{ 
		public String ItemTitle;
		public String ItemNumber;
		public Int32 Quantity;
		public Int32 MinimumLevel;
		public Int32 InBooks;
		public String Location;
	} 
}