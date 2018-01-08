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
	public class ExportColumn
	{ 
		public Int32 Order;
		public Filters Filters;
		public Boolean ExportToFile;
		public List<SubQueryOutputMappingSelectionField> SubQuerySelection;
		public String FileColumn;
		public String Column;
		public String Expression;
		public String DefaultValue;
		public Boolean Visible;
	} 
}