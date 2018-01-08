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
	public class OrderPackagingSplitItem
	{ 
		public List<OrderItemShippingBatchWithRow> AssignedBatches;
		public Guid RowId;
		public Int32 Quantity;
		public String TrackingNumber;
		public Double Weight;
		public String SKU;
		public String Title;
		public Boolean IsBatched;
	} 
}