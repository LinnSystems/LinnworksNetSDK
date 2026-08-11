using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// The information needed for an action 
    /// </summary>
    public class RuleActionInformation : LinnObject
	{
        /// <summary>
        /// The display name for the action 
        /// </summary>
		public String DisplayName { get; set; }

        /// <summary>
        /// The action type 
        /// </summary>
		public RulesEngineActionType Value { get; set; }

        /// <summary>
        /// A list of properties needed as inputs to run the action 
        /// </summary>
		public List<RuleActionPropertyInformation> Properties { get; set; }

        /// <summary>
        /// Data used to setup a grid if a grid of properties is used. 
        /// </summary>
		public RuleActionGridInformation GridInformation { get; set; }
	} 
}