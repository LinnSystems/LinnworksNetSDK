using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RuleConditionHeader
	{
		public Int32 pkConditionId { get; set; }

		public Int32 fkRuleId { get; set; }

		public Int32 RunOrder { get; set; }

		public Boolean Enabled { get; set; }

		public String ConditionName { get; set; }

		public Int32 fkParentConditionId { get; set; }

		public List<IRuleConditionItem> Conditions { get; set; }

		public RuleAction Action { get; set; }

		public List<RuleConditionHeader> Subrules { get; set; }
	} 
}