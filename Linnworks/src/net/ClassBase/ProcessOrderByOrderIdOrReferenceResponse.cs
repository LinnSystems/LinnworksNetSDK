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
	public class ProcessOrderByOrderIdOrReferenceResponse
	{ 
		public OrderProcessedState ProcessedState;
		public String Message;
		public Object Response;
		public Guid OrderId;
		public OrderSummary OrderSummary;
		public List<OrderItem> Items;
		public List<StockItemBatch> BatchInformation;
	} 
}