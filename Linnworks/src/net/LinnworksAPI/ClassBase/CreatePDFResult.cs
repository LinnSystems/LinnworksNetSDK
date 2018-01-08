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
	public class CreatePDFResult
	{ 
		public List<PrintError> KeyedError;
		public String URL;
		public List<Guid> IdsProcessed;
		public Dictionary<String,List<Guid>> ProcessedIds;
		public List<String> PrintErrors;
	} 
}