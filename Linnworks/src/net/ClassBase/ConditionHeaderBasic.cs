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
	public class ConditionHeaderBasic
	{ 
		public Int32 pkConditionId;
		public Int32? fkParentConditionId;
		public Int32 fkRuleId;
		public String ConditionName;
		public Boolean Enabled;
		public List<ConditionItemBasic> Conditions;
	} 
}