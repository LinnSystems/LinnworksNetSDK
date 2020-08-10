using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request object for GetWorkflow method 
    /// </summary>
    public class GetWorkflowRequest
	{
        /// <summary>
        /// Location id for which the workflow will be retrieved 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// Optional - you can specify a specific group id. The result will only return jobs within this group. 
        /// </summary>
		public Int32? GroupId { get; set; }
	} 
}