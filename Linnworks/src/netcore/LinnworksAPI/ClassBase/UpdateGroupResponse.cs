using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response of a UpdateGroup method 
    /// </summary>
    public class UpdateGroupResponse : LinnObject
	{
        /// <summary>
        /// Updated group details 
        /// </summary>
		public Group Group { get; set; }
	} 
}