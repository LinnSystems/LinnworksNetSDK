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
	public class ScrapItem
	{ 
		public Guid Id;
		public Guid StockItemId;
		public String ItemNumber;
		public String ItemTitle;
		public Int32 Quantity;
		public String CategoryName;
		public String ScrapReason;
		public Double TotalCost;
		public DateTime CreatedDate;
	} 
}