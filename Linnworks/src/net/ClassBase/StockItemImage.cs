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
	public class StockItemImage
	{ 
		public String Source;
		public String FullSource;
		public String CheckSumValue;
		public Guid pkRowId;
		public Boolean IsMain;
		public Int32 SortOrder;
		public Guid StockItemId;
	} 
}