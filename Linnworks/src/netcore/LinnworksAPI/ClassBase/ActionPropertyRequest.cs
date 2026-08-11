using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionPropertyRequest : LinnObject
	{
        /// <summary>
        /// The name of the property 
        /// </summary>
		public String DisplayName { get; set; }

        /// <summary>
        /// The actual data input for the property 
        /// </summary>
		public String Value { get; set; }

        /// <summary>
        /// The unique identifier for this action property. If not provided the property will be created as new property. 
        /// </summary>
		public Int32? ActionPropertyId { get; set; }

        /// <summary>
        /// Property grouping key. Used if there are multiple properties with the same name under one action. Defaults to 1. 
        /// </summary>
		public Int32 PropertyGroupId { get; set; }
	} 
}