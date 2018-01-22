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
	public class PurchaseOrderItem
	{ 
		public Guid pkPurchaseItemId;
		public Guid fkStockItemId;
		public Int32 Quantity;
		public Decimal Cost;
		public Int32 Delivered;
		public Decimal TaxRate;
		public Decimal Tax;
		public Int32 PackQuantity;
		public Int32 PackSize;
		public String SKU;
		public String ItemTitle;
		public Int32 InventoryTrackingType;
		public Boolean IsDeleted;
	} 
}