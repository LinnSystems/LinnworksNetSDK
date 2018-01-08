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
	public class OrderItemBatch
	{ 
		public Int32 OrderItemBatchId;
		public Guid OrderItemRowId;
		public Int32 BatchInventoryId;
		public Int32 Quantity;
		public StockItemBatch Batch;
	} 
}