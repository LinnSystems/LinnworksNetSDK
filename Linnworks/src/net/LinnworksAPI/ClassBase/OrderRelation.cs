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
	public class OrderRelation
	{ 
		public Int32 ChildOrderId;
		public Guid ChildOrderPkOrderId;
		public Int32 ParentOrderId;
		public Guid ParentOrderPkOrderId;
		public String RelationType;
	} 
}