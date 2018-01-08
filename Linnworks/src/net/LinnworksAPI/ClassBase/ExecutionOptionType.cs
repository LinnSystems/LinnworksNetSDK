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
	public class ExecutionOptionType
	{ 
		public String Type;
		public String Key;
		public ExecutionOptionType StockLevelBySupplierCode_ZeroWhenNotProvided;
		public ExecutionOptionType FulfilmentCenterInventoryImport_OnlyMatchByFulfilmentSku;
	} 
}