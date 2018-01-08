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
	public class PackedItem
	{ 
		public Guid ID;
		public Guid PkStockItemId;
		public String SKU;
		public Double Width;
		public Double Height;
		public Double Depth;
		public Decimal Weight;
		public Double X;
		public Double Y;
		public Double Z;
		public Int32 Layer;
		public IList<Face> Faces;
	} 
}