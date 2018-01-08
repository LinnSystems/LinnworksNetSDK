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
	public class OrderTotalsInfo
	{ 
		public Double Subtotal;
		public Double PostageCost;
		public Double Tax;
		public Double TotalCharge;
		public String PaymentMethod;
		public Guid PaymentMethodId;
		public Double ProfitMargin;
		public Double TotalDiscount;
		public String Currency;
		public Double CountryTaxRate;
	} 
}