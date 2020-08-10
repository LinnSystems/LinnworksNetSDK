using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteWarehouseToteRequest
	{
        /// <summary>
        /// List of warehouse tote ids to delete 
        /// </summary>
		public List<Int32> ToteIds { get; set; }

        /// <summary>
        /// Location id 
        /// </summary>
		public Guid LocationId { get; set; }
	} 
}