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
	public class RuleHeaderBasic
	{ 
		public Int32 pkRuleId;
		public String RuleName;
		public Boolean Enabled;
		public Int32 RunOrder;
		public RuleSetType RuleType;
		public Int32? pkRuleId_Draft;
		public Boolean Draft;
		public String RuleTypeDisplayName;
	} 
}