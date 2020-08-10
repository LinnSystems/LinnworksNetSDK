using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for UpdateGroup 
    /// </summary>
    public class UpdateGroupRequest
	{
        /// <summary>
        /// Group id to update 
        /// </summary>
		public Int32 GroupId { get; set; }

        /// <summary>
        /// New name for a group. Nullable - not updated 
        /// </summary>
		public String Name { get; set; }

		public Int32? MaxOrderCount { get; set; }

        /// <summary>
        /// SQL of a condition. This is injected into the filtering of orders. Only used during Beta, in production this will be removed completely and replaced with condition evaluation definition class 
        /// </summary>
		public GroupCondition Condition { get; set; }

        /// <summary>
        /// List of actions in the order they should be executed. Only used during Beta, in production this will be removed completely and replaced action object 
        /// </summary>
		public GroupAction Action { get; set; }
	} 
}