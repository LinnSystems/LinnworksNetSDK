using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RuleHeaderBasic
	{
		public Int32 pkRuleId { get; set; }

		public String RuleName { get; set; }

		public Boolean Enabled { get; set; }

		public Int32 RunOrder { get; set; }

		public RuleSetType RuleType { get; set; }

		public Int32? pkRuleId_Draft { get; set; }

		public Boolean Draft { get; set; }

		public String RuleTypeDisplayName { get; set; }
	} 
}