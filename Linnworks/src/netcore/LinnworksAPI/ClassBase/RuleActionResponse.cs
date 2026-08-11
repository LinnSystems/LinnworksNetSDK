using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// The actual action saved in the rule. 
    /// </summary>
    public class RuleActionResponse : LinnObject
	{
		public Int32 pkActionId { get; set; }

        /// <summary>
        /// The condition the action runs on. 
        /// </summary>
		public Int32 fkConditionId { get; set; }

        /// <summary>
        /// The name of the action 
        /// </summary>
		public String ActionName { get; set; }

        /// <summary>
        /// The type of the action 
        /// </summary>
		public RulesEngineActionType ActionType { get; set; }

        /// <summary>
        /// Data the action needs to run. 
        /// </summary>
		public List<RuleActionPropertyResponse> Properties { get; set; }
	} 
}