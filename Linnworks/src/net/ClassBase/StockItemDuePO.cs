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
	public class StockItemDuePO
	{ 
		public String SupplierName;
		public StockLocation Location;
		public Guid SupplierId;
		public DateTime DateOfPurchase;
		public DateTime QuotedDeliveryDate;
		public Int32 Quantity;
		public Int32 Delivered;
		public Double UnitCost;
		public Guid StockItemId;
	} 
}