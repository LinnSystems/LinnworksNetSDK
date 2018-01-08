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
	public class StockItemBatchAudit
	{ 
		public Int32 BatchId;
		public Int32 BatchInventoryId;
		public Int32 QuantityDelta;
		public Decimal StockValueDelta;
		public String ChangeNote;
		public String Username;
		public DateTime ChangeDate;
		public String BinRack;
		public String BatchNumber;
		public String Location;
	} 
}