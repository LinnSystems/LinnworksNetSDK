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
	public class FieldVisibility
	{ 
		public String Name;
		public Boolean Visible;
		public Boolean CanFilter;
		public Boolean CanSort;
		public FieldTypes FieldType;
		public FieldCode Code;
		public List<FieldVisibility> SubFields;
		public Boolean IsFilterOnly;
		public String HotButtonIcon;
		public String HotButtonKey;
	} 
}