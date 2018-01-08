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
	public class PackageResult
	{ 
		public Guid PackagingId;
		public Double Width;
		public Double Height;
		public Double Depth;
		public Decimal ItemWeight;
		public Decimal PackagingWeight;
		public IList<Face> Faces;
		public IList<PackedItem> Items;
		public Int32 LayerCount;
		public IDictionary<Int32,Face> LayerFace;
		public Boolean IsManualPackage;
	} 
}