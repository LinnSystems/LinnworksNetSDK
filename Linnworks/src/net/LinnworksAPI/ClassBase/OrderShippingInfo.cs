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
	public class OrderShippingInfo
	{ 
		public String Vendor;
		public Guid PostalServiceId;
		public String PostalServiceName;
		public Double TotalWeight;
		public Double ItemWeight;
		public Guid PackageCategoryId;
		public String PackageCategory;
		public Guid? PackageTypeId;
		public String PackageType;
		public Double PostageCost;
		public Double PostageCostExTax;
		public String TrackingNumber;
		public Boolean ManualAdjust;
	} 
}