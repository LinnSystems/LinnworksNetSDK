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
	public class StockItemPrice
	{ 
		public Guid pkRowId;
		public String Source;
		public String SubSource;
		public Double Price;
		public UpdateStatusType UpdateStatus;
		public String Tag;
		public List<StockItemPricingRule> Rules;
		public Guid StockItemId;
	} 
}