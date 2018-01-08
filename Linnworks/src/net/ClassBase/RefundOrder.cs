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
	public class RefundOrder
	{ 
		public Guid pkOrderID;
		public Int32 nOrderId;
		public String cFullName;
		public String Source;
		public String SubSource;
		public Double Amount;
		public String IssueRefundUrl;
		public String cCurrency;
		public String ReferenceNum;
		public String SecondaryReference;
		public String RefundReference;
		public DateTime RefundDate;
		public Double SubTotal;
		public Double Total;
		public Double TaxRate;
	} 
}