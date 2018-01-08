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
	public class SplitPackaging
	{ 
		public Int32 BinIndex;
		public String ItemTitle;
		public String PackageTitle;
		public Guid pkBinId;
		public Guid fkOrderItemRowId;
		public Int32 Quantity;
		public String SKU;
		public String TrackingNumber;
		public Double Weight;
	} 
}