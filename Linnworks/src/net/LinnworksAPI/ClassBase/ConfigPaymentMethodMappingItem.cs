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
	public class ConfigPaymentMethodMappingItem
	{ 
		public Int32 fkChannelId;
		public Int32 pkRowId;
		public String Tag;
		public Guid fkBankId;
		public String PaymentMethodName;
		public String Site;
		public Boolean IsChanged;
	} 
}