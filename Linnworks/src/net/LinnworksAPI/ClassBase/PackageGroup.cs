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
	public class PackageGroup
	{ 
		public Guid PackageCategoryID;
		public String PackageCategory;
		public Guid rowguid;
		public List<PackageType> PackageTypes;
	} 
}