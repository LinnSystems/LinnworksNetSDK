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
	public class ActionWeb
	{ 
		public Int32? pkActionId;
		public Int32 fkConditionId;
		public String ActionName;
		public ActionType ActionType;
		public List<ActionWebProperty> Properties;
	} 
}