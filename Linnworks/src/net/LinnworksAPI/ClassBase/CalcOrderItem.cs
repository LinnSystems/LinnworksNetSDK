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
	public class CalcOrderItem
	{ 
		public Guid fkStockItemId;
		public Guid fkOrderItemId;
		public String SKU;
		public Int32 nQty;
		public Double ItemWeight;
		public Double DimHeight;
		public Double DimWidth;
		public Double DimDepth;
		public Guid PackageGroup;
		public Guid? fkCompositeParentRowId;
	} 
}