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
	public class BookedReturnsExchangeOrder
	{ 
		public Guid pkOrderID;
		public Int32 nOrderId;
		public String ReferenceNum;
		public String SecondaryReference;
		public String cFullName;
		public DateTime ReturnDate;
	} 
}