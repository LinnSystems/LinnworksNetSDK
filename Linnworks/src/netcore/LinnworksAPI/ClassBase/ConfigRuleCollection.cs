using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigRuleCollection : LinnObject
	{
		public ConfigRule Item { get; set; }

		public List<ConfigRule> Items { get; set; }
	} 
}