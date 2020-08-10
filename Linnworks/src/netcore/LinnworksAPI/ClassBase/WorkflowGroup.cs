using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Workflow group item 
    /// </summary>
    public class WorkflowGroup
	{
        /// <summary>
        /// Group header object. Group condition will be stripped out in this method 
        /// </summary>
		public Group GroupHeader { get; set; }

        /// <summary>
        /// List of jobs. Order Ids will not be returned in this call 
        /// </summary>
		public List<Job> Jobs { get; set; }
	} 
}