using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RuleAction
	{
		public Int32 pkActionId { get; set; }

		public String ActionName { get; set; }

		public ActionType ActionType { get; set; }

		public String ActionValue { get; set; }

		public Int32 fkConditionId { get; set; }

		public Int32 RuleVersion { get; set; }

		public Int32 fkRuleId { get; set; }

		public List<RuleActionProperty> Properties { get; set; }
	} 
}