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
	public class OrderDetails
	{ 
		public Guid OrderId;
		public Int32 NumOrderId;
		public Boolean Processed;
		public DateTime? ProcessedDateTime;
		public Guid FulfilmentLocationId;
		public OrderGeneralInfo GeneralInfo;
		public OrderShippingInfo ShippingInfo;
		public OrderCustomerInfo CustomerInfo;
		public OrderTotalsInfo TotalsInfo;
		public List<ExtendedProperty> ExtendedProperties;
		public List<String> FolderName;
		public List<OrderItem> Items;
		public List<OrderNote> Notes;
	} 
}