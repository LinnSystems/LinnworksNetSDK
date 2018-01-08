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
	public class RuleConditionHeader
	{ 
		public Int32 pkConditionId;
		public Int32 fkRuleId;
		public Int32 RunOrder;
		public Boolean Enabled;
		public String ConditionName;
		public Int32 fkParentConditionId;
		public List<IRuleConditionItem> Conditions;
		public RuleAction Action;
		public List<RuleConditionHeader> Subrules;
	} 
}