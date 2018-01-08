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
	public class FulfilmentCenterImportExportSettings
	{ 
		public Guid fkStockLocationId;
		public Int32 fkOrdersExportId;
		public Int32 fkOrdersImportId;
		public Int32 fkInventoryImportId;
		public Boolean OrdersExportEnabled;
		public Boolean OrdersImportEnabled;
		public Boolean InventoryImportEnabled;
	} 
}