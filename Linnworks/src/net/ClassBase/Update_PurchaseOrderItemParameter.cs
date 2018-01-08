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
	public class Update_PurchaseOrderItemParameter
	{ 
		public Guid pkPurchaseItemId;
		public Guid pkPurchaseId;
		public Int32? Quantity;
		public Int32? PackQuantity;
		public Int32? PackSize;
		public Decimal? Cost;
		public Decimal? TaxRate;
	} 
}