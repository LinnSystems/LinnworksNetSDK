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
	public class GenericPagedResult<ScrapItem>
	{ 
		public Int32 PageNumber;
		public Int32 EntriesPerPage;
		public Int32 TotalEntries;
		public Int32 TotalPages;
		public List<ScrapItem> Data;
	} 
}