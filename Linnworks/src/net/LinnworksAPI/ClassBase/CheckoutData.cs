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
	public class CheckoutData
	{ 
		public String CurrencyCode;
		public String CurrencySymbol;
		public CheckoutItem Item;
		public TotalsInformation TotalsInformation;
		public Double TaxRate;
	} 
}