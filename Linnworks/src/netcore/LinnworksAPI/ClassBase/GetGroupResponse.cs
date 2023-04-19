using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetGroupResponse : LinnObject
	{
        /// <summary>
        /// Full group object with conditions, list of actions and count of all orders and jobs To Do 
        /// </summary>
		public Group Group { get; set; }
	} 
}