using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteWarehouseToteResponse
	{
        /// <summary>
        /// deleted list of totes 
        /// </summary>
		public List<Int32> DeletedToteIds { get; set; }
	} 
}