using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetGroupRequest : LinnObject
	{
        /// <summary>
        /// Specific group id you want to retrive information for 
        /// </summary>
		public Int32 GroupId { get; set; }
	} 
}