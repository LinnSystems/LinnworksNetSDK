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
	public class RowQty
	{ 
		public Guid OrderItemRowId;
		public Int32? OrderItemBatchId;
		public Double Refund;
		public Int32 Qty;
		public Int32? ScrapQty;
		public Double AdditionalCost;
		public Guid? NewStockItemId;
		public Int32 NewQty;
	} 
}