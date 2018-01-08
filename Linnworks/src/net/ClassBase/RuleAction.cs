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
	public class RuleAction
	{ 
		public Int32 pkActionId;
		public String ActionName;
		public ActionType ActionType;
		public String ActionValue;
		public Int32 fkConditionId;
		public Int32 RuleVersion;
		public Int32 fkRuleId;
		public List<RuleActionProperty> Properties;
	} 
}