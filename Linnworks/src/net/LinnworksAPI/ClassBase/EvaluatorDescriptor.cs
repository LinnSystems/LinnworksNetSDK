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
	public class EvaluatorDescriptor
	{ 
		public EvaluatorType EvaluatorType;
		public ClientEvaluatorGroupType ClientType;
		public String ClientTypeName;
		public EvaluatorGroup EvaluatorGroup;
		public String Description;
		public Int32 GroupIndex;
		public Int32 EvalIndex;
	} 
}