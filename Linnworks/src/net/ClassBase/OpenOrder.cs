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
	public class OpenOrder
	{ 
		public String ORDER_NOT_FOUND_ERROR;
		public Guid OrderId;
		public Int32 NumOrderId;
		public OrderGeneralInfo GeneralInfo;
		public OrderShippingInfo ShippingInfo;
		public OrderCustomerInfo CustomerInfo;
		public OrderTotalsInfo TotalsInfo;
		public List<String> FolderName;
		public List<OrderItem> Items;
	} 
}