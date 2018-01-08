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
	public class Add_PurchaseOrderItemParameter
	{ 
		public Guid pkPurchaseId;
		public Guid fkStockItemId;
		public Int32 Qty;
		public Int32 PackQuantity;
		public Int32 PackSize;
		public Decimal Cost;
		public Decimal TaxRate;
	} 
}