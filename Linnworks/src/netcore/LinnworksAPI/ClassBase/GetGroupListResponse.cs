using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetGroupListResponse
	{
        /// <summary>
        /// List of groups. Does not return condition and actions objects 
        /// </summary>
		public List<Group> GroupList { get; set; }
	} 
}