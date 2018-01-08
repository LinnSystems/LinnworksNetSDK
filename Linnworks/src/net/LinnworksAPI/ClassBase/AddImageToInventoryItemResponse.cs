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
	public class AddImageToInventoryItemResponse
	{ 
		public Guid StockItemId;
		public Guid ImageId;
		public String ImageUrl;
		public String ImageThumbnailUrl;
	} 
}