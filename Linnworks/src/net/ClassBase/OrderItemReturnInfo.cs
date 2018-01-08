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
	public class OrderItemReturnInfo
	{ 
		public List<OrderItemReturnInfo> ChildItems;
		public OrderItemReturnInfoBatched[] Batches;
		public Guid fkOrderItemRowId;
		public Guid ParentRowId;
		public Int32 ReturnableQty;
		public Int32 OrderQty;
		public Int32 ReturnedQty;
		public String SKU;
		public String ItemTitle;
		public Double UnitValue;
		public Double TaxRate;
		public Boolean TaxCostInclusive;
		public String Currency;
		public Boolean IsCompositeParent;
		public Boolean IsPartialCompositeReturn;
		public Int32 ParentRatio;
		public Guid? pkStockItemId;
		public Int32 ResentQty;
	} 
}