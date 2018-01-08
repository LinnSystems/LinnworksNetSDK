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
	public class StockItemBatch
	{ 
		public Int32 BatchId;
		public String SKU;
		public Int32 InventoryTrackingType;
		public Guid StockItemId;
		public String BatchNumber;
		public DateTime ExpiresOn;
		public DateTime SellBy;
		public List<StockItemBatchInventory> Inventory;
		public Boolean IsDeleted;
		public IEnumerable<StockItemBatchInventory> Item;
	} 
}