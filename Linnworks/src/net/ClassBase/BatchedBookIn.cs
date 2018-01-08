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
	public class BatchedBookIn
	{ 
		public String SKU;
		public String BatchNumber;
		public Guid LocationId;
		public String BinRack;
		public Int32 Quantity;
		public Decimal StockValue;
		public String BatchStatus;
		public Int16? PrioritySequence;
		public DateTime? ExpiresOn;
		public DateTime? SellBy;
	} 
}