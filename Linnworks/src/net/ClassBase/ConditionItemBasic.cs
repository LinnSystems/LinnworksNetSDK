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
	public class ConditionItemBasic
	{ 
		public Int32 pkConditionItemId;
		public Int32 fkConditionId;
		public String FieldName;
		public EvaluatorType Evaluation;
		public List<String> Values;
		public String KeyValue;
	} 
}