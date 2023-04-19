using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PropertyRule : LinnObject
	{
		public PropertyRuleType RuleType { get; set; }

		public String Options { get; set; }

		public String DependantField { get; set; }
	} 
}