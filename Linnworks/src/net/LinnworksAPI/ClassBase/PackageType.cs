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
	public class PackageType
	{ 
		public Guid PackageTypeId;
		public Guid PackageGroupId;
		public String PackageTitle;
		public Double FromGramms;
		public Double ToGramms;
		public Double PackagingWeight;
		public Double PackagingCapacity;
		public Guid Rowguid;
		public Double Width;
		public Double Height;
		public Double Depth;
	} 
}