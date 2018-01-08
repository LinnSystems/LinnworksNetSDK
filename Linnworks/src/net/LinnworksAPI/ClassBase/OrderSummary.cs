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
	public class OrderSummary
	{ 
		public Guid OrderId;
		public Int32 NumOrderId;
		public DateTime ReceivedDate;
		public DateTime ProcessDate;
		public String Source;
		public String CustomerName;
		public Int32 NumProducts;
		public Guid FulfillmentLocationId;
	} 
}