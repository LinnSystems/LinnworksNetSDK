using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Get_OpenOrderBasicInfoFromItemsRequest
	{
        /// <summary>
        /// List of open order iems ids to get info 
        /// </summary>
		public List<Guid> OpenOrderItems { get; set; }
	} 
}