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
	public class PurchaseOrderExtendedProperty
	{ 
		public Int32 RowId;
		public Guid PurchaseID;
		public DateTime AddedDateTime;
		public String UserName;
		public String PropertyName;
		public String PropertyValue;
	} 
}