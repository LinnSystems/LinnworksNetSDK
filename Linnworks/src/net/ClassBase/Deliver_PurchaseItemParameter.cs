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
	public class Deliver_PurchaseItemParameter
	{ 
		public String BatchNumber;
		public String BinRack;
		public Int32 PrioritySequence;
		public String BatchStatus;
		public Guid pkPurchaseId;
		public Guid pkPurchaseItemId;
		public Int32? Delivered;
		public Int32? AddToDelivered;
	} 
}