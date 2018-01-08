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
	public class ExportSpecification
	{ 
		public Boolean ExportColumnNames;
		public String Delimiter;
		public String Escape;
		public String CustomScript;
		public ExportGenericFeed Feed;
		public List<ExportColumn> ColumnMappings;
		public List<ExecutionOption> ExecutionOptions;
	} 
}