using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AssignStockToOrdersResponse<OrderItemBatchExtended,Guid>
	{
		public BatchActionResult<OrderItemBatchExtended,Guid> BatchActionResult { get; set; }
	} 
}