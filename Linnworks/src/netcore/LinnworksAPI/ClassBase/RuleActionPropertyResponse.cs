using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// The actual property data saved for this action 
    /// </summary>
    public class RuleActionPropertyResponse : LinnObject
	{
        /// <summary>
        /// identifier for this action property 
        /// </summary>
		public Int32 ActionPropertyId { get; set; }

        /// <summary>
        /// The name of the property 
        /// </summary>
		public String DisplayName { get; set; }

        /// <summary>
        /// The actual data input for the property 
        /// </summary>
		public String Value { get; set; }

        /// <summary>
        /// Property grouping key. Used if there are multiple properties with the same name under one action. 
        /// </summary>
		public Int32 PropertyGroupId { get; set; }
	} 
}