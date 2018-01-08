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
	public class FieldsFilter
	{ 
		public List<TextFieldFilter> TextFields;
		public List<BooleanFieldFilter> BooleanFields;
		public List<NumericFieldFilter> NumericFields;
		public List<DateFieldFilter> DateFields;
		public List<ListFieldFilter> ListFields;
		public List<FieldVisibility> FieldVisibility;
	} 
}