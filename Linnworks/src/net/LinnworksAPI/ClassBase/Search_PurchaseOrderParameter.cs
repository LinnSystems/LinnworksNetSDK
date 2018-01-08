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
	public class Search_PurchaseOrderParameter
	{ 
		public DateTime? DateFrom;
		public DateTime? DateTo;
		public PurchaseOrderStatus? Status;
		public String ReferenceLike;
		public Int32 EntriesPerPage;
		public Int32 PageNumber;
		public List<Guid> Location;
		public List<Guid> Supplier;
	} 
}