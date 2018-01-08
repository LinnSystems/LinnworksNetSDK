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
	public class ReturnOrderHeader
	{ 
		public Guid pkOrderId;
		public Int32 nOrderId;
		public String Source;
		public String SubSource;
		public String PostalServiceName;
		public String cShippingAddress;
		public String cCurrency;
		public DateTime dReceivedDate;
		public DateTime dProcessedOn;
		public Double fTotalCharge;
		public String RefundLink;
	} 
}