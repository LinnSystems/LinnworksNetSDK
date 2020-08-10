using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteRMARequest
	{
        /// <summary>
        /// Identifies the RMA header to be deleted 
        /// </summary>
		public Int32 RMAHeaderId { get; set; }
	} 
}