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
	public class FieldDescriptor
	{ 
		public String Name;
		public String FieldName;
		public String FieldGroup;
		public Boolean IsASet;
		public List<EvaluatorGroup> ValidEvaluatorGroups;
		public String Key;
		public String KeyDisplayName;
		public Boolean HasKeyOptions;
		public Boolean HasAttributeKey;
		public Boolean HasOptions;
		public DisplayType DisplayType;
		public Boolean ExactMatchRequired;
	} 
}