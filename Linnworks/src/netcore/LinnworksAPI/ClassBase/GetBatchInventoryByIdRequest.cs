using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetBatchInventoryByIdRequest
	{
		public List<Int32> BatchInventoryIds { get; set; }

		public Boolean LoadRelatedInventoryLines { get; set; }
	} 
}