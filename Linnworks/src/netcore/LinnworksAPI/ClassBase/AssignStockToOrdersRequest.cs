using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AssignStockToOrdersRequest
	{
		public List<Guid> OrderIds { get; set; }

		public BatchAssignmentMode BatchAssignmentMode { get; set; }
	} 
}